using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using Arion.Style.Theme.Extensions;
using HintProxyFabric = Arion.Style.Theme.Extensions.HintProxyFabric;

namespace Arion.Style.Converters
{
    /// <summary>
    /// Converter for <see cref="SmartHint"/> control. Can be extended by <see cref="Style.Theme.Extensions.HintProxyFabric.RegisterBuilder(Func{TResult}, Func{Control, IHintProxy})"/> method.
    /// </summary>
    public class HintProxyFabricConverter : IValueConverter
    {
        private static readonly Lazy<HintProxyFabricConverter> _instance = new Lazy<HintProxyFabricConverter>();

        public static HintProxyFabricConverter Instance => _instance.Value;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => HintProxyFabric.Get(value as Control);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => Binding.DoNothing;
    }
}