using System.Windows;

namespace Arion.Style.Theme.AttachedProperties
{
    public class PasswordBox
    {
        public static readonly DependencyProperty MonitorPasswordProperty = DependencyProperty.RegisterAttached(
            "MonitorPassword", typeof(bool), typeof(PasswordBox), new PropertyMetadata(false, PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var password = d as System.Windows.Controls.PasswordBox;
            
            if(password == null) return;
            
            password.PasswordChanged -= PasswordOnPasswordChanged;

            if ((bool)e.NewValue)
            {
                SetHasContent(password);
                password.PasswordChanged += PasswordOnPasswordChanged;
            }
        }

        private static void PasswordOnPasswordChanged(object sender, RoutedEventArgs e)
        {
            SetHasContent((System.Windows.Controls.PasswordBox)sender);
        }

        public static void SetMonitorPassword(DependencyObject element, bool value)
        {
            element.SetValue(MonitorPasswordProperty, value);
        }

        public static bool GetMonitorPassword(DependencyObject element)
        {
            return (bool)element.GetValue(MonitorPasswordProperty);
        }
        
        public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.RegisterAttached(
            "Placeholder", typeof(object), typeof(PasswordBox), new PropertyMetadata(default(object)));

        public static void SetPlaceholder(System.Windows.Controls.PasswordBox element, object value)
        {
            element.SetValue(PlaceholderProperty, value);
        }

        public static object GetPlaceholder(System.Windows.Controls.PasswordBox element)
        {
            return element.GetValue(PlaceholderProperty);
        }

        public static readonly DependencyProperty HasContentProperty = DependencyProperty.RegisterAttached(
            "HasContent", typeof(bool), typeof(PasswordBox), new PropertyMetadata(default(bool)));

        public static void SetHasContent(System.Windows.Controls.PasswordBox element)
        {
            element.SetValue(HasContentProperty, element.SecurePassword.Length > 0);
        }

        public static bool GetHasContent(System.Windows.Controls.PasswordBox element)
        {
            return (bool)element.GetValue(HasContentProperty);
        }
    }
}