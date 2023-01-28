﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // warning CS1591: Missing XML comment for publicly visible type or member 'member_name'

namespace WakaSkies.WakaAPI
{
    /// <summary>
    /// Represents an API response from WakaTime.
    /// </summary>
    public class WakaResponse
    {
        /// <summary>
        /// The raw JSON response from WakaTime.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// If the response is successful.
        /// </summary>
        public bool Successful { get; set; } = true;

        /// <summary>
        /// Error data if call was not successful.
        /// </summary>
        public ErrorData ErrorData { get; set; }

        /// <summary>
        /// The data.
        /// </summary>
        public Data Data { get; set; }
    }

    public class Data
    {
        // Following was generated by https://quicktype.io/
        public DateTimeOffset? CreatedAt { get; set; }
        public Day[] Days { get; set; }
        public DateTimeOffset? End { get; set; }
        public long HumanReadableRange { get; set; }
        public bool IsAlreadyUpdating { get; set; }
        public bool IsCached { get; set; }
        public bool IsIncludingToday { get; set; }
        public bool IsStuck { get; set; }
        public bool IsUpToDate { get; set; }
        public bool IsUpToDatePendingFuture { get; set; }
        public DateTimeOffset? ModifiedAt { get; set; }
        public long PercentCalculated { get; set; }
        public long Range { get; set; }
        public DateTimeOffset? Start { get; set; }
        public string Status { get; set; }
        public long Timeout { get; set; }
        public string Timezone { get; set; }
        public Guid UserId { get; set; }
        public bool WritesOnly { get; set; }
    }

    /// <summary>
    /// A single day.
    /// </summary>
    // Generated by https://quicktype.io/
    public class Day
    {
        public Category[] Categories { get; set; }
        public DateTimeOffset Date { get; set; }
        public double Total { get; set; }
    }

    /// <summary>
    /// The category.
    /// </summary>
    // Generated by https://quicktype.io/
    public class Category
    {
        public CategoryType Name { get; set; }
        public double Total { get; set; }
    }

    /// <summary>
    /// The type of category.
    /// </summary>
    // Generated by https://quicktype.io/
    public enum CategoryType { Building, Coding, Debugging };
}
