using System.Windows;
using System.Windows.Media;

namespace Arion.Style.AttachedProperties
{
    public class TabItem
    {
        #region Border

        public static readonly DependencyProperty MainBorderProperty = DependencyProperty.RegisterAttached(
            "MainBorder", typeof(Thickness), typeof(TabItem), new PropertyMetadata(default(Thickness)));

        public static void SetMainBorder(DependencyObject element, Thickness value)
        {
            element.SetValue(MainBorderProperty, value);
        }

        public static Thickness GetMainBorder(DependencyObject element)
        {
            return (Thickness)element.GetValue(MainBorderProperty);
        }

        #endregion

        #region Colors selected

        public static readonly DependencyProperty PrimaryColorSelectedProperty = DependencyProperty.RegisterAttached(
            "PrimaryColorSelected", typeof(Color), typeof(TabItem), new PropertyMetadata(default(Color)));

        public static void SetPrimaryColorSelected(DependencyObject element, Color value)
        {
            element.SetValue(PrimaryColorSelectedProperty, value);
        }

        public static Color GetPrimaryColorSelected(DependencyObject element)
        {
            return (Color)element.GetValue(PrimaryColorSelectedProperty);
        }

        public static readonly DependencyProperty SecondaryColorSelectedProperty = DependencyProperty.RegisterAttached(
            "SecondaryColorSelected", typeof(Color), typeof(TabItem), new PropertyMetadata(default(Color)));

        public static void SetSecondaryColorSelected(DependencyObject element, Color value)
        {
            element.SetValue(SecondaryColorSelectedProperty, value);
        }

        public static Color GetSecondaryColorSelected(DependencyObject element)
        {
            return (Color)element.GetValue(SecondaryColorSelectedProperty);
        }

        #endregion

        #region Points

        #region Left

        public static readonly DependencyProperty StartPointLeftProperty = DependencyProperty.RegisterAttached(
            "StartPointLeft", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetStartPointLeft(DependencyObject element, Point value)
        {
            element.SetValue(StartPointLeftProperty, value);
        }

        public static Point GetStartPointLeft(DependencyObject element)
        {
            return (Point)element.GetValue(StartPointLeftProperty);
        }

        public static readonly DependencyProperty EndPointLeftProperty = DependencyProperty.RegisterAttached(
            "EndPointLeft", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetEndPointLeft(DependencyObject element, Point value)
        {
            element.SetValue(EndPointLeftProperty, value);
        }

        public static Point GetEndPointLeft(DependencyObject element)
        {
            return (Point)element.GetValue(EndPointLeftProperty);
        }

        #endregion

        #region Right

        public static readonly DependencyProperty StartPointRightProperty = DependencyProperty.RegisterAttached(
            "StartPointRight", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetStartPointRight(DependencyObject element, Point value)
        {
            element.SetValue(StartPointRightProperty, value);
        }

        public static Point GetStartPointRight(DependencyObject element)
        {
            return (Point)element.GetValue(StartPointRightProperty);
        }

        public static readonly DependencyProperty EndPointRightProperty = DependencyProperty.RegisterAttached(
            "EndPointRight", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetEndPointRight(DependencyObject element, Point value)
        {
            element.SetValue(EndPointRightProperty, value);
        }

        public static Point GetEndPointRight(DependencyObject element)
        {
            return (Point)element.GetValue(EndPointRightProperty);
        }

        #endregion
        
        #region Top

        public static readonly DependencyProperty StartPointTopProperty = DependencyProperty.RegisterAttached(
            "StartPointTop", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetStartPointTop(DependencyObject element, Point value)
        {
            element.SetValue(StartPointTopProperty, value);
        }

        public static Point GetStartPointTop(DependencyObject element)
        {
            return (Point)element.GetValue(StartPointTopProperty);
        }

        public static readonly DependencyProperty EndPointTopProperty = DependencyProperty.RegisterAttached(
            "EndPointTop", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetEndPointTop(DependencyObject element, Point value)
        {
            element.SetValue(EndPointTopProperty, value);
        }

        public static Point GetEndPointTop(DependencyObject element)
        {
            return (Point)element.GetValue(EndPointTopProperty);
        }

        #endregion
        
        #region Bottom

        public static readonly DependencyProperty StartPointBottomProperty = DependencyProperty.RegisterAttached(
            "StartPointBottom", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetStartPointBottom(DependencyObject element, Point value)
        {
            element.SetValue(StartPointBottomProperty, value);
        }

        public static Point GetStartPointBottom(DependencyObject element)
        {
            return (Point)element.GetValue(StartPointBottomProperty);
        }

        public static readonly DependencyProperty EndPointBottomProperty = DependencyProperty.RegisterAttached(
            "EndPointBottom", typeof(Point), typeof(TabItem), new PropertyMetadata(default(Point)));

        public static void SetEndPointBottom(DependencyObject element, Point value)
        {
            element.SetValue(EndPointBottomProperty, value);
        }

        public static Point GetEndPointBottom(DependencyObject element)
        {
            return (Point)element.GetValue(EndPointLeftProperty);
        }

        #endregion
        
        #endregion
    }
}