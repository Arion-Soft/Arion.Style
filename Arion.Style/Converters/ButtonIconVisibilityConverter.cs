using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Arion.Style.Controls;

namespace Arion.Style.Converters
{
    public class ButtonIconVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var icon = (EIcons)value;
                return icon == EIcons.NULL ? Visibility.Collapsed : Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}