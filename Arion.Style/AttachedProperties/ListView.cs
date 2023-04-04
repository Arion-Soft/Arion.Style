using System.Windows;
using System.Windows.Media;

namespace Arion.Style.AttachedProperties
{
    public class ListView
    {
        public static readonly DependencyProperty SelectColorProperty = DependencyProperty.RegisterAttached(
            "SelectColor", typeof(Color), typeof(ListView), new PropertyMetadata(default(Color)));

        public static void SetSelectColor(DependencyObject element, Color value)
        {
            element.SetValue(SelectColorProperty, value);
        }

        public static Color GetSelectColor(DependencyObject element)
        {
            return (Color)element.GetValue(SelectColorProperty);
        }
    }
}