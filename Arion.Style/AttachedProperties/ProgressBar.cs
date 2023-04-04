using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class ProgressBar
    {
        public static readonly DependencyProperty ShowProgressProperty = DependencyProperty.RegisterAttached(
            "ShowProgress", typeof(bool), typeof(ProgressBar), new PropertyMetadata(default(bool)));

        public static void SetShowProgress(DependencyObject element, bool value)
        {
            element.SetValue(ShowProgressProperty, value);
        }

        public static bool GetShowProgress(DependencyObject element)
        {
            return (bool)element.GetValue(ShowProgressProperty);
        }
    }
}