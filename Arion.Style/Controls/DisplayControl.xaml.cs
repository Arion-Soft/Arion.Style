using System;
using System.Windows;
using System.Windows.Input;

namespace Arion.Style.Controls
{
    public partial class DisplayControl
    {
        public DisplayControl()
        {
            InitializeComponent();
        }

        #region Variables

        #region Actual Value

        #region Value

        public double ActualValue
        {
            get => (double)GetValue(ActualValueProperty);
            set
            {
                if (Round)
                {
                    var rounding = Math.Truncate(value);
                    SetValue(ActualValueProperty, rounding);
                }
                else
                {
                    var rounding = Math.Round(value, 1);
                    SetValue(ActualValueProperty, rounding);
                }
            }
        }

        private static readonly DependencyProperty ActualValueProperty =
            DependencyProperty.Register(nameof(ActualValue), typeof(double), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region ActualValueHorizontalAlignment

        public HorizontalAlignment ActualValueHorizontalAlignment
        {
            get => (HorizontalAlignment)GetValue(ActualValueHorizontalAlignmentProperty);
            set => SetValue(ActualValueHorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty ActualValueHorizontalAlignmentProperty =
            DependencyProperty.Register(nameof(ActualValueHorizontalAlignment), typeof(HorizontalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region ActualValueVerticalAlignment

        public VerticalAlignment ActualValueVerticalAlignment
        {
            get => (VerticalAlignment)GetValue(ActualValueVerticalAlignmentProperty);
            set => SetValue(ActualValueVerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty ActualValueVerticalAlignmentProperty =
            DependencyProperty.Register(nameof(ActualValueVerticalAlignment), typeof(VerticalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region ActualValueFontSize

        public double ActualValueFontSize
        {
            get => (double)GetValue(ActualValueFontSizeProperty);
            set => SetValue(ActualValueFontSizeProperty, value);
        }

        public static readonly DependencyProperty ActualValueFontSizeProperty =
            DependencyProperty.Register(nameof(ActualValueFontSize), typeof(double), typeof(DisplayControl),
                new PropertyMetadata(14.0));

        #endregion

        #region ActualValueMargin

        public Thickness ActualValueMargin
        {
            get => (Thickness)GetValue(ActualValueMarginProperty);
            set => SetValue(ActualValueMarginProperty, value);
        }

        public static readonly DependencyProperty ActualValueMarginProperty =
            DependencyProperty.Register(nameof(ActualValueMargin), typeof(Thickness), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region ActualValueFontWeight

        public FontWeight ActualValueFontWeight
        {
            get => (FontWeight)GetValue(ActualValueFontWeightProperty);
            set => SetValue(ActualValueFontWeightProperty, value);
        }

        public static readonly DependencyProperty ActualValueFontWeightProperty =
            DependencyProperty.Register(nameof(ActualValueFontWeight), typeof(FontWeight), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #endregion

        #region Target Value

        #region Value

        public double TargetValue
        {
            get => (double)GetValue(TargetValueProperty);
            set
            {
                try
                {
                    if (!(value >= MinValue) || !(value <= MaxValue)) return;
                    var val = Math.Round(value, 1);
                    SetValue(TargetValueProperty, val);
                    ChangeTarget?.Invoke(null, null);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}\n{exception.StackTrace}");
                }
            }
        }

        private static readonly DependencyProperty TargetValueProperty =
            DependencyProperty.Register(nameof(TargetValue), typeof(double), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region TargetValueHorizontalAlignment

        public HorizontalAlignment TargetValueHorizontalAlignment
        {
            get => (HorizontalAlignment)GetValue(TargetValueHorizontalAlignmentProperty);
            set => SetValue(TargetValueHorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty TargetValueHorizontalAlignmentProperty =
            DependencyProperty.Register(nameof(TargetValueHorizontalAlignment), typeof(HorizontalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region TargetValueVerticalAlignment

        public VerticalAlignment TargetValueVerticalAlignment
        {
            get => (VerticalAlignment)GetValue(TargetValueVerticalAlignmentProperty);
            set => SetValue(TargetValueVerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty TargetValueVerticalAlignmentProperty =
            DependencyProperty.Register(nameof(TargetValueVerticalAlignment), typeof(VerticalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region TargetValueFontSize

        public double TargetValueFontSize
        {
            get => (double)GetValue(TargetValueFontSizeProperty);
            set => SetValue(TargetValueFontSizeProperty, value);
        }

        public static readonly DependencyProperty TargetValueFontSizeProperty =
            DependencyProperty.Register(nameof(TargetValueFontSize), typeof(double), typeof(DisplayControl),
                new PropertyMetadata(14.0));

        #endregion

        #region TargetValueMargin

        public Thickness TargetValueMargin
        {
            get => (Thickness)GetValue(TargetValueMarginProperty);
            set => SetValue(TargetValueMarginProperty, value);
        }

        public static readonly DependencyProperty TargetValueMarginProperty =
            DependencyProperty.Register(nameof(TargetValueMargin), typeof(Thickness), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region TargetValueFontWeight

        public FontWeight TargetValueFontWeight
        {
            get => (FontWeight)GetValue(TargetValueFontWeightProperty);
            set => SetValue(TargetValueFontWeightProperty, value);
        }

        public static readonly DependencyProperty TargetValueFontWeightProperty =
            DependencyProperty.Register(nameof(TargetValueFontWeight), typeof(FontWeight), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #endregion

        #region Limit

        public double Limit
        {
            get => (double)GetValue(LimitProperty);
            set => SetValue(LimitProperty, value);
        }

        public static readonly DependencyProperty LimitProperty =
            DependencyProperty.Register(nameof(Limit), typeof(double), typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region Round

        public bool Round
        {
            get => (bool)GetValue(RoundProperty);
            set => SetValue(RoundProperty, value);
        }

        public static readonly DependencyProperty RoundProperty =
            DependencyProperty.Register(nameof(Round), typeof(bool), typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region Max Value

        public double MaxValue
        {
            get => (double)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register(nameof(MaxValue), typeof(double), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region Min Value

        public double MinValue
        {
            get => (double)GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register(nameof(MinValue), typeof(double), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region Text

        #region TextContent

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region TextHorizontalAlignment

        public HorizontalAlignment TextHorizontalAlignment
        {
            get => (HorizontalAlignment)GetValue(TextHorizontalAlignmentProperty);
            set => SetValue(TextHorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty TextHorizontalAlignmentProperty =
            DependencyProperty.Register(nameof(TextHorizontalAlignment), typeof(HorizontalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region TextVerticalAlignment

        public VerticalAlignment TextVerticalAlignment
        {
            get => (VerticalAlignment)GetValue(TextVerticalAlignmentProperty);
            set => SetValue(TextVerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty TextVerticalAlignmentProperty =
            DependencyProperty.Register(nameof(TextVerticalAlignment), typeof(VerticalAlignment),
                typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region TextFontSize

        public double TextFontSize
        {
            get => (double)GetValue(TextFontSizeProperty);
            set => SetValue(TextFontSizeProperty, value);
        }

        public static readonly DependencyProperty TextFontSizeProperty =
            DependencyProperty.Register(nameof(TextFontSize), typeof(double), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region TextMargin

        public Thickness TextMargin
        {
            get => (Thickness)GetValue(TextMarginProperty);
            set => SetValue(TextMarginProperty, value);
        }

        public static readonly DependencyProperty TextMarginProperty =
            DependencyProperty.Register(nameof(TextMargin), typeof(Thickness), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #region TextFontWeight

        public FontWeight TextFontWeight
        {
            get => (FontWeight)GetValue(TextFontWeightProperty);
            set => SetValue(TextFontWeightProperty, value);
        }

        public static readonly DependencyProperty TextFontWeightProperty =
            DependencyProperty.Register(nameof(TextFontWeight), typeof(FontWeight), typeof(DisplayControl),
                new PropertyMetadata());

        #endregion

        #endregion

        #endregion

        #region Handlers

        public event EventHandler ChangeTarget;

        #endregion

        #region Events

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // var numberKeyboard = new ValueNumberKeyboard { Text = $"{Text}" };
            // var value = numberKeyboard.Show();
            // TargetValue = value > MaxValue ? MaxValue : value;
        }

        #endregion
    }
}