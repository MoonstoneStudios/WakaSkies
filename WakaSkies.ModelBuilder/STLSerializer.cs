﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// Serialization into the .STL format.
    /// </summary>
    public class STLSerializer
    {
        /// <summary>
        /// Serialize a <see cref="WakaModel"/> into the STL file format.
        /// </summary>
        /// <param name="model">The model to convert.</param>
        /// <returns>A string.</returns>
        public string Serialize(WakaModel model)
        {
            StringBuilder sb = new StringBuilder();
            string solidName = "Generated by WakaSkies 1.0.0";
            string startSolid = $"solid {solidName}";
            string endSolid = $"endsolid {solidName}";
            string facet = "facet normal "; // trailing space intentional
            string endFacet = "endfacet";
            string outerLoop = "outer loop";
            string endLoop = "endloop";
            string vertex = "vertex "; // trailing space intentional

            // start solid ....
            sb.Append(startSolid);
            sb.AppendLine();

            foreach (var face in model.Faces)
            {
                // facet normal x y z
                sb.Append(facet);
                sb.Append(ToSTL(face.Normal));
                sb.AppendLine();

                // outer loop
                sb.Append(outerLoop);
                sb.AppendLine();

                foreach (var point in face.Points)
                {
                    // vertex x y z
                    sb.Append(vertex);
                    sb.Append(ToSTL(point));
                    sb.AppendLine();
                }

                // endloop
                sb.Append(endLoop);
                sb.AppendLine();

                // endfacet
                sb.Append(endFacet);
                sb.AppendLine();
            }

            sb.Append(endSolid);

            return sb.ToString();
        }

        /// <summary>
        /// Serialize as a binary file.
        /// </summary>
        /// <param name="fileDirectory">The directory to the file.</param>
        /// <param name="model">The model to serialize.</param>
        public void SerializeBinary(string fileDirectory, WakaModel model)
        {
            // https://www.fabbers.com/tech/STL_Format
            // https://en.wikipedia.org/wiki/STL_(file_format)
            using var stream = new FileStream(fileDirectory, FileMode.Create);
            using var writer = new BinaryWriter(stream, Encoding.UTF8, false);

            // write the file header.
            var header = 
                Encoding.UTF8.GetBytes("Binary stl file generated by WakaSkies 1.1.0 This header needs to be 80 bytes :)");
            writer.Write(header);

            // write the facet count.
            // each facet is a triangle.
            uint facetCount = (uint)model.Faces.Length;
            writer.Write(facetCount);

            foreach (var face in model.Faces)
            {
                // write normal
                writer.Write(face.Normal.X);
                writer.Write(face.Normal.Y);
                writer.Write(face.Normal.Z);

                // write points
                foreach (var point in face.Points)
                {
                    writer.Write(point.X);
                    writer.Write(point.Y);
                    writer.Write(point.Z);
                }

                // add a 0 to the end. This is required.
                writer.Write((ushort)0);
            }
        }

        /// <summary>
        /// Deserialize an stl file.
        /// </summary>
        /// <param name="stl">The stl file content.</param>
        /// <returns>A new <see cref="WakaModel"/>.</returns>
        public WakaModel Deserialize(string stl)
        {
            List<TriangleFace> faces = new List<TriangleFace>();

            string vertexRegex = @"(?<=vertex ).+";
            string normalRegex = @"(?<=normal ).+";

            Regex vRegex = new Regex(vertexRegex);
            Regex nRegex = new Regex(normalRegex);

            var vertexMatches = vRegex.Matches(stl);
            var normalMatches = nRegex.Matches(stl);

            int vertexI = 0;
            for (int i = 0; i < normalMatches.Count; i++)
            {
                var normal = ToVec(normalMatches[i].Value);

                var vec1 = ToVec(vertexMatches[vertexI++].Value);
                var vec2 = ToVec(vertexMatches[vertexI++].Value);
                var vec3 = ToVec(vertexMatches[vertexI++].Value);

                faces.Add(new TriangleFace(normal, vec1, vec2, vec3));
            }

            WakaModel model = new WakaModel(faces.Count);
            faces.ForEach(f => model.AddTriangle(f));
            return model;
        }

        /// <summary>
        /// Load a binary file.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public WakaModel DeserializeBinary(Stream stream)
        {
            //using var stream = new FileStream(filePath, FileMode.Open);
            using var reader = new BinaryReader(stream, Encoding.UTF8, false);

            // read and skip header
            reader.ReadBytes(80);
            uint triCount = reader.ReadUInt32();

            WakaModel model = new WakaModel((int)triCount);
            for (int i = 0; i < triCount; i++)
            {
                // read the normal
                var normal = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

                // read the points.
                Vector3[] points = new Vector3[3];
                for (int j = 0; j < 3; j++)
                {
                    points[j] = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
                }

                // make the face
                var face = new TriangleFace(normal, points);
                model.AddTriangle(face);

                // read and discard the required 0.
                reader.ReadUInt16();
            }

            return model;
        }

        /// <summary>Convert a <see cref="Vector3"/> to a string.</summary> 
        private string ToSTL(Vector3 vector)
        {
            return $"{vector.X} {vector.Y} {vector.Z}";
        }

        /// <summary>Convert a string to a <see cref="Vector3"/>.</summary> 
        private Vector3 ToVec(string vector)
        {
            // split by space
            string[] numbers = vector.Split(' ');

            return new Vector3(float.Parse(numbers[0]), float.Parse(numbers[1]), float.Parse(numbers[2]));
        }

    }
}
