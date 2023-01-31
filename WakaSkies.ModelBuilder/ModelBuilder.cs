using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.WakaAPI;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// The Model Builder will generate a 3d model to be drawn and converted into STL.
    /// </summary>
    public class ModelBuilder
    {
        /// <summary>
        /// How much to add to the position of the model.
        /// </summary>
        /// <remarks>
        /// The base that will be added is exactly this tall. By moving up the generated model,
        /// the rectangular prisms will be in the correct positions.
        /// </remarks>
        private const float BOTTOM_OF_MODEL = 3.01121f;

        /// <summary>
        /// Build the model.
        /// </summary>
        /// <param name="settings">The build settings.</param>
        /// <returns>A brand new triangulated <see cref="WakaModel"/>.</returns>
        public WakaModel BuildModel(ModelBuildSettings settings)
        {
            var response = settings.Response;
            var addText = settings.AddStatistics;

            if (!response.Successful) return null;

            List<RectangularPrism> prisms = new List<RectangularPrism>();

            // the first day to start on
            int firstDay;
            // the current week.
            int currentWeek = 0;
            // the current day 0-6.
            int currentDay;

            var yearData = response.Data.Days[0].Date;
            firstDay = (int)yearData.DayOfWeek;
            currentDay = firstDay;
            for (int i = 0; i < response.Data.Days.Length; i++)
            {
                var day = response.Data.Days[i];

                // subtract so that is in the right position.
                // for now, the base is positioned in the -Ys.
                var position = new Vector3(currentWeek, -currentDay - 1, BOTTOM_OF_MODEL);
                // divide by 3600 to find hours.
                var hours = day.Total / 3600f;

                // round first.
                if (settings.RoundToNearestHour)
                {
                    hours = Math.Round(hours);
                }

                // add prism if it is above 0 and the minimum.
                if (hours >= settings.MinumimHours && hours > 0)
                {
                    // get the clamped height.
                    var height = MathF.Max(settings.MinimumBarHeight, (float)hours);
                    height = MathF.Min(settings.MaximumBarHeight, height);

                    var prism = new RectangularPrism(height, position);
                    prisms.Add(prism);
                }

                // increment.
                currentDay++;
                if (currentDay >= 7)
                {
                    currentDay = 0;
                    currentWeek++;
                }
            }

            var model = Triangulate(prisms);
            var modelWithBase = AppendBase(model);

            if (settings.AddBorder)
            {
                var border = WakaModel.LoadFromFile("modelborder");
                modelWithBase = WakaModel.CombineModels(modelWithBase, border);
            }

            if (addText)
            {
                var numberBuilder = new StaticticModelBuilder();
                return numberBuilder.AddStats(modelWithBase, response, response.Data.Days[0].Date.Year.ToString());
            }
            else
            {
                return modelWithBase;
            }
        }

        /// <summary>
        /// Triangulate the model. TODO: implement this better.
        /// </summary>
        /// <param name="prisms">The prisms to triangulate.</param>
        /// <returns>A triangulated model.</returns>
        private WakaModel Triangulate(List<RectangularPrism> prisms)
        {
            // there are 12 triangles in a rectangular prism.
            WakaModel model = new WakaModel(prisms.Count * 12); 
            for (int i = 0; i < prisms.Count; i++)
            {
                var prism = prisms[i];
                // no data
                if (prism == null) continue;
                // Bottom Square:
                // A---D
                // | \ |
                // B---C
                // generate 2 triangles ABC and CDA.

                // generate bottom triangles from quad ABCD
                var bottomTri1 = new TriangleFace(-Vector3.UnitY,
                                                  // A B C
                                                  prism.A, prism.B, prism.C);
                var bottomTri2 = new TriangleFace(-Vector3.UnitY,
                                  // C D A
                                  prism.C, prism.D, prism.A);

                // Top Square:
                // E---H
                // | \ |
                // F---G
                // generate 2 triangles EFG and GHE.
                var topTri1 = new TriangleFace(Vector3.UnitY,
                                  // E F G
                                  prism.E, prism.F, prism.G);
                var topTri2 = new TriangleFace(Vector3.UnitY,
                                  // G H E
                                  prism.G, prism.H, prism.E);

                // Front Square:
                // F---G
                // | \ |
                // B---C
                // generate 2 triangles FBC and CGF.
                var frontTri1 = new TriangleFace(Vector3.UnitZ,
                                  // F B C
                                  prism.F, prism.B, prism.C);
                var frontTri2 = new TriangleFace(Vector3.UnitZ,
                                  // C G F
                                  prism.C, prism.G, prism.F);

                // Left Square:
                // E---F
                // | \ |
                // A---B
                // generate 2 triangles EAB and BFE.
                var leftTri1 = new TriangleFace(-Vector3.UnitX,
                                  prism.E, prism.A, prism.B);
                var leftTri2 = new TriangleFace(-Vector3.UnitX,
                                  prism.B, prism.F, prism.E);

                // Right Square:
                // H---G
                // | \ |
                // D---C
                // generate 2 triangles HDC and CGH.
                var rightTri1 = new TriangleFace(Vector3.UnitX,
                                  prism.H, prism.D, prism.C);
                var rightTri2 = new TriangleFace(Vector3.UnitX,
                                  prism.C, prism.G, prism.H);

                // Back Square:
                // E---H
                // | \ |
                // A---D
                // generate 2 triangles EAD and DHE.
                var backTri1 = new TriangleFace(-Vector3.UnitZ,
                                  prism.E, prism.A, prism.D);
                var backTri2 = new TriangleFace(-Vector3.UnitZ,
                                  prism.D, prism.H, prism.E);

                model.AddTriangle(bottomTri1);
                model.AddTriangle(bottomTri2);
                model.AddTriangle(topTri1);
                model.AddTriangle(topTri2);
                model.AddTriangle(frontTri1);
                model.AddTriangle(frontTri2);
                model.AddTriangle(leftTri1);
                model.AddTriangle(leftTri2);
                model.AddTriangle(rightTri1);
                model.AddTriangle(rightTri2);
                model.AddTriangle(backTri1);
                model.AddTriangle(backTri2);
            }

            return model;
        }

        /// <summary>
        /// Add the base to the model.
        /// </summary>
        /// <remarks>
        /// The base is an STL file that is stored as an embedded resource. 
        /// </remarks>
        /// <param name="prismModel">The prisms.</param>
        /// <returns>The final model with the base attached.</returns>
        private WakaModel AppendBase(WakaModel prismModel)
        {
            var baseModel = WakaModel.LoadFromFile("base");

            return WakaModel.CombineModels(prismModel, baseModel);
        }

    }
}
