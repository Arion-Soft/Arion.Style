using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Arion.Style.Converters
{
    internal class DoubleToCornerRadiusConverter : IValueConverter
    {
        public static readonly DoubleToCornerRadiusConverter Instance = new DoubleToCornerRadiusConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => new CornerRadius(Math.Max(0, (double)value));

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
