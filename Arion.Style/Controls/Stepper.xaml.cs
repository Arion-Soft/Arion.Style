using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Arion.Style.Controls
{
    public partial class Stepper : UserControl
    {
        public Stepper()
        {
            InitializeComponent();
            DataObject.AddPastingHandler(TblValue, OnTextPaste);
            DataObject.AddPastingHandler(TbValue, OnTextPaste);
        }

        public event EventHandler Plus;
        public event EventHandler Minus;
        public event EventHandler<double> Changed;
        
        #region Value

        /// <summary>
        /// Значение, по умолчанию - 1
        /// </summary>
        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(double), typeof(Stepper), new PropertyMetadata(1.0));

        #endregion

        #region Maximum

        /// <summary>
        /// Максимальное значение, по умолчанию - 100
        /// </summary>
        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set => SetValue(MaximumProperty, value);
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(nameof(Maximum), typeof(double), typeof(Stepper), new PropertyMetadata(100.0));

        #endregion

        #region Minimum

        /// <summary>
        /// Минимальное значение, по умолчанию - 0
        /// </summary>
        public double Minimum
        {
            get => (double)GetValue(MinimumProperty);
            set => SetValue(MinimumProperty, value);
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(nameof(Minimum), typeof(double), typeof(Stepper), new PropertyMetadata(0.0));

        #endregion

        #region Step

        /// <summary>
        /// Шаг, по умолчанию - 1
        /// </summary>
        public double Step
        {
            get => (double)GetValue(StepProperty);
            set => SetValue(StepProperty, value);
        }

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register(nameof(Step), typeof(double), typeof(Stepper), new PropertyMetadata(1.0));

        #endregion

        private void OnTextPaste(object sender, DataObjectPastingEventArgs e)
        {
            e.CancelCommand();
            e.Handled = true;
        }

        private void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(Value - Step >= Minimum)) return;
            Value -= Step;
            Minus?.Invoke(this, EventArgs.Empty);
        }
        
        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(Value + Step <= Maximum)) return;
            Value += Step;
            Plus?.Invoke(this, EventArgs.Empty);
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ChangeVisible();
        }

        private void ChangeVisible()
        {
            if (TblValue.Visibility == Visibility.Visible)
            {
                TblValue.Visibility = Visibility.Collapsed;
                TbValue.Visibility = Visibility.Visible;
                TbValue.Focus();
            }
            else if (TblValue.Visibility == Visibility.Collapsed)
            {
                if (double.TryParse(TblValue.Text, out _))
                {
                    TblValue.Visibility = Visibility.Visible;
                    TbValue.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Stepper_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) ChangeVisible();
        }

        private void TbValue_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var ch = char.Parse(e.Text);
            if (!((ch >= '0' && ch <= '9') || ch == ',' || ch == '.' || ch == (char)Key.Back)) e.Handled = true;
            
        }

        private void TbValue_OnLostFocus(object sender, RoutedEventArgs e)
        {
            Value = Math.Clamp(Value, Minimum, Maximum);
        }

        private void TbValue_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Changed?.Invoke(this, Value);
        }
    }
}