using System.Windows;
using Arion.Style.Controls;

namespace Arion.Style.AttachedProperties
{
    public class Button
    {
        #region Left Icon

        public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
            "LeftIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetLeftIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(LeftIconProperty, value);
        }

        public static EIcons GetLeftIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(LeftIconProperty);
        }

        #endregion

        #region Right Icon

        public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
            "RightIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetRightIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(RightIconProperty, value);
        }

        public static EIcons GetRightIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(RightIconProperty);
        }

        #endregion

        #region Center Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached(
            "Icon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(IconProperty, value);
        }

        public static EIcons GetIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(IconProperty);
        }

        #endregion
    }
}