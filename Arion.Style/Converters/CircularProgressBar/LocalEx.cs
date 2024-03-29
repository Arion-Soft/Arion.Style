﻿using System.Collections.Generic;
using System.Linq;

namespace Arion.Style.Converters.CircularProgressBar
{
    internal static class LocalEx
    {
        public static double ExtractDouble(this object value)
        {
            var d = value as double? ?? double.NaN;
            return double.IsInfinity(d) ? double.NaN : d;
        }


        public static bool AnyNan(this IEnumerable<double> values)
        {
            return values.Any(double.IsNaN);
        }
    }
}
