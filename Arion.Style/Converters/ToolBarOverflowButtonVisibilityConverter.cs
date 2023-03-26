using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Arion.Theme.Converters
{
    public class ToolBarOverflowButtonVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var overflowMode = (OverflowMode)values[0];
            var hasOverflowItems = (bool)values[1];

            if (overflowMode == OverflowMode.AsNeeded && hasOverflowItems)
            {
                return Visibility.Visible;
            }

            switch (overflowMode)
            {
                case OverflowMode.Always:
                {
                    return Visibility.Visible;
                }
                case OverflowMode.Never:
                {
                    return Visibility.Hidden;
                }
                default:
                {
                    return Visibility.Hidden;
                }
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
