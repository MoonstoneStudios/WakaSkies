using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WakaSkies.WakaAPI
{

    /// <summary>
    /// Error data about a bad WakaTime call.
    /// </summary>
    public class ErrorData
    {
        /// <summary>
        /// The status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// The reason.
        /// </summary>
        public string Reason { get; set; }

        public ErrorData(HttpStatusCode statusCode, string reason)
        {
            StatusCode = statusCode;
            Reason = reason;
        }
    }
}
