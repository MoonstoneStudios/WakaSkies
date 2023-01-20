using Newtonsoft.Json;

namespace WakaSkies.WakaAPI
{
    /// <summary>
    /// The WakaTime class handles API calls to WakaTime.
    /// </summary>
    /// <remarks>
    /// When the class is created you must pass an API key into the constructor. The base64 encoding will be done here.
    /// <para>
    /// This class will get the data of a user from the WakaTime API using their Insights endpoint.
    /// </para>
    /// </remarks>
    public class WakaTime
    {
        /// <summary>
        /// The base address for WakaTime.
        /// </summary>
        public const string WAKA_BASE_ADDRESS = "https://wakatime.com/api/v1/users/";

        /// <summary>
        /// The <see cref="HttpClient"/> that will be used to make HTTPS requests.
        /// </summary>
        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(WAKA_BASE_ADDRESS)
        };

        /// <summary>
        /// Create a new WakaTime class.
        /// </summary>
        /// <param name="apiKey">The user's API key. This should be in plain text.</param>
        public WakaTime(string apiKey)
        {
            // https://stackoverflow.com/a/11743162
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(apiKey);
            var key = Convert.ToBase64String(plainTextBytes);

            // add the authorization header
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {key}");
        }

        /// <summary>
        /// Get the insights.
        /// </summary>
        /// <param name="userName">The username of the User we are retrieving data from.</param>
        /// <param name="year">The year to grab in YYYY format.</param>
        /// <param name="timeout">The optional keystroke timeout to get.</param>
        /// <returns>A new <see cref="WakaResponse"/>.</returns>
        public async Task<WakaResponse> GetUserInsights(string userName, string year, string? timeout = null)
        {
            // check year.
            if (year.Length != 4 || !int.TryParse(year, out int _))
            {
                // year not valid.
                return new WakaResponse()
                {
                    Successful = false,
                    ErrorData = new ErrorData(System.Net.HttpStatusCode.BadRequest, "Year is not in YYYY format.")
                };
            }

            // set url
            string url = $"{userName}/insights/days/{year}";
            if (timeout != null) url += $"?timeout={timeout}";

            // get the response.
            var response = await client.GetAsync(url);
            
            // check if failed.
            if (!response.IsSuccessStatusCode)
            {
                // return an unsuccessful object.
                return new WakaResponse()
                {
                    Successful = false,
                    ErrorData = new ErrorData(response.StatusCode, response.ReasonPhrase)
                };
            }

            // successful response, decode data and return
            var content = await response.Content.ReadAsStringAsync();
            var wakaResponse = JsonConvert.DeserializeObject<WakaResponse>(content);
            wakaResponse.Content = content;
            return wakaResponse;
        }
    }
}