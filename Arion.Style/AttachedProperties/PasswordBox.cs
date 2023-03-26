using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class PasswordBox
    {
        public static readonly DependencyProperty MonitorPasswordProperty = DependencyProperty.RegisterAttached(
            "MonitorPassword", typeof(bool), typeof(PasswordBox), new PropertyMetadata(false, PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(!(d is System.Windows.Controls.PasswordBox password)) return;
            
            password.PasswordChanged -= PasswordOnPasswordChanged;

            if ((bool)e.NewValue)
            {
                SetHasContent(password);
                SetSecuredPassword(password);
                password.PasswordChanged += PasswordOnPasswordChanged;
            }
        }

        private static void PasswordOnPasswordChanged(object sender, RoutedEventArgs e)
        {
            SetSecuredPassword((System.Windows.Controls.PasswordBox)sender);
            SetHasContent((System.Windows.Controls.PasswordBox)sender);
        }

        public static void SetMonitorPassword(System.Windows.Controls.PasswordBox element, bool value)
        {
            element.SetValue(MonitorPasswordProperty, value);
        }

        public static bool GetMonitorPassword(System.Windows.Controls.PasswordBox element)
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
            element.SetValue(HasContentProperty, element.Password.Length > 0);
        }

        public static bool GetHasContent(System.Windows.Controls.PasswordBox element)
        {
            return (bool)element.GetValue(HasContentProperty);
        }

        public static readonly DependencyProperty CanShowPasswordProperty = DependencyProperty.RegisterAttached(
            "CanShowPassword", typeof(bool), typeof(PasswordBox), new PropertyMetadata(default(bool)));

        public static void SetCanShowPassword(System.Windows.Controls.PasswordBox element, bool value)
        {
            element.SetValue(CanShowPasswordProperty, value);
        }

        public static bool GetCanShowPassword(System.Windows.Controls.PasswordBox element)
        {
            return (bool)element.GetValue(CanShowPasswordProperty);
        }

        public static readonly DependencyProperty SecuredPasswordProperty = DependencyProperty.RegisterAttached(
            "SecuredPassword", typeof(string), typeof(PasswordBox), new PropertyMetadata(default(string)));

        public static void SetSecuredPassword(System.Windows.Controls.PasswordBox element)
        {
            element.SetValue(SecuredPasswordProperty, element.Password);
        }

        public static string GetSecuredPassword(System.Windows.Controls.PasswordBox element)
        {
            return (string)element.GetValue(SecuredPasswordProperty);
        }
    }
}