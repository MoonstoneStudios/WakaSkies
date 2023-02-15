using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// Represents a face that is in the shape of a triangle.
    /// </summary>
    public struct TriangleFace
    {

        /// <summary>
        /// The points of the face.
        /// </summary>
        public Vector3[] Points { get; } = new Vector3[3];

        /// <summary>
        /// The normal of the face.
        /// </summary>
        public Vector3 Normal { get; set; } = Vector3.Zero;

        public TriangleFace(Vector3 normal, params Vector3[] points)
        {
            Normal = normal;
            Points = points;
        }

    }
}
