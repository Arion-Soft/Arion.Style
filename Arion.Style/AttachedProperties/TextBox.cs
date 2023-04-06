using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public static class TextBox
    {
        public static readonly DependencyProperty PrefixProperty = DependencyProperty.RegisterAttached(
            "Prefix", typeof(string), typeof(TextBox), new PropertyMetadata(default(string)));

        public static void SetPrefix(DependencyObject element, string value)
        {
            element.SetValue(PrefixProperty, value);
        }

        public static string GetPrefix(DependencyObject element)
        {
            return (string)element.GetValue(PrefixProperty);
        }

        public static readonly DependencyProperty SuffixProperty = DependencyProperty.RegisterAttached(
            "Suffix", typeof(string), typeof(TextBox), new PropertyMetadata(default(string)));

        public static void SetSuffix(DependencyObject element, string value)
        {
            element.SetValue(SuffixProperty, value);
        }

        public static string GetSuffix(DependencyObject element)
        {
            return (string)element.GetValue(SuffixProperty);
        }

        public static readonly DependencyProperty ClearButtonProperty = DependencyProperty.RegisterAttached(
            "ClearButton", typeof(bool), typeof(TextBox), new PropertyMetadata(default(bool)));

        public static void SetClearButton(DependencyObject element, bool value)
        {
            element.SetValue(ClearButtonProperty, value);
        }

        public static bool GetClearButton(DependencyObject element)
        {
            return (bool)element.GetValue(ClearButtonProperty);
        }
    }
}