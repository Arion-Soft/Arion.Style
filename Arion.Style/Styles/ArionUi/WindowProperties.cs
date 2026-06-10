using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Arion.Style;
    public static class WindowProperties
    {
        public static readonly DependencyProperty EnableMaximizeProperty =
            DependencyProperty.RegisterAttached("EnableMaximize", typeof(bool), typeof(WindowProperties), new PropertyMetadata(true));

        public static bool GetEnableMaximize(DependencyObject obj) => (bool)obj.GetValue(EnableMaximizeProperty);
        public static void SetEnableMaximize(DependencyObject obj, bool value) => obj.SetValue(EnableMaximizeProperty, value);

        public static readonly DependencyProperty EnableMinimizeProperty =
            DependencyProperty.RegisterAttached("EnableMinimize", typeof(bool), typeof(WindowProperties), new PropertyMetadata(true));

        public static bool GetEnableMinimize(DependencyObject obj) => (bool)obj.GetValue(EnableMinimizeProperty);
        public static void SetEnableMinimize(DependencyObject obj, bool value) => obj.SetValue(EnableMinimizeProperty, value);

        public static readonly DependencyProperty EnableCloseProperty =
            DependencyProperty.RegisterAttached("EnableClose", typeof(bool), typeof(WindowProperties), new PropertyMetadata(true));

        public static bool GetEnableClose(DependencyObject obj) => (bool)obj.GetValue(EnableCloseProperty);
        public static void SetEnableClose(DependencyObject obj, bool value) => obj.SetValue(EnableCloseProperty, value);

        public static readonly DependencyProperty TitleLabelProperty =
            DependencyProperty.RegisterAttached("TitleLabel", typeof(string), typeof(WindowProperties), new PropertyMetadata("Window Title"));

        public static string GetTitleLabel(DependencyObject obj) => (string)obj.GetValue(TitleLabelProperty);
        public static void SetTitleLabel(DependencyObject obj, string value) => obj.SetValue(TitleLabelProperty, value);

        public static readonly DependencyProperty MinimizeContentProperty =
            DependencyProperty.RegisterAttached("MinimizeContent", typeof(object), typeof(WindowProperties), new PropertyMetadata("─"));

        public static object GetMinimizeContent(DependencyObject obj) => obj.GetValue(MinimizeContentProperty);
        public static void SetMinimizeContent(DependencyObject obj, object value) => obj.SetValue(MinimizeContentProperty, value);

        public static readonly DependencyProperty MaximizeContentProperty =
            DependencyProperty.RegisterAttached("MaximizeContent", typeof(object), typeof(WindowProperties), new PropertyMetadata("□"));

        public static object GetMaximizeContent(DependencyObject obj) => obj.GetValue(MaximizeContentProperty);
        public static void SetMaximizeContent(DependencyObject obj, object value) => obj.SetValue(MaximizeContentProperty, value);

        public static readonly DependencyProperty CloseContentProperty =
            DependencyProperty.RegisterAttached("CloseContent", typeof(object), typeof(WindowProperties), new PropertyMetadata("✕"));

        public static object GetCloseContent(DependencyObject obj) => obj.GetValue(CloseContentProperty);
        public static void SetCloseContent(DependencyObject obj, object value) => obj.SetValue(CloseContentProperty, value);

        public static readonly DependencyProperty MinimizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("MinimizeButtonStyle", typeof(System.Windows.Style), typeof(WindowProperties), new PropertyMetadata(null));

        public static System.Windows.Style GetMinimizeButtonStyle(DependencyObject obj) => (System.Windows.Style)obj.GetValue(MinimizeButtonStyleProperty);
        public static void SetMinimizeButtonStyle(DependencyObject obj, System.Windows.Style value) => obj.SetValue(MinimizeButtonStyleProperty, value);

        public static readonly DependencyProperty MaximizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("MaximizeButtonStyle", typeof(System.Windows.Style), typeof(WindowProperties), new PropertyMetadata(null));

        public static System.Windows.Style GetMaximizeButtonStyle(DependencyObject obj) => (System.Windows.Style)obj.GetValue(MaximizeButtonStyleProperty);
        public static void SetMaximizeButtonStyle(DependencyObject obj, System.Windows.Style value) => obj.SetValue(MaximizeButtonStyleProperty, value);

        public static readonly DependencyProperty CloseButtonStyleProperty =
            DependencyProperty.RegisterAttached("CloseButtonStyle", typeof(System.Windows.Style), typeof(WindowProperties), new PropertyMetadata(null));

        public static System.Windows.Style GetCloseButtonStyle(DependencyObject obj) => (System.Windows.Style)obj.GetValue(CloseButtonStyleProperty);
        public static void SetCloseButtonStyle(DependencyObject obj, System.Windows.Style value) => obj.SetValue(CloseButtonStyleProperty, value);
    }

    // Boolean to Visibility Converter
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
        }
    }

    public static class WindowBehavior
    {
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(WindowBehavior),
                new PropertyMetadata(false, OnIsEnabledChanged));

        public static bool GetIsEnabled(DependencyObject obj) => (bool)obj.GetValue(IsEnabledProperty);
        public static void SetIsEnabled(DependencyObject obj, bool value) => obj.SetValue(IsEnabledProperty, value);

        private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window window && (bool)e.NewValue)
            {
                window.AddHandler(UIElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler((sender, args) =>
                {
                    if (args.GetPosition(window).Y <= 40 && !IsButtonElement(args.OriginalSource as DependencyObject))
                    {
                        if (window.WindowState == WindowState.Maximized)
                        {
                            var cursorPos = window.PointToScreen(args.GetPosition(window));
                            window.WindowState = WindowState.Normal;
                            window.Left = cursorPos.X - window.RestoreBounds.Width * 0.5;
                            window.Top = cursorPos.Y - 10;
                        }
                        window.DragMove();
                    }
                }), true);

                window.AddHandler(UIElement.MouseLeftButtonUpEvent, new MouseButtonEventHandler((sender, args) =>
                {
                    if (args.OriginalSource is Button button)
                    {
                        switch (button.Name)
                        {
                            case "PART_MinimizeButton":
                                window.WindowState = WindowState.Minimized;
                                break;
                            case "PART_MaximizeButton":
                                window.WindowState = window.WindowState == WindowState.Maximized
                                    ? WindowState.Normal
                                    : WindowState.Maximized;
                                break;
                            case "PART_CloseButton":
                                window.Close();
                                break;
                        }
                    }
                }), true);
            }
        }

        private static bool IsButtonElement(DependencyObject element)
        {
            while (element != null)
            {
                if (element is Button)
                    return true;
                element = VisualTreeHelper.GetParent(element);
            }
            return false;
        }
    }
