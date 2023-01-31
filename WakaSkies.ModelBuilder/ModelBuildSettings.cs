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
    public class ModelBuildSettings
    {
        /// <summary>
        /// The response from WakaTime.
        /// </summary>
        public WakaResponse Response { get; set; }

        /// <summary>
        /// Add statistics to side of model.
        /// </summary>
        public bool AddStatistics { get; set; } = true;

        /// <summary>
        /// If the <see cref="RectangularPrism"/> heights should be rounded to the nearest hour.
        /// </summary>
        public bool RoundToNearestHour { get; set; }

        /// <summary>
        /// The minimum amount of hours needed for a <see cref="RectangularPrism"/> to be added to the model.
        /// </summary>
        public int MinumimHours { get; set; }

        /// <summary>
        /// The minimum height for a <see cref="RectangularPrism"/> (other than 0).
        /// </summary>
        public int MinimumBarHeight { get; set; }

        /// <summary>
        /// The maximum height of a <see cref="RectangularPrism"/>.
        /// </summary>
        public int MaximumBarHeight { get; set; } = 8;

        /// <summary>
        /// If a border should be added.
        /// </summary>
        public bool AddBorder { get; set; } = true;
    }
}
