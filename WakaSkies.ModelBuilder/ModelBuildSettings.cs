using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.WakaAPI;

namespace WakaSkies.WakaModelBuilder
{
    /// <summary>
    /// Settings for building the WakaTime model.
    /// </summary>
    public struct ModelBuildSettings
    {
        /// <summary>
        /// The response from WakaTime.
        /// </summary>
        public WakaResponse Response { get; set; } = null;

        /// <summary>
        /// The year.
        /// </summary>
        public string Year { get; set; } = null;

        /// <summary>
        /// The timeout.
        /// </summary>
        public int? Timeout { get; set; } = null;

        /// <summary>
        /// Add statistics to side of model.
        /// </summary>
        public bool AddStatistics { get; set; } = true;

        /// <summary>
        /// If the <see cref="RectangularPrism"/> heights should be rounded to the nearest hour.
        /// </summary>
        public bool RoundToNearestHour { get; set; } = false;

        /// <summary>
        /// The minimum amount of hours needed for a <see cref="RectangularPrism"/> to be added to the model.
        /// </summary>
        public int MinumimHours { get; set; } = 0;

        /// <summary>
        /// The minimum height for a <see cref="RectangularPrism"/> (other than 0).
        /// </summary>
        public int MinimumBarHeight { get; set; } = 0;

        /// <summary>
        /// The maximum height of a <see cref="RectangularPrism"/>.
        /// </summary>
        public int MaximumBarHeight { get; set; } = 8;

        /// <summary>
        /// If a border should be added.
        /// </summary>
        public bool AddBorder { get; set; } = true;

        public ModelBuildSettings()
        {
            
        }

        public static bool operator ==(ModelBuildSettings a, ModelBuildSettings b)
        {
            return a.AddStatistics == b.AddStatistics &&
                a.Year == b.Year &&
                a.Timeout == b.Timeout &&
                a.RoundToNearestHour == b.RoundToNearestHour &&
                a.MinumimHours == b.MinumimHours &&
                a.MinimumBarHeight == b.MinimumBarHeight &&
                a.MaximumBarHeight == b.MaximumBarHeight &&
                a.AddBorder == b.AddBorder;
        }

        public static bool operator !=(ModelBuildSettings a, ModelBuildSettings b)
        {
            return !(a == b);
        }
    }
}
