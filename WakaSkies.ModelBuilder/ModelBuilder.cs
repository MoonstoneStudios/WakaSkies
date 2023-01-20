using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        /// Build the model.
        /// </summary>
        /// <param name="response">
        /// The <see cref="WakaResponse"/> returned by 
        /// <see cref="WakaTime.GetUserInsights(string, string, string?)"/>.
        /// </param>
        /// <returns>A brand new triangulated <see cref="Model"/>.</returns>
        public Model BuildModel(WakaResponse response)
        {
            if (!response.Successful) return null;

            RectangularPrism[] prisms = new RectangularPrism[response.Data.Days.Length];

            for (int i = 0; i < prisms.Length; i++)
            {
                var day = response.Data.Days[i];
                // temp data, TODO: round total and place in right spot.
                var prism = new RectangularPrism((int)day.Total / 120, new Vector3(i + 5, 0, 0));
                prisms[i] = prism;
            }

            //var prism = new RectangularPrism(5, Vector3.Zero);
            //prisms[0] = prism;

            return Triangulate(prisms);
        }

        /// <summary>
        /// Triangulate the model. TODO: implement this better.
        /// </summary>
        /// <param name="prisms">The prisms to triangulate.</param>
        /// <returns>A triangulated model.</returns>
        private Model Triangulate(RectangularPrism[] prisms)
        {
            // there are 12 triangles in a rectangular prism.
            Model model = new Model(prisms.Length * 12); 
            for (int i = 0; i < prisms.Length; i++)
            {
                var prism = prisms[i];
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

    }
}
