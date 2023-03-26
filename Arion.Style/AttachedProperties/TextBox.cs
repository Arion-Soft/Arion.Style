using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public static class TextBox
    {
        public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.RegisterAttached(
            "Placeholder", typeof(object), typeof(TextBox), new PropertyMetadata(default(object)));

        public static void SetPlaceholder(System.Windows.Controls.TextBox element, object value)
        {
            element.SetValue(PlaceholderProperty, value);
        }

        public static object GetPlaceholder(System.Windows.Controls.TextBox element)
        {
            return element.GetValue(PlaceholderProperty);
        }
    }
}