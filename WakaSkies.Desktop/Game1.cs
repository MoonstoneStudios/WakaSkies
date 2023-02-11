using FontStashSharp.Rasterizers.StbTrueTypeSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Myra;
using Myra.Assets;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.UI.File;
using Myra.Graphics2D.UI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WakaSkies.Desktop.UI;
using WakaSkies.WakaAPI;
using WakaSkies.WakaModelBuilder;

using MDesktop = Myra.Graphics2D.UI.Desktop;

namespace WakaSkies.Desktop
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private MDesktop ui;
        private MoreSettings moreSettings;
        private bool textBoxVisible = true;

        private Camera camera;
        private Skybox skybox;
        private ModelManager modelManager;

        private int selectedSkybox;
        private bool backgroundSettingsOpen;
        private Dictionary<string, TextureCube> skyboxTextures = new Dictionary<string, TextureCube>();

        private BackgroundSelect backgroundSelect;
        private BackgroundSelectClosed backgroundSelectClosed;

        private RasterizerState rasterizer = new RasterizerState()
        {
            CullMode = CullMode.None
        };

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            Window.Title = "WakaSkies 1.0.0";
            GraphicsDevice.PresentationParameters.BackBufferWidth = 1280;
            GraphicsDevice.PresentationParameters.BackBufferHeight = 720;

            Window.AllowUserResizing = true;
            Window.ClientSizeChanged += (s, e) =>
            {
                // change the aspect ratio of the camera.
                camera.ChangeSize(GraphicsDevice.PresentationParameters.BackBufferWidth,
                    GraphicsDevice.PresentationParameters.BackBufferHeight);

                // center the settings.
                var moreSettings = (MoreSettings)ui.GetWidgetByID("moreSettingsDialog");
                if (moreSettings != null)
                {
                    // center the center of the window.
                    moreSettings.Left = (Window.ClientBounds.Width / 2) - (moreSettings.Bounds.Width / 2);
                    moreSettings.Top = (Window.ClientBounds.Height / 2) - (moreSettings.Bounds.Height / 2);
                }
            };

            base.Initialize();
        }

        protected override async void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // random skybox
            var rand = new Random();
            selectedSkybox = rand.Next(0, 7);
            string name = $"Skyboxes/skybox{selectedSkybox}";
            skybox = new Skybox(name, Content);
            skyboxTextures.Add(name, skybox.skyBoxTexture);

            // setup UI.
            SetupStartUI();

            camera = new Camera();
            modelManager = new ModelManager();

            modelManager.LoadContent(GraphicsDevice);
        }

        protected override async void Update(GameTime gameTime)
        {
            camera.Update(gameTime);
            base.Update(gameTime);
        }

        protected override bool BeginDraw()
        {
            // reset the Graphics Device.
            // the SpriteBatch messes with it.
            GraphicsDevice.BlendState = BlendState.Opaque;
            GraphicsDevice.DepthStencilState = DepthStencilState.Default;
            GraphicsDevice.RasterizerState = rasterizer;
            return base.BeginDraw();
        }

        protected override async void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateBlue);

            skybox.Draw(camera.view, camera.projection, camera.cameraPos);
            modelManager.Draw(GraphicsDevice, camera);
            ui.Render();

            base.Draw(gameTime);
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
                textBoxVisible = true;

                ui.Widgets.Remove(icons);
                camera.StopRotation();
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
                    if (!files.Result) return;

                    try
                    {
                        // serialize.
                        var serializer = new STLSerializer();

                        if (exportAsASCII.IsChecked)
                        {
                            // serialize as text.
                            var stl = serializer.Serialize(modelManager.model);

                            // write
                            File.WriteAllText(files.FilePath, stl);
                        }
                        else
                        {
                            // serialize as binary.
                            serializer.SerializeBinary(files.FilePath, modelManager.model);
                        }

                        var notice = new NoticeWindow();
                        notice.contentLabel.Text = $"{Path.GetFileName(files.FilePath)} has been exported successfully!";
                        notice.Title = "Done";
                        notice.closeButton.Click += (s, a) =>
                        {
                            notice.Close();
                        };

                        notice.Show(ui);
                    }
                    catch(Exception ex)
                    {
                        var notice = new NoticeWindow();
                        notice.contentLabel.Text = $"An error occurred while trying to save the file. Error: {ex.Message}";
                        notice.Title = "Error";
                        notice.closeButton.Click += (s, a) =>
                        {
                            notice.Close();
                        };

                        notice.Show(ui);
                    }
                };

                files.ShowModal(ui);
            };

            // hide start UI.
            start.Visible = false;
            textBoxVisible = false;
        }
        
        /// <summary>
        /// Add the StartMenu UI.
        /// </summary>
        private async void SetupStartUI()
        {
            // setup Myra
            MyraEnvironment.Game = this;
            MyraEnvironment.DefaultAssetManager.AssetResolver =
                new FileAssetResolver(Path.Combine(Directory.GetCurrentDirectory(), Content.RootDirectory));
            ui = new MDesktop();

            ui.HasExternalTextInput = true;
            Window.TextInput += (s, a) =>
            {
                ui.OnChar(a.Character);
            };

            // add start menu
            var startMenu = new StartMenu();
            startMenu.generateButton.Click += async (s, e) =>
            {
                if (await modelManager.GenerateModel(ui, camera))
                {
                    AddIconsUI();
                }
            };

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

            // more settings
            moreSettings = new MoreSettings();
            startMenu.moreSettings.Click += (s, a) =>
            {
                startMenu.moreSettings.Enabled = false;

                moreSettings.ShowModal(ui);
            };

            moreSettings.useDefaultTimeout.Click += (s, a) =>
            {
                moreSettings.timeoutOptions.Visible = !moreSettings.useDefaultTimeout.IsChecked;
            };

            // set data on close.
            moreSettings.Closed += (s, a) =>
            {
                if (moreSettings.Result)
                {
                    modelManager.buildSettings = new ModelBuildSettings()
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

            var newButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{selectedSkybox}").First();
            newButton.Background = new SolidBrush(Color.White);

            // add closed BG
            ui.Widgets.Add(backgroundSelectClosed);
        }

        private void BackgroundButtonClick(object sender, EventArgs e)
        {
            var prevSkybox = selectedSkybox;
            var button = (ImageButton)sender;
            var lastNum = int.Parse(button.Id[^1].ToString());
            if (selectedSkybox == lastNum) return;
            selectedSkybox = lastNum;

            string sbName = $"Skyboxes/skybox{selectedSkybox}";
            if (skyboxTextures.ContainsKey(sbName))
            {
                skybox.skyBoxTexture = skyboxTextures[sbName];
            }
            else
            {
                var cube = Content.Load<TextureCube>(sbName);
                skybox.skyBoxTexture = cube;
                skyboxTextures.Add(sbName, cube);
            }


            var stack = (HorizontalStackPanel)backgroundSelect.Widgets.Where(w => w.GetType() == typeof(HorizontalStackPanel)).First();
            var newButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{selectedSkybox}").First();
            var oldButton = (ImageButton)stack.Widgets.Where(w => w.Id == $"background{prevSkybox}").First();
            oldButton.Background = new SolidBrush("#333333");
            newButton.Background = new SolidBrush(Color.White);
            oldButton.OverBackground = new SolidBrush("#3e3e42");
            newButton.OverBackground = new SolidBrush("#cccccc");
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