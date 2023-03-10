using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.WakaAPI;

namespace WakaSkies.WakaModelBuilder
{
    internal class StatisticModelBuilder
    {

        /// <summary>
        /// Add numbers and other stats to the model.
        /// </summary>
        /// <param name="model">The model with the base attached.</param>
        /// <param name="response">The waka response.</param>
        /// <param name="year">The year string.</param>
        /// <returns>A model with the stats attached.</returns>
        public WakaModel AddStats(WakaModel model, WakaResponse response, string year)
        {
            Log.Information($"StatisticModelBuilder - Adding stats to model!");
            string yearFile = $"{year} text";
            string hoursFile = "hours text";
            // get the total hours.
            int totalHours = TotalHours(response);

            var wakaLogo = WakaModel.LoadFromFile("wakalogo");
            var x = wakaLogo.Width;

            // add a space
            x += 1;

            // find the year model.
            var yearModel = WakaModel.LoadFromFile(yearFile);
            yearModel.ShiftModel(new Vector3(x, 0, 0));
            x += yearModel.Width;

            // add a space.
            x += 1;

            // a list of generated models.
            List<WakaModel> generatedModels = new List<WakaModel>
            {
                wakaLogo,
                yearModel
            };

            Log.Information($"StatisticModelBuilder - Loading each year digit.");
            // get each digit.
            char[] digits = totalHours.ToString().ToCharArray();
            foreach (var digit in digits)
            {
                // find the number file.
                string fileName = $"{digit} text";
                var digitModel = WakaModel.LoadFromFile(fileName);

                // shift it into the right place.
                digitModel.ShiftModel(new Vector3(x, 0, 0));
                x += digitModel.Width;

                generatedModels.Add(digitModel);
            }

            // add a space.
            x += 1;

            // find the hours model.
            var hoursModel = WakaModel.LoadFromFile(hoursFile);
            hoursModel.ShiftModel(new Vector3(x, 0, 0));
            generatedModels.Add(hoursModel);

            Log.Information($"StatisticModelBuilder - Combining all models.");
            // combine the models.
            WakaModel final = model;
            foreach (var m in generatedModels)
            {
                final = WakaModel.CombineModels(final, m);
            }

            Log.Information($"StatisticModelBuilder - Done adding statistics to model!");
            return final;
        }

        /// <summary>
        /// Get the total hours programmed in a year.
        /// </summary>
        /// <param name="response">The waka response.</param>
        /// <returns></returns>
        private int TotalHours(WakaResponse response)
        {
            double count = 0;
            for (int i = 0; i < response.Data.Days.Length; i++)
            {
                var day = response.Data.Days[i];
                count += day.Total;
            }

            // count is in seconds, divide to find hours.
            count /= 3600f;

            // round, then cast.
            return (int)Math.Round(count);
        }

    }
}
