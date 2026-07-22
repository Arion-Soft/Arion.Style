using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Arion.Style.Converters
{
    /// <summary>
    /// A value converter that multiplies or divides a double value by a specified percentage or multiplier.
    /// Useful for calculating relative sizes, positions, or values in XAML bindings.
    /// </summary>
    public class PercentageConverter : IValueConverter
    {
        /// <summary>
        /// Gets or sets the default multiplier to apply to the value. 
        /// For example, 0.5 represents 50%, and 0.25 represents 25%. 
        /// This can be overridden by passing a value via the ConverterParameter.
        /// </summary>
        public double Percentage { get; set; } = 1.0;

        /// <summary>
        /// Multiplies the input value by the specified multiplier.
        /// </summary>
        /// <param name="value">The source value being passed to the target (must be a double).</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use. Can be a string or double representing the multiplier.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>The multiplied value, or <see cref="DependencyProperty.UnsetValue"/> if the conversion fails.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double doubleValue)
            {
                return DependencyProperty.UnsetValue;
            }

            double multiplier = Percentage;

            if (parameter is string strParam
                && double.TryParse(strParam, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedValue))
            {
                multiplier = parsedValue;
            }
            else if (parameter is double doubleParam)
            {
                multiplier = doubleParam;
            }

            return doubleValue * multiplier;
        }

        /// <summary>
        /// Divides the input value by the specified multiplier to reverse the conversion.
        /// </summary>
        /// <param name="value">The target value being passed to the source (must be a double).</param>
        /// <param name="targetType">The type of the binding source property.</param>
        /// <param name="parameter">The converter parameter to use. Can be a string or double representing the multiplier.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>The divided value, or <see cref="DependencyProperty.UnsetValue"/> if the conversion fails or the multiplier is zero.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double doubleValue)
            {
                return DependencyProperty.UnsetValue;
            }

            double multiplier = Percentage;

            if (parameter is string strParam &&
                double.TryParse(strParam, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedValue))
            {
                multiplier = parsedValue;
            }
            else if (parameter is double doubleParam)
            {
                multiplier = doubleParam;
            }

            if (multiplier == 0)
            {
                return DependencyProperty.UnsetValue;
            }

            return doubleValue / multiplier;
        }
    }
}