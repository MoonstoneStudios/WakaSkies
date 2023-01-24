using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SysVec3 = System.Numerics.Vector3;
using MGVec3 = Microsoft.Xna.Framework.Vector3;

namespace WakaSkies.Desktop
{
    public static class Extensions
    {

        /// <summary>
        /// Convert a <see cref="SysVec3"/> to <see cref="MGVec3"/>.
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static MGVec3 ToMonoGame(this SysVec3 vec)
        {
            return new MGVec3(vec.X, vec.Y, vec.Z);
        }

    }
}
