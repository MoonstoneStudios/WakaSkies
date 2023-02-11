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

namespace WakaSkies.Desktop
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Camera camera;
        public Skybox skybox;
        public ModelManager modelManager;

        public int selectedSkybox;
        public bool backgroundSettingsOpen;
        public Dictionary<string, TextureCube> skyboxTextures = new Dictionary<string, TextureCube>();

        private UIManager uiManager = new UIManager();

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
            uiManager.SetupStartUI(this, Content);

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
            uiManager.Render();

            base.Draw(gameTime);
        }

    }
}