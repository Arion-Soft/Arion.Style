using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Arion.Style.Commands
{
    public class NumberCommand
    {
        #region Up Command

        public static readonly RoutedCommand UpCommand = new RoutedCommand();
        
        public static bool GetHandlesUpCommand(DependencyObject obj)
            => (bool)obj.GetValue(HandlesUpCommandProperty);

        public static void SetHandlesUpCommand(DependencyObject obj, bool value)
            => obj.SetValue(HandlesUpCommandProperty, value);

        public static readonly DependencyProperty HandlesUpCommandProperty =
            DependencyProperty.RegisterAttached("HandlesUpCommand", typeof(bool), typeof(NumberCommand), new PropertyMetadata(false, OnHandlesUpCommandChanged));

        private static void OnHandlesUpCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement element)
            {
                if ((bool)e.NewValue)
                {
                    element.CommandBindings.Add(new CommandBinding(UpCommand, OnUpCommand));
                }
                else
                {
                    for (int i = element.CommandBindings.Count - 1; i >= 0; i--)
                    {
                        if (element.CommandBindings[i].Command == UpCommand)
                        {
                            element.CommandBindings.RemoveAt(i);
                        }
                    }
                }
            }
        }
        
        private static void OnUpCommand(object sender, ExecutedRoutedEventArgs e)
        {
            switch (e.Source)
            {
                case TextBox textBox:
                    if (int.TryParse(textBox.Text, out var value))
                    {
                        textBox.SetCurrentValue(TextBox.TextProperty, (value+1).ToString());
                    }
                    else textBox.SetCurrentValue(TextBox.TextProperty, "0");
                    break;
            }
            e.Handled = true;
        }

        #endregion

        #region Down Command

        public static readonly RoutedCommand DownCommand = new RoutedCommand();
        
        public static bool GetHandlesDownCommand(DependencyObject obj)
            => (bool)obj.GetValue(HandlesDownCommandProperty);

        public static void SetHandlesDownCommand(DependencyObject obj, bool value)
            => obj.SetValue(HandlesDownCommandProperty, value);

        public static readonly DependencyProperty HandlesDownCommandProperty =
            DependencyProperty.RegisterAttached("HandlesDownCommand", typeof(bool), typeof(NumberCommand), new PropertyMetadata(false, OnHandlesDownCommandChanged));

        private static void OnHandlesDownCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement element)
            {
                if ((bool)e.NewValue)
                {
                    element.CommandBindings.Add(new CommandBinding(DownCommand, OnDownCommand));
                }
                else
                {
                    for (int i = element.CommandBindings.Count - 1; i >= 0; i--)
                    {
                        if (element.CommandBindings[i].Command == UpCommand)
                        {
                            element.CommandBindings.RemoveAt(i);
                        }
                    }
                }
            }
        }
        
        private static void OnDownCommand(object sender, ExecutedRoutedEventArgs e)
        {
            switch (e.Source)
            {
                case TextBox textBox:
                    if (int.TryParse(textBox.Text, out var value))
                    {
                        textBox.SetCurrentValue(TextBox.TextProperty, (value-1).ToString());
                    }
                    else textBox.SetCurrentValue(TextBox.TextProperty, "0");
                    break;
            }
            e.Handled = true;
        }

        #endregion
    }
}