using System.Windows;
using System.Windows.Input;

namespace Arion.Style.AttachedProperties
{
    public class Badge
    {
        #region Command

        public static readonly DependencyProperty CommandCloseProperty = DependencyProperty.RegisterAttached(
            "CommandClose", typeof(ICommand), typeof(Badge), new PropertyMetadata(default(ICommand)));

        public static void SetCommandClose(DependencyObject element, ICommand value)
        {
            element.SetValue(CommandCloseProperty, value);
        }

        public static ICommand GetCommandClose(DependencyObject element)
        {
            return (ICommand)element.GetValue(CommandCloseProperty);
        }

        #endregion Command
    }
}