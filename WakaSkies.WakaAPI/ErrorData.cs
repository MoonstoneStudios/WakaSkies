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
        /// The reason.
        /// </summary>
        public string Reason { get; set; }

        public ErrorData(string reason)
        {
            Reason = reason;
        }
    }
}
