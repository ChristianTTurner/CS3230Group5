using System;
using System.Globalization;

namespace CS3230_Group5.Model
{
    /// <summary>
    /// A test ordered for a visit, together with its result (if entered).
    /// </summary>
    public class OrderedTest
    {
        public int AppointmentId { get; set; }
        public string TestCode { get; set; } = string.Empty;
        public string TestName { get; set; } = string.Empty;

        public decimal? LowValue { get; set; }
        public decimal? HighValue { get; set; }
        public string? UnitMeasurement { get; set; }

        public DateTime? PerformedDateTime { get; set; }
        public string? Result { get; set; }
        public bool? Abnormal { get; set; }

        /// <summary>
        /// True when the test has a low and/or high value, so normality
        /// is calculated instead of chosen by the nurse.
        /// </summary>
        public bool HasRange => LowValue.HasValue || HighValue.HasValue;

        public bool HasResult => !string.IsNullOrWhiteSpace(Result);

        public string NormalRangeText
        {
            get
            {
                string unit = string.IsNullOrWhiteSpace(UnitMeasurement)
                    ? string.Empty
                    : " " + UnitMeasurement;

                if (LowValue.HasValue && HighValue.HasValue)
                    return $"{LowValue:0.00} to {HighValue:0.00}{unit}";
                if (LowValue.HasValue)
                    return $"At least {LowValue:0.00}{unit}";
                if (HighValue.HasValue)
                    return $"Up to {HighValue:0.00}{unit}";

                return "Nurse decides";
            }
        }

        public string StatusText
        {
            get
            {
                if (!HasResult)
                    return "Pending";

                return Abnormal == true ? "Abnormal" : "Normal";
            }
        }

        /// <summary>
        /// Parses a numeric lab result (digits, optional sign, optional decimal point).
        /// </summary>
        public static bool TryParseNumericResult(string? text, out decimal value)
        {
            return decimal.TryParse(
                text?.Trim(),
                NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out value);
        }

        /// <summary>
        /// The normal range is [low, high], so a value equal to either end is normal.
        /// </summary>
        public static bool IsAbnormal(decimal value, decimal? low, decimal? high)
        {
            return (low.HasValue && value < low.Value)
                || (high.HasValue && value > high.Value);
        }
    }
}
