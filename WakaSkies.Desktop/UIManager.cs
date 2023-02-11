using Myra.Assets;
using Myra.Graphics2D.UI;
using Myra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.Desktop.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;
using Myra.Graphics2D.UI.File;
using Microsoft.Xna.Framework.Graphics;
using Myra.Graphics2D.Brushes;
using WakaSkies.WakaModelBuilder;

using MDesktop = Myra.Graphics2D.UI.Desktop;

namespace WakaSkies.Desktop
{
    internal class UIManager
    {

        private MDesktop ui;
        public MoreSettings moreSettings;
        private StartMenu startMenu;
        private BackgroundSelect backgroundSelect;
        private BackgroundSelectClosed backgroundSelectClosed;

        private Game1 game;

        /// <summary>
        /// Add the StartMenu UI.
        /// </summary>
        public async void SetupStartUI(Game1 game, ContentManager content)
        {
            // setup Myra
            this.game = game;
            MyraEnvironment.Game = game;
            MyraEnvironment.DefaultAssetManager.AssetResolver =
                new FileAssetResolver(Path.Combine(Directory.GetCurrentDirectory(), content.RootDirectory));
            ui = new MDesktop();

            ui.HasExternalTextInput = true;
            game.Window.TextInput += (s, a) =>
            {
                ui.OnChar(a.Character);
            };

            SetupStartMenu();
            SetupMoreSettings();
            SetupBackgroundSelector();
            SetupResize();
        }

        /// <summary>
        /// Setup the start menu.
        /// </summary>
        private void SetupStartMenu()
        {
            // add start menu
            startMenu = new StartMenu();
            startMenu.generateButton.Click += async (s, e) =>
            {
                // if generation is complete.
                if (await game.modelManager.GenerateModel(ui, game.camera))
                {
                    // add icons.
                    AddIconsUI();
                }
            };

            // open browser for API key.
            startMenu.wakaUnsureButton.Click += (s, e) =>
            {
                OpenBrowser("https://wakatime.com/api-key");
            };

            ui.Root = startMenu;

            // notice header
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                var header = new NoticeHeader();
                header.noticeText.Text = "WakaSkies has not yet been tested on your operating system. " +
                    "If bugs appear, a PR to the GitHub repo would be amazing!";
                header.closeButton.Click += (s, a) =>
                {
                    ui.Widgets.Remove(header);
                };

                ui.Widgets.Add(header);
            }
        }

        /// <summary>
        /// Setup the more settings UI.
        /// </summary>
        private void SetupMoreSettings()
        {
            // more settings
            moreSettings = new MoreSettings();
            startMenu.moreSettings.Click += (s, a) =>
            {
                startMenu.moreSettings.Enabled = false;

                moreSettings.ShowModal(ui);
            };

            // default timeout hiding.
            moreSettings.useDefaultTimeout.Click += (s, a) =>
            {
                moreSettings.timeoutOptions.Visible = !moreSettings.useDefaultTimeout.IsChecked;
            };

            // set data on close.
            moreSettings.Closed += (s, a) =>
            {
                if (moreSettings.Result)
                {
                    // set the settings.
                    game.modelManager.buildSettings = new ModelBuildSettings()
                    {
                        AddStatistics = moreSettings.generateStats.IsChecked,
                        RoundToNearestHour = moreSettings.roundHour.IsChecked,
                        MinumimHours = (int)moreSettings.minHours.Value,
                        MinimumBarHeight = (int)moreSettings.minHeight.Value,
                        MaximumBarHeight = (int)moreSettings.maxHeight.Value,
                        AddBorder = moreSettings.addBorder.IsChecked,
                        Timeout = moreSettings.useDefaultTimeout.IsChecked ? null : (int)moreSettings.timeout.Value
                    };
                }

                startMenu.moreSettings.Enabled = true;
            };
        }

        /// <summary>
        /// Setup the background selector.
        /// </summary>
        private void SetupBackgroundSelector()
        {
            backgroundSelect = new BackgroundSelect();
            backgroundSelectClosed = new BackgroundSelectClosed();
            backgroundSelect.background0.Click += BackgroundButtonClick;
            backgroundSelect.background1.Click += BackgroundButtonClick;
            backgroundSelect.background2.Click += BackgroundButtonClick;
            backgroundSelect.background3.Click += BackgroundButtonClick;
            backgroundSelect.background4.Click += BackgroundButtonClick;
            backgroundSelect.background5.Click += BackgroundButtonClick;
            backgroundSelect.background6.Click += BackgroundButtonClick;

            backgroundSelect.closeBackground.Click += (s, e) =>
            {
                ui.Widgets.Remove(backgroundSelect);
                ui.Widgets.Add(backgroundSelectClosed);
            };
            backgroundSelectClosed.openBackground.Click += (s, e) =>
            {
                ui.Widgets.Remove(backgroundSelectClosed);
                ui.Widgets.Add(backgroundSelect);
            };

            var stack = (HorizontalStackPanel)backgroundSelect.Widgets.Where(w => w.GetType() == typeof(HorizontalStackPanel)).First();

            var newButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{game.selectedSkybox}").First();
            newButton.Background = new SolidBrush(Color.White);

            // add closed BG
            ui.Widgets.Add(backgroundSelectClosed);

        }

        /// <summary>
        /// When a background select button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundButtonClick(object sender, EventArgs e)
        {
            var prevSkybox = game.selectedSkybox;
            var button = (ImageButton)sender;
            var lastNum = int.Parse(button.Id[^1].ToString());
            if (game.selectedSkybox == lastNum) return;
            game.selectedSkybox = lastNum;

            string sbName = $"Skyboxes/skybox{game.selectedSkybox}";
            if (game.skyboxTextures.ContainsKey(sbName))
            {
                game.skybox.skyBoxTexture = game.skyboxTextures[sbName];
            }
            else
            {
                var cube = game.Content.Load<TextureCube>(sbName);
                game.skybox.skyBoxTexture = cube;
                game.skyboxTextures.Add(sbName, cube);
            }


            var stack = (HorizontalStackPanel)backgroundSelect.Widgets.Where(w => w.GetType() == typeof(HorizontalStackPanel)).First();
            var newButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{game.selectedSkybox}").First();
            var oldButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{prevSkybox}").First();
            oldButton.Background = new SolidBrush("#333333");
            newButton.Background = new SolidBrush(Color.White);
            oldButton.OverBackground = new SolidBrush("#3e3e42");
            newButton.OverBackground = new SolidBrush("#cccccc");
        }

        /// <summary>
        /// Add the Icons ui.
        /// </summary>
        private void AddIconsUI()
        {
            var start = (StartMenu)ui.Root;
            var icons = new Icons();
            ui.Widgets.Add(icons);

            // setup buttons
            icons.homeButton.Click += (s, e) =>
            {
                start.Visible = true;

                ui.Widgets.Remove(icons);
                game.camera.StopRotation();
            };

            // setup buttons
            icons.downloadButton.Click += (s, e) =>
            {
                var files = new FileDialog(FileDialogMode.SaveFile)
                {
                    Filter = "*.stl"
                };

                // add a checkbox
                var stack = (VerticalStackPanel)files.Content;
                var exportAsASCII = new CheckBox()
                {
                    Text = "Export as ASCII (bigger file size)  ",
                    TextPosition = ImageTextButton.TextPositionEnum.Left,
                    IsChecked = false,
                    Id = "exportAsASCII"
                };
                stack.Widgets.Add(exportAsASCII);

                // when the file dialog is done.
                files.Closed += (s, a) =>
                {
                    SaveModel(files, exportAsASCII);
                };

                files.ShowModal(ui);
            };

            // hide start UI.
            start.Visible = false;
        }

        /// <summary>
        /// Save the model when the file dialog is finished.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="exportAsASCII"></param>
        private void SaveModel(FileDialog files, CheckBox exportAsASCII)
        {
            // canceled
            if (!files.Result) return;

            try
            {
                // serialize.
                var serializer = new STLSerializer();

                if (exportAsASCII.IsChecked)
                {
                    // serialize as text.
                    var stl = serializer.Serialize(game.modelManager.model);

                    // write
                    System.IO.File.WriteAllText(files.FilePath, stl);
                }
                else
                {
                    // serialize as binary.
                    serializer.SerializeBinary(files.FilePath, game.modelManager.model);
                }

                // create a notice.
                var notice = new NoticeWindow();
                notice.contentLabel.Text = $"{Path.GetFileName(files.FilePath)} has been exported successfully!";
                notice.Title = "Done";
                notice.closeButton.Click += (s, a) =>
                {
                    notice.Close();
                };

                notice.Show(ui);
            }
            catch (Exception ex)
            {
                // show a notice window.
                var notice = new NoticeWindow();
                notice.contentLabel.Text = $"An error occurred while trying to save the file. Error: {ex.Message}";
                notice.Title = "Error";
                notice.closeButton.Click += (s, a) =>
                {
                    notice.Close();
                };

                notice.Show(ui);
            }
        }

        /// <summary>
        /// Render the ui.
        /// </summary>
        public void Render() => ui.Render();

        /// <summary>
        /// Setup the resize logic to center the settings window.
        /// </summary>
        public void SetupResize()
        {
            game.Window.ClientSizeChanged += (s, e) =>
            {
                // change the aspect ratio of the camera.
                game.camera.ChangeSize(game.GraphicsDevice.PresentationParameters.BackBufferWidth,
                    game.GraphicsDevice.PresentationParameters.BackBufferHeight);

                // center the settings.
                if (moreSettings != null)
                {
                    // center the center of the window.
                    moreSettings.Left = (game.Window.ClientBounds.Width / 2) - (moreSettings.Bounds.Width / 2);
                    moreSettings.Top = (game.Window.ClientBounds.Height / 2) - (moreSettings.Bounds.Height / 2);
                }
            };
        }

        // credit: https://brockallen.com/2016/09/24/process-start-for-urls-on-net-core/
        private void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
