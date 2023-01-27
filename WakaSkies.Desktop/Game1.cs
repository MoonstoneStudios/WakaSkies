﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Myra;
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

        private WakaClient wakaTime;
        private ModelBuilder modelBuilder;
        private WakaModel model;

        private VertexPositionColorNormal[] verts;
        private BasicEffect effect;

        // http://rbwhitaker.wikidot.com/monogame-using-3d-models
        private Matrix world = Matrix.CreateRotationX(MathHelper.ToRadians(-90)) *
            Matrix.CreateTranslation(new Vector3(-15, -5, 0));
        private Matrix view = Matrix.CreateLookAt(new Vector3(0, 10, 30), new Vector3(0, 0, 0), Vector3.UnitY);
        private Matrix projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), 1280f / 720f, 0.1f, 1000f);

        private Vector3 pos = new Vector3(0, 10, 30);

        private Skybox skybox;

        MDesktop ui;

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

            base.Initialize();
        }

        protected override async void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            skybox = new Skybox("cubemap", Content);

            MyraEnvironment.Game = this;
            ui = new MDesktop();

            var startMenu = new StartMenu();
            startMenu.generateButton.Click += GenerateModel;
            ui.Root = startMenu;


            effect = new BasicEffect(GraphicsDevice);
            effect.VertexColorEnabled = true;
            effect.EnableDefaultLighting();
            effect.Alpha = 0.5f;
            effect.DiffuseColor = Color.LightGray.ToVector3();
            GraphicsDevice.RasterizerState = rasterizer;
        }

        private async void GenerateModel(object sender, System.EventArgs e)
        {
            var start = (StartMenu)ui.Root;
            wakaTime = new WakaClient(start.wakaKeyInput.Text);
            var insights = await wakaTime.GetUserInsights(start.wakaUserInput.Text, start.wakaYearCombo.SelectedItem.Text);
            ModelBuilder builder = new ModelBuilder();
            model = builder.BuildModel(insights);

            verts = new VertexPositionColorNormal[model.Vertices.Length];
            var faceCount = 0;
            var faceCounter = 0;
            for (int i = 0; i < verts.Length; i++)
            {
                verts[i] = new VertexPositionColorNormal(
                    model.Vertices[i].ToMonoGame(), Color.White, Vector3.TransformNormal(model.Faces[faceCount].Normal, world));
                faceCounter++;
                if (faceCounter >= 3)
                {
                    faceCount++;
                    faceCounter = 0;
                }
            }

            start.Visible = false;
        }

        protected override async void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (verts != null)
            {
                var k = Keyboard.GetState();
                if (k.IsKeyDown(Keys.A)) pos.X -= 0.1f;
                if (k.IsKeyDown(Keys.D)) pos.X += 0.1f;
                if (k.IsKeyDown(Keys.W)) pos.Y -= 0.1f;
                if (k.IsKeyDown(Keys.S)) pos.Y += 0.1f;
            }

            view = Matrix.CreateLookAt(new Vector3(pos.X, pos.Y, 30), new Vector3(0, 0, 0), Vector3.UnitY);

            base.Update(gameTime);
        }

        protected override async void Draw(GameTime gameTime)
        {
            // reset the Graphics Device.
            // the SpriteBatch messes with it.
            GraphicsDevice.BlendState = BlendState.Opaque;
            GraphicsDevice.DepthStencilState = DepthStencilState.Default;
            GraphicsDevice.RasterizerState = rasterizer;

            GraphicsDevice.Clear(Color.DarkSlateBlue);

            skybox.Draw(view, projection, pos);

            if (effect != null && verts != null)
            {
                effect.World = world;
                effect.Projection = projection;
                effect.View = view;
                foreach (var pass in effect.CurrentTechnique.Passes)
                {
                    // https://github.com/simondarksidej/XNAGameStudio/wiki/RiemersArchiveOverview
                    pass.Apply();
                    GraphicsDevice.DrawUserPrimitives(PrimitiveType.TriangleList, verts, 0, verts.Length / 3);
                }
            }


            ui.Render();

            base.Draw(gameTime);
        }

    }
}