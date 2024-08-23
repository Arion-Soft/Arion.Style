using System;
using System.Windows;
using System.Windows.Data;

namespace Arion.Style.Converters;

public class DoubleGridLengthConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return new GridLength((double)value);
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        GridLength gridLength = (GridLength)value;
        return gridLength.Value;
    }
}