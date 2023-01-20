using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// A 3D model.
    /// </summary>
    public class Model
    {

        /// <summary>
        /// The faces.
        /// </summary>
        public TriangleFace[] Faces { get; set; }

        /// <summary>
        /// The list of vertices.
        /// </summary>
        public Vector3[] Vertices { get; set; }

        private int faceCount = 0;
        private int vertexCount = 0;

        public Model(int triangleCount)
        {
            Faces = new TriangleFace[triangleCount];
            // 3 vertices per triangle
            Vertices = new Vector3[triangleCount * 3];
        }

        /// <summary>
        /// Add a <see cref="TriangleFace"/> to the model.
        /// </summary>
        /// <param name="face">The face to add.</param>
        public void AddTriangle(TriangleFace face)
        {
            Faces[faceCount++] = face;
            foreach (var point in face.Points)
            {
                Vertices[vertexCount++] = point;
            }
        }

    }
}
