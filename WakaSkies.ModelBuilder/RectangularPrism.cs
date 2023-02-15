using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// Represents a rectangular prism/one day.
    /// </summary>
    /// <remarks>
    /// A rectangular prism will be added to the 3D model to represent how much a user programmed that day.
    /// </remarks>
    public class RectangularPrism
    {

        /// <summary>
        /// The points of the prism.
        /// </summary>
        /// <remarks>
        /// The points will be ordered like this:
        /// <code>
        ///    E------H.
        ///    |`.    | `.
        ///    |  `F--+---G
        ///    |   |  |   |
        ///    A---+--D.  |
        ///     `. |    `.|
        ///       `B------C
        /// </code>
        /// <para>
        /// Letter A will represent index 0, B represents index 1 etc...
        /// </para>
        /// </remarks>
        public Vector3[] points = new Vector3[8];

        public Vector3 A => points[0];
        public Vector3 B => points[1];
        public Vector3 C => points[2];
        public Vector3 D => points[3];
        public Vector3 E => points[4];
        public Vector3 F => points[5];
        public Vector3 G => points[6];
        public Vector3 H => points[7];

        /// <summary>
        /// The space between vertices.
        /// </summary>
        public const int VERTEX_SPACING = 1;

        /// <summary>
        /// Create a new Rectangular Prism.
        /// </summary>
        /// <param name="height">The height of the prism.</param>
        /// <param name="position">The position of the A point on the rectangle. 
        /// See <see cref="points"/> for info on what Point is the A point.
        /// </param>
        public RectangularPrism(float height, Vector3 position)
        {
            Generate3DShape(height, position);
        }

        /// <summary>
        /// Generate the 3D shape.
        /// </summary>
        /// <param name="height">The height of the prism.</param>
        /// <param name="position">The position of the A point on the rectangle. 
        /// See <see cref="points"/> for info on what Point is the A point.
        /// </param>
        private void Generate3DShape(float height, Vector3 position)
        {
            // 3D printers use Z as up and +Y as forward.
            // Set the A vertex.
            points[0] = position;
            // the B vertex.
            points[1] = AddY(position, VERTEX_SPACING);
            // the C vertex
            points[2] = AddY(position, VERTEX_SPACING);
            points[2] = AddX(points[2], VERTEX_SPACING);
            // the D vertex.
            points[3] = AddX(position, VERTEX_SPACING);
            // the E vertex
            points[4] = AddZ(position, height);
            // the F vertex
            points[5] = AddY(position, VERTEX_SPACING);
            points[5] = AddZ(points[5], height);
            // the G vertex
            points[6] = AddY(position, VERTEX_SPACING);
            points[6] = AddX(points[6], VERTEX_SPACING);
            points[6] = AddZ(points[6], height);
            // the H vertex.
            points[7] = AddX(position, VERTEX_SPACING);
            points[7] = AddZ(points[7], height);
        }

        private static Vector3 AddX(Vector3 vector, float x) => new Vector3(x + vector.X, vector.Y, vector.Z);
        private static Vector3 AddY(Vector3 vector, float y) => new Vector3(vector.X, y + vector.Y, vector.Z);
        private static Vector3 AddZ(Vector3 vector, float z) => new Vector3(vector.X, vector.Y, z + vector.Z);

    }
}
