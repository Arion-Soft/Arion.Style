using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Arion.Style.Controls
{
    public sealed partial class RangeSlider : INotifyPropertyChanged
    {
        #region Events

        public event EventHandler UpperValueChanged;
        public event EventHandler LowerValueChanged;
        public event EventHandler MaximumChanged;
        public event EventHandler MinimumChanged;

        #endregion

        public RangeSlider()
        {
            InitializeComponent();
            PropertyChanged += OnPropertyChanged;
            UpperValue = Maximum;
            LowerValue = Minimum;

            try
            {
                if (!double.IsNaN(Width))
                    Track.Width = Width - 20;

                #region LeftThumb

                // LeftThumbBackground = new SolidColorBrush(Colors.Black);
                // LeftThumbBorderBrush = new SolidColorBrush(Colors.White);
                LeftThumbBorder = new Thickness(1);
                LeftThumbWidth = 10;
                LeftThumbHeight = 20;
                LeftThumbMargin = new Thickness(-(LeftThumbWidth / 2), 0, 0, 0);

                #endregion

                #region RightThumb

                // RightThumbBackground = new SolidColorBrush(Colors.White);
                // RightThumbBorderBrush = new SolidColorBrush(Colors.Black);
                RightThumbBorder = new Thickness(1);
                RightThumbWidth = 10;
                RightThumbHeight = 20;
                RightThumbMargin = new Thickness(0, 0, -(RightThumbWidth / 2), 0);

                #endregion

                #region CenterThumb

                CenterThumbBackground = new SolidColorBrush(Color.FromRgb(0x6B, 0xB3, 0xFA));
                CenterThumbOpacity = 0;

                #endregion

                #region Track

                TrackBackground = new SolidColorBrush(Colors.Gray);
                TrackHeight = 2;
                TrackWidth = Width - 10;

                #endregion

                #region SelectedTrack

                // SelectedTrackBackground = new SolidColorBrush(Colors.CornflowerBlue);
                SelectedTrackBackground = new SolidColorBrush(Colors.Transparent);
                SelectedTrackHeight = 4;

                #endregion

                if (!ShowValues)
                {
                    Brd1.Visibility = Visibility.Collapsed;
                    Brd2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Brd1.Visibility = Visibility.Hidden;
                    Brd2.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message}\n{e.StackTrace}");
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine($"property changed: {e.PropertyName}");
            if (e.PropertyName == nameof(LowerValue))
            {
                if (LowerValue < Minimum || LowerValue > Maximum) return;
                var v1 = (LowerValue - Minimum) * TrackWidth;
                var v2 = v1 / Maximum;
                var margin = Math.Round(v2);
                LeftThumbMargin = new Thickness(margin-5, 0, 10, 0);
                LowerValueChanged?.Invoke(this, EventArgs.Empty);
                CenterMargin = new Thickness(margin, 0, CenterMargin.Right, 0);
            }
            else if (e.PropertyName == nameof(UpperValue))
            {
                if (UpperValue < Minimum || UpperValue > Maximum) return;
                var v1 = (UpperValue - Minimum) * TrackWidth;
                var v2 = v1 / (Maximum - Minimum);
                var margin = Math.Round(v2);
                RightThumbMargin = new Thickness(margin, 0, -10, 0);
                UpperValueChanged?.Invoke(this, EventArgs.Empty);
                CenterMargin = new Thickness(CenterMargin.Left, 0, Math.Abs(margin-TrackWidth), 0);
            }
        }

        private void RangeSlider_OnLoaded(object sender, RoutedEventArgs e)
        {
            TrackWidth = Width - 10;
            UpperValue = Maximum;
            LowerValue = Minimum;

            if (!ShowValues)
            {
                Brd1.Visibility = Visibility.Collapsed;
                Brd2.Visibility = Visibility.Collapsed;
            }
            else
            {
                Brd1.Visibility = Visibility.Hidden;
                Brd2.Visibility = Visibility.Hidden;
            }
        }

        #region Properties

        #region General

        #region UpperValue

        public double UpperValue
        {
            get => (double)GetValue(UpperValueProperty);
            set
            {
                SetValue(UpperValueProperty, value);
                OnPropertyChanged();
            }
        }

        public static readonly DependencyProperty UpperValueProperty =
            DependencyProperty.Register(nameof(UpperValue), typeof(double), typeof(RangeSlider),
                new PropertyMetadata(100.0, PropertyChangedCallback, UpperValueCoerceValueCallback));

        private static object UpperValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            if (!(d is RangeSlider slider)) return null;

            var value = (double)baseValue;

            if (value > slider.Maximum) return slider.Maximum;
            if (value < slider.LowerValue) return slider.LowerValue;
            return value;
        }

        #endregion

        #region LowerValue

        [Category("Значения")]
        public double LowerValue
        {
            get => (double)GetValue(LowerValueProperty);
            set
            {
                SetValue(LowerValueProperty, value);
                OnPropertyChanged();
            }
        }

        public static readonly DependencyProperty LowerValueProperty =
            DependencyProperty.Register(nameof(LowerValue), typeof(double), typeof(RangeSlider), new FrameworkPropertyMetadata(
                0.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender, PropertyChangedCallback, LowerValueCoerceValueCallback));

        private static object LowerValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            if (!(d is RangeSlider slider)) return null;

            var value = (double)baseValue;

            if (value < slider.Minimum) return slider.Minimum;
            if (value > slider.UpperValue) return slider.UpperValue;
            return value;
        }

        #endregion
        
        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RangeSlider slider) slider.OnPropertyChanged(e.Property.Name);
        }

        #region Maximum

        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set
            {
                SetValue(MaximumProperty, value);
                MaximumChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(nameof(Maximum), typeof(double), typeof(RangeSlider), new PropertyMetadata(100.0));

        #endregion

        #region Minimum

        public double Minimum
        {
            get => (double)GetValue(MinimumProperty);
            set
            {
                SetValue(MinimumProperty, value);
                MinimumChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(nameof(Minimum), typeof(double), typeof(RangeSlider), new PropertyMetadata(0.0));

        #endregion

        #endregion

        #region LeftThumb

        #region LeftThumbMargin

        public Thickness LeftThumbMargin
        {
            get => (Thickness)GetValue(LeftThumbMarginProperty);
            set => SetValue(LeftThumbMarginProperty, value);
        }

        public static readonly DependencyProperty LeftThumbMarginProperty =
            DependencyProperty.Register(nameof(LeftThumbMargin), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftThumbBorder

        public Thickness LeftThumbBorder
        {
            get => (Thickness)GetValue(LeftThumbBorderProperty);
            set => SetValue(LeftThumbBorderProperty, value);
        }

        public static readonly DependencyProperty LeftThumbBorderProperty =
            DependencyProperty.Register(nameof(LeftThumbBorder), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftThumbBackground

        public SolidColorBrush LeftThumbBackground
        {
            get => (SolidColorBrush)GetValue(LeftThumbBackgroundProperty);
            set => SetValue(LeftThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty LeftThumbBackgroundProperty =
            DependencyProperty.Register(nameof(LeftThumbBackground), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftThumbBorderBrush

        public SolidColorBrush LeftThumbBorderBrush
        {
            get => (SolidColorBrush)GetValue(LeftThumbBorderBrushProperty);
            set => SetValue(LeftThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty LeftThumbBorderBrushProperty =
            DependencyProperty.Register(nameof(LeftThumbBorderBrush), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftThumbWidth

        public double LeftThumbWidth
        {
            get => (double)GetValue(LeftThumbWidthProperty);
            set => SetValue(LeftThumbWidthProperty, value);
        }

        public static readonly DependencyProperty LeftThumbWidthProperty =
            DependencyProperty.Register(nameof(LeftThumbWidth), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftThumbHeight

        public double LeftThumbHeight
        {
            get => (double)GetValue(LeftThumbHeightProperty);
            set => SetValue(LeftThumbHeightProperty, value);
        }

        public static readonly DependencyProperty LeftThumbHeightProperty =
            DependencyProperty.Register(nameof(LeftThumbHeight), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #endregion

        #region RightThumb

        #region RightThumbMargin

        public Thickness RightThumbMargin
        {
            get => (Thickness)GetValue(RightThumbMarginProperty);
            set => SetValue(RightThumbMarginProperty, value);
        }

        public static readonly DependencyProperty RightThumbMarginProperty =
            DependencyProperty.Register(nameof(RightThumbMargin), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region RightThumbBorder

        public Thickness RightThumbBorder
        {
            get => (Thickness)GetValue(RightThumbBorderProperty);
            set => SetValue(RightThumbBorderProperty, value);
        }

        public static readonly DependencyProperty RightThumbBorderProperty =
            DependencyProperty.Register(nameof(RightThumbBorder), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region RightThumbBackground

        public SolidColorBrush RightThumbBackground
        {
            get => (SolidColorBrush)GetValue(RightThumbBackgroundProperty);
            set => SetValue(RightThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty RightThumbBackgroundProperty =
            DependencyProperty.Register(nameof(RightThumbBackground), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region RightThumbBorderBrush

        public SolidColorBrush RightThumbBorderBrush
        {
            get => (SolidColorBrush)GetValue(RightThumbBorderBrushProperty);
            set => SetValue(RightThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty RightThumbBorderBrushProperty =
            DependencyProperty.Register(nameof(RightThumbBorderBrush), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region RightThumbWidth

        public double RightThumbWidth
        {
            get => (double)GetValue(RightThumbWidthProperty);
            set => SetValue(RightThumbWidthProperty, value);
        }

        public static readonly DependencyProperty RightThumbWidthProperty =
            DependencyProperty.Register(nameof(RightThumbWidth), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region RightThumbHeight

        public double RightThumbHeight
        {
            get => (double)GetValue(RightThumbHeightProperty);
            set => SetValue(RightThumbHeightProperty, value);
        }

        public static readonly DependencyProperty RightThumbHeightProperty =
            DependencyProperty.Register(nameof(RightThumbHeight), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #endregion

        #region CenterMargin

        public Thickness CenterMargin
        {
            get => (Thickness)GetValue(CenterMarginProperty);
            set => SetValue(CenterMarginProperty, value);
        }

        public static readonly DependencyProperty CenterMarginProperty =
            DependencyProperty.Register(nameof(CenterMargin), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region Percent

        public double Percent
        {
            get => (double)GetValue(PercentProperty);
            set
            {
                if (value > 1) value = 1;
                else if (value < 0) value = 0;
                SetValue(PercentProperty, value);
            }
        }

        public static readonly DependencyProperty PercentProperty =
            DependencyProperty.Register(nameof(Percent), typeof(double), typeof(RangeSlider), new PropertyMetadata(.8));

        #endregion

        #region CenterThumb

        #region CenterThumbWidth

        public double CenterThumbWidth
        {
            get => (double)GetValue(CenterThumbWidthProperty);
            set => SetValue(CenterThumbWidthProperty, value);
        }

        public static readonly DependencyProperty CenterThumbWidthProperty =
            DependencyProperty.Register(nameof(CenterThumbWidth), typeof(double), typeof(RangeSlider),
                new PropertyMetadata(24.0));

        #endregion

        #region CenterThumbVisibility

        public Visibility CenterThumbVisibility
        {
            get => (Visibility)GetValue(CenterThumbVisibilityProperty);
            set => SetValue(CenterThumbVisibilityProperty, value);
        }

        public static readonly DependencyProperty CenterThumbVisibilityProperty =
            DependencyProperty.Register(nameof(CenterThumbVisibility), typeof(Visibility), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region CenterThumbBackground

        public SolidColorBrush CenterThumbBackground
        {
            get => (SolidColorBrush)GetValue(CenterThumbBackgroundProperty);
            set => SetValue(CenterThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty CenterThumbBackgroundProperty =
            DependencyProperty.Register(nameof(CenterThumbBackground), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region CenterThumbBorderBrush

        public SolidColorBrush CenterThumbBorderBrush
        {
            get => (SolidColorBrush)GetValue(CenterThumbBorderBrushProperty);
            set => SetValue(CenterThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CenterThumbBorderBrushProperty =
            DependencyProperty.Register(nameof(CenterThumbBorderBrush), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region CenterThumbBorder

        public Thickness CenterThumbBorder
        {
            get => (Thickness)GetValue(CenterThumbBorderProperty);
            set => SetValue(CenterThumbBorderProperty, value);
        }

        public static readonly DependencyProperty CenterThumbBorderProperty =
            DependencyProperty.Register(nameof(CenterThumbBorder), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region CenterThumbOpacity

        public static readonly DependencyProperty CenterThumbOpacityProperty = DependencyProperty.Register(
            nameof(CenterThumbOpacity), typeof(double), typeof(RangeSlider), new PropertyMetadata(default(double)));

        public double CenterThumbOpacity
        {
            get => (double)GetValue(CenterThumbOpacityProperty);
            set => SetValue(CenterThumbOpacityProperty, value);
        }

        #endregion

        #endregion

        #region Track

        #region TrackBackground

        public SolidColorBrush TrackBackground
        {
            get => (SolidColorBrush)GetValue(TrackBackgroundProperty);
            set => SetValue(TrackBackgroundProperty, value);
        }

        public static readonly DependencyProperty TrackBackgroundProperty =
            DependencyProperty.Register(nameof(TrackBackground), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region TrackBorderBrush

        public SolidColorBrush TrackBorderBrush
        {
            get => (SolidColorBrush)GetValue(TrackBorderBrushProperty);
            set => SetValue(TrackBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TrackBorderBrushProperty =
            DependencyProperty.Register(nameof(TrackBorderBrush), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region TrackBorder

        public Thickness TrackBorder
        {
            get => (Thickness)GetValue(TrackBorderProperty);
            set => SetValue(TrackBorderProperty, value);
        }

        public static readonly DependencyProperty TrackBorderProperty =
            DependencyProperty.Register(nameof(TrackBorder), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region TrackHeight

        public double TrackHeight
        {
            get => (double)GetValue(TrackHeightProperty);
            set => SetValue(TrackHeightProperty, value);
        }

        public static readonly DependencyProperty TrackHeightProperty =
            DependencyProperty.Register(nameof(TrackHeight), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region TrackWidth

        public double TrackWidth
        {
            get => (double)GetValue(TrackWidthProperty);
            set => SetValue(TrackWidthProperty, value);
        }

        public static readonly DependencyProperty TrackWidthProperty =
            DependencyProperty.Register(nameof(TrackWidth), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #endregion

        #region SelectedTrack

        #region SelectedTrackBackground

        public SolidColorBrush SelectedTrackBackground
        {
            get => (SolidColorBrush)GetValue(SelectedTrackBackgroundProperty);
            set => SetValue(SelectedTrackBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedTrackBackgroundProperty =
            DependencyProperty.Register(nameof(SelectedTrackBackground), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region SelectedTrackBorderBrush

        public SolidColorBrush SelectedTrackBorderBrush
        {
            get => (SolidColorBrush)GetValue(SelectedTrackBorderBrushProperty);
            set => SetValue(SelectedTrackBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedTrackBorderBrushProperty =
            DependencyProperty.Register(nameof(SelectedTrackBorderBrush), typeof(SolidColorBrush), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region SelectedTrackBorder

        public Thickness SelectedTrackBorder
        {
            get => (Thickness)GetValue(SelectedTrackBorderProperty);
            set => SetValue(SelectedTrackBorderProperty, value);
        }

        public static readonly DependencyProperty SelectedTrackBorderProperty =
            DependencyProperty.Register(nameof(SelectedTrackBorder), typeof(Thickness), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region SelectedTrackHeight

        public double SelectedTrackHeight
        {
            get => (double)GetValue(SelectedTrackHeightProperty);
            set => SetValue(SelectedTrackHeightProperty, value);
        }

        public static readonly DependencyProperty SelectedTrackHeightProperty =
            DependencyProperty.Register(nameof(SelectedTrackHeight), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #endregion

        public static readonly DependencyProperty ShowValuesProperty = DependencyProperty.Register(
            nameof(ShowValues), typeof(bool), typeof(RangeSlider), new PropertyMetadata(default(bool)));

        public bool ShowValues
        {
            get => (bool)GetValue(ShowValuesProperty);
            set => SetValue(ShowValuesProperty, value);
        }

        #endregion

        private bool _leftSliderPressed;
        private bool _rightSliderPressed;
        // private bool _centerSliderPressed;

        private double _leftSliderPoint;
        private double _rightSliderPoint;
        // private double _centerSliderPoint;

        #region Logic

        private void OnThumbDrag(object sender, MouseEventArgs e)
        {
            if (_leftSliderPressed)
            {
                _leftSliderPoint = Math.Round(e.GetPosition(LeftMarker).X - 5, 0);
                if (_leftSliderPoint < 0 || _leftSliderPoint > Track.Width) return;
                var calc = Math.Round(_leftSliderPoint / Track.Width * Maximum + Minimum, 0);
                if(calc > UpperValue || calc < Minimum) return;
                LowerValue = calc;
            }
            
            if (_rightSliderPressed)
            {
                _rightSliderPoint = Math.Round(e.GetPosition(RightMarker).X + 5, 0) + Track.Width;
                if (_rightSliderPoint > Track.Width || _rightSliderPoint < 0) return;
                var calc = Math.Abs(Math.Round(_rightSliderPoint / Track.Width * Maximum, 0));
                if(calc < LowerValue) return;
                UpperValue = calc;
            }
            
            // else if (_centerSliderPressed)
            // {
            //     _leftSliderPoint = Math.Round(e.GetPosition(LeftMarker).X - 5, 0);
            //     _rightSliderPoint = Math.Round(e.GetPosition(RightMarker).X + 5, 0) + Track.Width;
            //     
            //     if ((_leftSliderPoint < 0 || _leftSliderPoint > Track.Width) && (_rightSliderPoint > Track.Width || _rightSliderPoint < 0)) return;
            //     
            //     var calcLower = Math.Round(_leftSliderPoint / Track.Width * Maximum + Minimum, 0);
            //     if(calcLower > UpperValue || calcLower < Minimum) return;
            //     LowerValue = calcLower;
            //     
            //     var calcUpper = Math.Abs(Math.Round(_rightSliderPoint / Track.Width * Maximum, 0));
            //     if(calcUpper < LowerValue) return;
            //     UpperValue = calcUpper;
            // }
        }
        
        private void LeftSlider_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = true;
            Mouse.Capture(this, CaptureMode.Element);
            Panel.SetZIndex(Thumb1, 999);
            Panel.SetZIndex(Thumb2, 100);
        }

        private void LeftSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = false;
            Mouse.Capture(this, CaptureMode.None);
        }

        private void RightSlider_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _rightSliderPressed = true;
            Mouse.Capture(this, CaptureMode.Element);
            Panel.SetZIndex(Thumb1, 100);
            Panel.SetZIndex(Thumb2, 999);
        }

        private void RightSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _rightSliderPressed = false;
            Mouse.Capture(this, CaptureMode.None);
        }

        private void RangeSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = false;
            _rightSliderPressed = false;
            // _centerSliderPressed = false;
            Mouse.Capture(this, CaptureMode.None);
        }

        private void Center_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // _centerSliderPressed = true;
            Mouse.Capture(this, CaptureMode.Element);
        }

        private void Center_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            // _centerSliderPressed = false;
            Mouse.Capture(this, CaptureMode.None);
        }

        #endregion

        private void Thumb1_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (ShowValues) Brd1.Visibility = Visibility.Visible;
        }

        private void Thumb1_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (ShowValues) Brd1.Visibility = Visibility.Hidden;
        }

        private void Thumb2_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (ShowValues) Brd2.Visibility = Visibility.Visible;
        }

        private void Thumb2_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (ShowValues) Brd2.Visibility = Visibility.Hidden;
        }

        private void RangeSlider_OnMouseEnter(object sender, MouseEventArgs e)
        {
            CenterThumbOpacity = 0;
        }

        private void RangeSlider_OnMouseLeave(object sender, MouseEventArgs e)
        {
            CenterThumbOpacity = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}