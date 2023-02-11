using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.Desktop.UI;
using WakaSkies.WakaAPI;
using WakaSkies.WakaModelBuilder;

using MDesktop = Myra.Graphics2D.UI.Desktop;

namespace WakaSkies.Desktop
{
    /// <summary>
    /// The logic for the model and rendering.
    /// </summary>
    public class ModelManager
    {
        private ModelBuilder modelBuilder;
        public WakaModel model;

        private VertexPositionColorNormal[] verts;
        private BasicEffect effect;

        private RasterizerState rasterizer = new RasterizerState()
        {
            CullMode = CullMode.None
        };

        // store last used values to prevent regenerating when it is not needed.
        private string prevUserName;
        private string prevYear;
        private bool prevStats;

        public ModelBuildSettings buildSettings;
        private ModelBuildSettings lastSettings;

        public void LoadContent(GraphicsDevice device)
        {
            // setup the effect.
            effect = new BasicEffect(device);
            effect.VertexColorEnabled = true;
            effect.EnableDefaultLighting();
            effect.Alpha = 0.5f;
            effect.DiffuseColor = Color.LightGray.ToVector3();
            device.RasterizerState = rasterizer;

            modelBuilder = new ModelBuilder();
            buildSettings = new ModelBuildSettings();
        }

        public void Draw(GraphicsDevice graphicsDevice, Camera camera)
        {
            if (effect != null && verts != null)
            {
                effect.World = camera.world;
                effect.Projection = camera.projection;
                effect.View = camera.view;
                foreach (var pass in effect.CurrentTechnique.Passes)
                {
                    // https://github.com/simondarksidej/XNAGameStudio/wiki/RiemersArchiveOverview
                    pass.Apply();
                    graphicsDevice.DrawUserPrimitives(PrimitiveType.TriangleList, verts, 0, verts.Length / 3);
                }
            }
        }

        public async Task<bool> GenerateModel(MDesktop ui, Camera camera)
        {
            // get the start UI.
            var start = (StartMenu)ui.Root;
            if (string.IsNullOrWhiteSpace(start.wakaKeyInput.Text)
                || string.IsNullOrWhiteSpace(start.wakaUserInput.Text))
            {
                start.errorText.Text = "Error: some required information is missing.";
                start.errorText.Visible = true;
                return false;
            }

            buildSettings.Year = start.wakaYearCombo.SelectedItem.Text;

            // dont regenerate if same info is entered.
            if (buildSettings == lastSettings)
            {
                start.Visible = false;
                camera.StartRotation();
                return true;
            }

            start.generateButton.Text = "Generating...";

            // get the data.
            var wakaClient = new WakaClient(start.wakaKeyInput.Text);
            var insights = await wakaClient.GetUserInsights(start.wakaUserInput.Text, 
                start.wakaYearCombo.SelectedItem.Text, buildSettings.Timeout);


            // check for success.
            if (!insights.Successful)
            {
                start.errorText.Text = $"Error: {insights.ErrorData.Reason}";
                start.errorText.Visible = true;
                start.generateButton.Text = "Generate Model!";
                return false;
            }

            try
            {
                // build the model.
                buildSettings.Response = insights;
                //buildSettings.AddStatistics = start.generateStats.IsChecked;

                model = modelBuilder.BuildModel(buildSettings);
            }
            catch (Exception ex)
            {
                start.errorText.Text = $"Error: {ex.Message}";
                start.generateButton.Text = "Generate Model!";
                start.errorText.Visible = true;
                return false;
            }

            // turn model into something MonoGame can understand.
            verts = new VertexPositionColorNormal[model.Vertices.Length];
            var faceCount = 0;
            var faceCounter = 0;
            for (int i = 0; i < verts.Length; i++)
            {
                // for each vertex, transform it's normal
                // so that it is pointing the right direction.
                verts[i] = new VertexPositionColorNormal(
                    model.Vertices[i].ToMonoGame(), Color.White,
                    Vector3.TransformNormal(model.Faces[faceCount].Normal, camera.world));

                // keep track of face count.
                faceCounter++;
                if (faceCounter >= 3)
                {
                    faceCount++;
                    faceCounter = 0;
                }
            }

            lastSettings = buildSettings;

            start.generateButton.Text = "Generate Model!";
            start.errorText.Text = "";
            start.errorText.Visible = false;

            camera.StartRotation();
            camera.UpdateWorld(model.Width);
            return true;
        }
    }
}
