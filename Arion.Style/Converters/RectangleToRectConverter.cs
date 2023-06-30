using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using Arion.Style.Extensions;

namespace Arion.Style.Converters
{
    public class RectangleToRectConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Rectangle rectangle)
            {
                return new RectangleGeometry(new Rect(0, 0, rectangle.Width, rectangle.Height), 6, 6);
            }
            if (value is ToggleButton toggleButton)
            {
                return new RectangleGeometry(new Rect(0, 0, toggleButton.ActualWidth, toggleButton.ActualHeight), 6, 6);
            }
            return new RectangleGeometry(new Rect(0, 0, 0, 0), 6, 6);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}