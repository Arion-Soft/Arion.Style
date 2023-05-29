using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Arion.Style.Helpers;

namespace Arion.Style.Controls
{
    public partial class DisplayControlFull : UserControl
    {
        public DisplayControlFull()
        {
            InitializeComponent();
        }

        #region Events

        public event EventHandler TargetValueChange;

        #endregion

        #region Properties

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(DisplayControlFull),
                new PropertyMetadata());

        public double ActualValue
        {
            get => (double)GetValue(ActualValueProperty);
            set => SetValue(ActualValueProperty, Math.Round(value, Round));
        }

        public static readonly DependencyProperty ActualValueProperty =
            DependencyProperty.Register(nameof(ActualValue), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        public double TargetValue
        {
            get => (double)GetValue(TargetValueProperty);
            set
            {
                SetValue(TargetValueProperty, Math.Round(value, Round));
                Send();
            }
        }
        
        public static readonly DependencyProperty TargetValueProperty =
            DependencyProperty.Register(nameof(TargetValue), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        public bool QuickChange
        {
            get => (bool)GetValue(QuickChangeProperty);
            set => SetValue(QuickChangeProperty, value);
        }

        public static readonly DependencyProperty QuickChangeProperty =
            DependencyProperty.Register(nameof(QuickChange), typeof(bool), typeof(DisplayControlFull), new PropertyMetadata());

        public int Round
        {
            get => (int)GetValue(RoundProperty);
            set => SetValue(RoundProperty, value);
        }

        public static readonly DependencyProperty RoundProperty =
            DependencyProperty.Register(nameof(Round), typeof(int), typeof(DisplayControlFull), new PropertyMetadata());

        private DateTime _startSend;
        private bool _firstSend;

        private Waiter _sendWaiter;

        private async void Send()
        {
            if (QuickChange)
            {
                TargetValueChange?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_sendWaiter == null) _sendWaiter = new Waiter();
                await _sendWaiter.Wait();
                TargetValueChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public double Step
        {
            get => (double)GetValue(StepProperty);
            set => SetValue(StepProperty, value);
        }

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register(nameof(Step), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set
            {
                SetValue(MaximumProperty, value);
                if (TargetValue > value) TargetValue = value;
            }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(nameof(Maximum), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(0.0));

        public double Minimum
        {
            get => (double)GetValue(MinimumProperty);
            set
            {
                SetValue(MinimumProperty, value);
                if (TargetValue < value) TargetValue = value;
            }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(nameof(Minimum), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(0.0));

        public double Limit
        {
            get => (double)GetValue(LimitProperty);
            set => SetValue(LimitProperty, value);
        }

        public static readonly DependencyProperty LimitProperty =
            DependencyProperty.Register(nameof(Limit), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(0.0));

        public bool MaxIsLimit
        {
            get => (bool)GetValue(MaxIsLimitProperty);
            set => SetValue(MaxIsLimitProperty, value);
        }

        public static readonly DependencyProperty MaxIsLimitProperty =
            DependencyProperty.Register(nameof(MaxIsLimit), typeof(bool), typeof(DisplayControlFull), new PropertyMetadata());

        public static readonly DependencyProperty SpeedChangeProperty = DependencyProperty.Register(
            nameof(SpeedChange), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(1.0));

        public double SpeedChange
        {
            get => (double)GetValue(SpeedChangeProperty);
            set => SetValue(SpeedChangeProperty, value);
        }

        #endregion

        private double _delta;
        private Waiter _minusWaiter;
        private Waiter _plusWaiter;
        
        private async void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            if (_minusWaiter == null) _minusWaiter = new Waiter();
            if (_delta == 0) _delta = Step;
            if (TargetValue - Step >= Minimum)
                TargetValue -= _delta;
            else TargetValue = Minimum;

            _delta += Step * SpeedChange;
            await _minusWaiter.Wait();
            _delta = Step;
        }

        private async void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            if (_plusWaiter == null) _plusWaiter = new Waiter();
            if (_delta == 0) _delta = Step;
            if (MaxIsLimit)
            {
                if (TargetValue + Step <= Limit)
                    TargetValue += _delta;
                else TargetValue = Limit;
            }
            else if (TargetValue + Step <= Maximum)
                TargetValue += _delta;
            else TargetValue = Maximum;
            
            _delta *= SpeedChange;
            await _plusWaiter.Wait();
                _delta = Step;
        }

        public void PressPlus()
        {
            BtnPlus_OnClick(null, null);
        }

        public void PressMinus()
        {
            BtnMinus_OnClick(null, null);
        }
    }
}