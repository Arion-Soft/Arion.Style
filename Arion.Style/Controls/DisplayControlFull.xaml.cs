using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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

        private async void Send()
        {
            if (QuickChange)
            {
                TargetValueChange?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                await Task.Run(() =>
                {
                    if (_firstSend == false)
                    {
                        _startSend = DateTime.Now;
                        _firstSend = true;
                        while (true)
                        {
                            if ((DateTime.Now - _startSend).Seconds > .1)
                            {
                                _firstSend = false;
                                TargetValueChange?.Invoke(this, EventArgs.Empty);
                                break;
                            }
                        }
                    }
                });
            }
        }

        public static readonly DependencyProperty TargetValueProperty =
            DependencyProperty.Register(nameof(TargetValue), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

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

        #endregion

        private void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            if (TargetValue - Step >= Minimum)
                TargetValue -= Step;
        }

        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            if (MaxIsLimit)
            {
                if (TargetValue + Step <= Limit)
                    TargetValue += Step;
            }
            else if (TargetValue + Step <= Maximum)
                TargetValue += Step;
        }
    }
}