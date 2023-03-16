using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Arion.Theme.Controls
{
    public partial class DisplayControl : UserControl
    {
        public DisplayControl()
        {
            InitializeComponent();
            Width = 230;
            Height = 130;
        }

        #region Variables

        #region Actual Value

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

        #region Target Value

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

        #region Text

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region Max Value

        public double MaxValue
        {
            get => (double)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register(nameof(MaxValue), typeof(double), typeof(DisplayControl), new PropertyMetadata());

        #endregion

        #region Min Value

        public double MinValue
        {
            get => (double)GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }

        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register(nameof(MinValue), typeof(double), typeof(DisplayControl), new PropertyMetadata());

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
        
        private void ValueControl_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(0xDD, 0xE2, 0xE4));
        }

        private void ValueControl_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(0xF6, 0xF8, 0xF9));
        }

        #endregion
    }
}