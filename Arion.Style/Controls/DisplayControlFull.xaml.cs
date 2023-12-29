using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Arion.Style.Helpers;

namespace Arion.Style.Controls
{
    public partial class DisplayControlFull
    {
        #region Constructor

        public DisplayControlFull()
        {
            InitializeComponent();
            _sendWaiter = new CallerOnlyOnce(250);
            _minusWaiter = new CallerOnlyOnce(250);
            _plusWaiter = new CallerOnlyOnce(250);
        }

        #endregion

        #region Private fields

        private readonly CallerOnlyOnce _sendWaiter;
        private double _delta;
        private readonly CallerOnlyOnce _minusWaiter;
        private readonly CallerOnlyOnce _plusWaiter;

        #endregion
        
        #region Events

        public event EventHandler TargetValueChange;

        #endregion

        #region Properties

        #region Label

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string), typeof(DisplayControlFull),
                new PropertyMetadata());

        #endregion

        #region ActualValue

        public double ActualValue
        {
            get => (double)GetValue(ActualValueProperty);
            set => SetValue(ActualValueProperty, Math.Round(value, Round));
        }

        public static readonly DependencyProperty ActualValueProperty =
            DependencyProperty.Register(nameof(ActualValue), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        #endregion

        #region TargetValue

        public double TargetValue
        {
            get => (double)GetValue(TargetValueProperty);
            set
            {
                SetValue(TargetValueProperty, Math.Round(value, Round));
                if (QuickChange) TargetValueChange?.Invoke(this, EventArgs.Empty);
                else _sendWaiter.CallOnce(() => TargetValueChange?.Invoke(this, EventArgs.Empty));
            }
        }
        
        public static readonly DependencyProperty TargetValueProperty =
            DependencyProperty.Register(nameof(TargetValue), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        #endregion

        #region QuickChange

        public bool QuickChange
        {
            get => (bool)GetValue(QuickChangeProperty);
            set => SetValue(QuickChangeProperty, value);
        }

        public static readonly DependencyProperty QuickChangeProperty =
            DependencyProperty.Register(nameof(QuickChange), typeof(bool), typeof(DisplayControlFull), new PropertyMetadata());

        #endregion

        #region Round

        public int Round
        {
            get => (int)GetValue(RoundProperty);
            set => SetValue(RoundProperty, value);
        }

        public static readonly DependencyProperty RoundProperty =
            DependencyProperty.Register(nameof(Round), typeof(int), typeof(DisplayControlFull), new PropertyMetadata());

        #endregion

        #region Step

        public double Step
        {
            get => (double)GetValue(StepProperty);
            set => SetValue(StepProperty, value);
        }

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register(nameof(Step), typeof(double), typeof(DisplayControlFull),
                new PropertyMetadata());

        #endregion

        #region Maximum

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

        #endregion

        #region Minimum

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

        #endregion

        #region Limit

        public double Limit
        {
            get => (double)GetValue(LimitProperty);
            set => SetValue(LimitProperty, value);
        }

        public static readonly DependencyProperty LimitProperty =
            DependencyProperty.Register(nameof(Limit), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(0.0));

        #endregion

        #region MaxIsLimit

        public bool MaxIsLimit
        {
            get => (bool)GetValue(MaxIsLimitProperty);
            set => SetValue(MaxIsLimitProperty, value);
        }

        public static readonly DependencyProperty MaxIsLimitProperty =
            DependencyProperty.Register(nameof(MaxIsLimit), typeof(bool), typeof(DisplayControlFull), new PropertyMetadata());

        #endregion

        #region SpeedChange

        public double SpeedChange
        {
            get => (double)GetValue(SpeedChangeProperty);
            set => SetValue(SpeedChangeProperty, value);
        }
        
        public static readonly DependencyProperty SpeedChangeProperty = DependencyProperty.Register(
            nameof(SpeedChange), typeof(double), typeof(DisplayControlFull), new PropertyMetadata(1.0));

        #endregion

        #endregion

        #region Private Methods

        private void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            if (_delta == 0) _delta = Step;
            if (TargetValue - Step >= Minimum)
                TargetValue -= _delta;
            else TargetValue = Minimum;

            _delta += SpeedChange;
            _minusWaiter.CallOnce(() => _delta = Step);
        }

        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
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
            _plusWaiter.CallOnce(() => _delta = Step);
        }

        #endregion

        #region Public Methods

        public void PressPlus()
        {
            BtnPlus_OnClick(null, null);
        }

        public void PressMinus()
        {
            BtnMinus_OnClick(null, null);
        }

        #endregion
    }
}