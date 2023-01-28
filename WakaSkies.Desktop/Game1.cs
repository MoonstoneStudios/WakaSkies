using FontStashSharp.Rasterizers.StbTrueTypeSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Myra;
using Myra.Assets;
using Myra.Graphics2D.UI.File;
using System;
using System.Diagnostics;
using System.IO;
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

            Window.Title = "WakaSkies Beta 1.0.0";
        }

        protected override void Initialize()
        {
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

                    // serialize.
                    var serializer = new STLSerializer();
                    var stl = serializer.Serialize(modelManager.model);

                    if (!Path.HasExtension(files.FilePath))
                    {
                        Path.ChangeExtension(files.FilePath, ".stl");
                    }

                    // write
                    File.WriteAllText(files.FilePath, stl);
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