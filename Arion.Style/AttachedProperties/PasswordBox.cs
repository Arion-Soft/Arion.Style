using System.Windows;
using Arion.Style.Controls;

namespace Arion.Style.AttachedProperties
{
    public class PasswordBox
    {
        #region MonitorPassword

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

        #endregion

        #region HasContent

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

        #endregion

        #region CanShowPassword

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

        #endregion

        #region IsShowPassword

        public static readonly DependencyProperty IsShowPasswordProperty = DependencyProperty.RegisterAttached(
            "IsShowPassword", typeof(bool), typeof(PasswordBox), new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetIsShowPassword(DependencyObject element, bool value)
        {
            element.SetValue(IsShowPasswordProperty, value);
        }

        public static bool GetIsShowPassword(DependencyObject element)
        {
            return (bool)element.GetValue(IsShowPasswordProperty);
        }

        #endregion

        #region SecuredPassword

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

        #endregion

        #region CanClear

        public static readonly DependencyProperty CanClearProperty = DependencyProperty.RegisterAttached(
            "CanClear", typeof(bool), typeof(PasswordBox), new PropertyMetadata(default(bool)));

        public static void SetCanClear(DependencyObject element, bool value)
        {
            element.SetValue(CanClearProperty, value);
        }

        public static bool GetCanClear(DependencyObject element)
        {
            return (bool)element.GetValue(CanClearProperty);
        }

        #endregion
        
        #region Left Icon

        public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
            "LeftIcon", typeof(EIcons), typeof(PasswordBox), new PropertyMetadata(default(EIcons)));

        public static void SetLeftIcon(DependencyObject element, EIcons value)
        {
            element.SetValue(LeftIconProperty, value);
        }

        public static EIcons GetLeftIcon(DependencyObject element)
        {
            return (EIcons)element.GetValue(LeftIconProperty);
        }

        #endregion

        #region Right Icon

        public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
            "RightIcon", typeof(EIcons), typeof(PasswordBox), new PropertyMetadata(default(EIcons)));

        public static void SetRightIcon(DependencyObject element, EIcons value)
        {
            element.SetValue(RightIconProperty, value);
        }

        public static EIcons GetRightIcon(DependencyObject element)
        {
            return (EIcons)element.GetValue(RightIconProperty);
        }

        #endregion

        #region Size Icon

        #region Width

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.RegisterAttached(
            "IconWidth", typeof(double), typeof(PasswordBox), new PropertyMetadata(default(double)));

        public static void SetIconWidth(DependencyObject element, double value)
        {
            element.SetValue(IconWidthProperty, value);
        }

        public static double GetIconWidth(DependencyObject element)
        {
            return (double)element.GetValue(IconWidthProperty);
        }

        #endregion

        #region Height

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.RegisterAttached(
            "IconHeight", typeof(double), typeof(PasswordBox), new PropertyMetadata(default(double)));

        public static void SetIconHeight(DependencyObject element, double value)
        {
            element.SetValue(IconHeightProperty, value);
        }

        public static double GetIconHeight(DependencyObject element)
        {
            return (double)element.GetValue(IconHeightProperty);
        }

        #endregion

        #endregion
    }
}