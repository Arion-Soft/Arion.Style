using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Arion.Theme.Converters
{
    internal class RemoveAlphaBrushConverter : IValueConverter, IMultiValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value is SolidColorBrush brush
                ? new SolidColorBrush(RgbaToRgb(brush.Color, parameter))
                : Binding.DoNothing;

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
            => values[0] is SolidColorBrush brush
                ? new SolidColorBrush(RgbaToRgb(brush.Color, values[1]))
                : Binding.DoNothing;

        private static Color RgbaToRgb(Color rgba, object background)
        {
            Color backgroundColor;
            switch (background)
            {
                case Color c:
                {
                    backgroundColor = c;
                    break;
                }
                case SolidColorBrush b:
                {
                    backgroundColor = b.Color;
                    break;
                }
                default:
                {
                    backgroundColor = Colors.White;
                    break;
                }
            }

            var alpha = (double)rgba.A / byte.MaxValue;
            var alphaReverse = 1 - alpha;

            return Color.FromRgb(
                (byte)(alpha * rgba.R + alphaReverse * backgroundColor.R),
                (byte)(alpha * rgba.G + alphaReverse * backgroundColor.G),
                (byte)(alpha * rgba.B + alphaReverse * backgroundColor.B)
            );
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
