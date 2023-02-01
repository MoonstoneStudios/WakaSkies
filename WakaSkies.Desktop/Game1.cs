using FontStashSharp.Rasterizers.StbTrueTypeSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Myra;
using Myra.Assets;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.UI.File;
using Myra.Graphics2D.UI.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WakaSkies.Desktop.GUI;
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
            };

            base.Initialize();
        }

        protected override async void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // setup UI.
            SetupStartUI();

            skybox = new Skybox("cubemap", Content);
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

                // when the file dialog is done.
                files.Closed += (s, a) =>
                {
                    if (!files.Result) return;

                    try
                    {
                        // serialize.
                        var serializer = new STLSerializer();
                        var stl = serializer.Serialize(modelManager.model);

                        if (!Path.HasExtension(files.FilePath))
                        {
                            Path.ChangeExtension(files.FilePath, ".stl");
                        }

                        // write
                        File.WriteAllText(files.FilePath, stl);

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
            MyraEnvironment.Game = this;
            MyraEnvironment.DefaultAssetManager.AssetResolver =
                new FileAssetResolver(Path.Combine(Directory.GetCurrentDirectory(), Content.RootDirectory));
            ui = new MDesktop();

            ui.HasExternalTextInput = true;
            Window.TextInput += (s, a) =>
            {
                ui.OnChar(a.Character);
            };

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

            moreSettings = new MoreSettings();

            startMenu.moreSettings.Click += (s, a) =>
            {
                startMenu.moreSettings.Enabled = false;

                moreSettings.ShowModal(ui);
            };

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
                        AddBorder = moreSettings.addBorder.IsChecked
                    };
                }

                startMenu.moreSettings.Enabled = true;
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