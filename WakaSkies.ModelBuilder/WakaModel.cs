using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// A 3D model.
    /// </summary>
    public class WakaModel
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

        private float minX;
        private float maxX;

        /// <summary>
        /// The width of the model.
        /// </summary>
        public float Width
        {
            get => maxX - minX;
        }

        public WakaModel(int triangleCount)
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
                if (point.X < minX) minX = point.X;
                if (point.X > maxX) maxX = point.X;
                Vertices[vertexCount++] = point;
            }
        }

        public void ShiftModel(Vector3 amount)
        {
            for (int i = 0; i < Vertices.Length; i++)
            {
                Vertices[i] += amount;
            }
            for (int i = 0; i < Faces.Length; i++)
            {
                Faces[i].Points[0] += amount;
                Faces[i].Points[1] += amount;
                Faces[i].Points[2] += amount;
            }
        }

        /// <summary>
        /// Combine two models.
        /// </summary>
        /// <param name="a">A model to combine.</param>
        /// <param name="b">A model to combine.</param>
        /// <returns>A new Model that contains both model's faces.</returns>
        public static WakaModel CombineModels(WakaModel a, WakaModel b)
        {
            // get total triangle count.
            WakaModel newModel = new WakaModel(a.Faces.Length + b.Faces.Length);

            for (int i = 0; i < a.Faces.Length; i++)
            {
                newModel.AddTriangle(a.Faces[i]);
            }
            for (int i = 0; i < b.Faces.Length; i++)
            {
                newModel.AddTriangle(b.Faces[i]);
            }
            return newModel;
        }

        /// <summary>
        /// Load a model from a file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static WakaModel LoadFromFile(string fileName)
        {
            Log.Information($"WakaModel - Loading model {fileName} from a file.");
            // https://stackoverflow.com/a/3314213
            var assem = Assembly.GetExecutingAssembly();
            WakaModel file;

            using (var stream = assem.GetManifestResourceStream($"WakaSkies.WakaModelBuilder.Resources.{fileName}.stl"))
            {
                var serializer = new STLSerializer();
                Log.Information($"WakaModel - Deserializing {fileName}...");
                return serializer.DeserializeBinary(stream);
            }

        }

    }
}
