using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Arion.Style.Controls
{
    public partial class RangeSlider
    {
        #region Events

        public event EventHandler RightValueChanged;
        public event EventHandler LeftValueChanged;
        public event EventHandler MaximumChanged;
        public event EventHandler MinimumChanged;

        #endregion

        public RangeSlider()
        {
            InitializeComponent();
            UpperValue = Maximum;
            LowerValue = Minimum;

            try
            {
                if(!double.IsNaN(Width))
                    Track.Width = Width - 20;
            
                #region LeftThumb

                // LeftThumbBackground = new SolidColorBrush(Colors.Black);
                // LeftThumbBorderBrush = new SolidColorBrush(Colors.White);
                LeftThumbBorder = new Thickness(1);
                LeftThumbWidth = 10;
                LeftThumbHeight = 20;
                LeftThumbMargin = new Thickness(-(LeftThumbWidth/2), 0, 0, 0);

                #endregion

                #region RightThumb

                // RightThumbBackground = new SolidColorBrush(Colors.White);
                // RightThumbBorderBrush = new SolidColorBrush(Colors.Black);
                RightThumbBorder = new Thickness(1);
                RightThumbWidth = 10;
                RightThumbHeight = 20;
                RightThumbMargin = new Thickness(0, 0, -(RightThumbWidth/2), 0);

                #endregion

                #region CenterThumb

                CenterThumbBackground = new SolidColorBrush(Color.FromRgb(0x6B, 0xB3, 0xFA));
                CenterThumbOpacity = 0.5;

                #endregion

                #region Track

                TrackBackground = new SolidColorBrush(Colors.Gray);
                TrackHeight = 2;

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

        private void RangeSlider_OnLoaded(object sender, RoutedEventArgs e)
        {
            UpperValue = Maximum;
            LowerValue = Minimum;

            Track.Width = Width - 10;
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
                RightValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty UpperValueProperty =
            DependencyProperty.Register(nameof(UpperValue), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LowerValue

        public double LowerValue
        {
            get => (double)GetValue(LowerValueProperty);
            set
            {
                SetValue(LowerValueProperty, value);
                LeftValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty LowerValueProperty =
            DependencyProperty.Register(nameof(LowerValue), typeof(double), typeof(RangeSlider), new PropertyMetadata());

        #endregion

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
            DependencyProperty.Register(nameof(Maximum), typeof(double), typeof(RangeSlider), new PropertyMetadata());

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
            DependencyProperty.Register(nameof(Minimum), typeof(double), typeof(RangeSlider), new PropertyMetadata());

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
        private bool _centerSliderPressed;

        private Point _leftSliderPoint;
        private Point _rightSliderPoint;
        private Point _centerSliderPoint;

        #region Logic

        private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_leftSliderPressed)
            {
                // Получение местоположения от
                _leftSliderPoint = e.GetPosition(Thumb1);
                MoveLeftThumb();
                CheckBorder();
            }
            else if (_rightSliderPressed)
            {
                _rightSliderPoint = e.GetPosition(Thumb2);
                MoveRightThumb();
                CheckBorder();
            }
            else if (_centerSliderPressed)
            {
                _centerSliderPoint = e.GetPosition(CenterThumb);

                var changedMarginLeft =
                    Math.Round(Math.Truncate(LeftThumbMargin.Left) + _centerSliderPoint.X + Thumb1.Width / 2);
                LeftThumbMargin = new Thickness(changedMarginLeft, 0, 0, 0);

                var changedMarginRight =
                    Math.Round(Math.Truncate(RightThumbMargin.Right) - _centerSliderPoint.X - Thumb2.Width / 2);
                RightThumbMargin = new Thickness(0, 0, changedMarginRight, 0);

                CheckBorder();
            }

            var middle = Maximum - Minimum;

            #region Расчет левого значения

            var leftMargin = Math.Round(middle * (LeftThumbMargin.Left + Thumb1.Width / 2) / Track.Width);
            LowerValue = Math.Round(leftMargin + Minimum);

            #endregion

            #region Расчет правого значения

            var rightMargin = middle * (RightThumbMargin.Right + Thumb2.Width / 2) / Track.Width;
            UpperValue = Math.Round(Maximum - rightMargin);

            #endregion

            if (LeftThumbMargin.Left + RightThumbMargin.Right > Width * Percent)
            {
                _centerSliderPressed = false;
                CenterThumbVisibility = Visibility.Collapsed;
            }
            else CenterThumbVisibility = Visibility.Visible;

            MoveCenterThumbAndFill();
        }

        private void MoveCenterThumbAndFill()
        {
            CenterThumb.Margin = new Thickness(LeftThumbMargin.Left, 0, RightThumbMargin.Right, 0);
            CenterMargin = new Thickness(LeftThumbMargin.Left + Thumb1.Width / 2, 0,
                RightThumbMargin.Right + Thumb2.Width / 2, 0);
        }

        private void CheckBorder()
        {
            if (LeftThumbMargin.Left < -5)
                LeftThumbMargin = new Thickness(-5, 0, 0, 0);
            
            else if (LeftThumbMargin.Left > Track.Width - RightThumbMargin.Right- Thumb2.Width)
                LeftThumbMargin = new Thickness(Track.Width - RightThumbMargin.Right- Thumb2.Width, 0, 0, 0);
            
            
            if (RightThumbMargin.Right < -5)
                RightThumbMargin = new Thickness(0, 0, -5, 0);
            
            else if (RightThumbMargin.Right > Track.Width - LeftThumbMargin.Left - Thumb1.Width)
                RightThumbMargin = new Thickness(0, 0, Track.Width - Thumb1.Width / 2, 0);
        }

        private bool CanRightThumbMove()
        {
            if (!(LeftThumbMargin.Left + RightThumbMargin.Right + Thumb2.Width >= Track.Width)) return true;
            if (_rightSliderPoint.X > 10) return true;
            return !(_rightSliderPoint.X < 10);
        }

        private bool CanLeftThumbMove()
        {
            if (!(LeftThumbMargin.Left + RightThumbMargin.Right + Thumb1.Width >= Track.Width)) return true;
            if (_leftSliderPoint.X < 10) return true;
            return !(_leftSliderPoint.X > 10);
        }

        private void MoveRightThumb()
        {
            if (!CanRightThumbMove()) return;
            var changedMargin =
                Math.Round(Math.Truncate(RightThumbMargin.Right) - _rightSliderPoint.X + Thumb2.Width / 2);
            RightThumbMargin = new Thickness(0, 0, changedMargin, 0);
        }

        private void MoveLeftThumb()
        {
            if (!CanLeftThumbMove()) return;
            var changedMargin = Math.Round(Math.Truncate(LeftThumbMargin.Left) + _leftSliderPoint.X - Thumb1.Width / 2);
            LeftThumbMargin = new Thickness(changedMargin, 0, 0, 0);
        }

        private void LeftSlider_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = true;
            Mouse.Capture(Thumb1, CaptureMode.Element);
        }

        private void LeftSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = false;
            Mouse.Capture(Thumb1, CaptureMode.None);
        }

        private void RightSlider_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _rightSliderPressed = true;
            Mouse.Capture(Thumb2, CaptureMode.Element);
        }

        private void RightSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _rightSliderPressed = false;
            Mouse.Capture(Thumb2, CaptureMode.None);
        }

        private void RangeSlider_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _leftSliderPressed = false;
            _rightSliderPressed = false;
            _centerSliderPressed = false;
            Mouse.Capture(Thumb1, CaptureMode.None);
            Mouse.Capture(Thumb2, CaptureMode.None);
            Mouse.Capture(CenterThumb, CaptureMode.None);
        }

        private void Center_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _centerSliderPressed = true;
            Mouse.Capture(CenterThumb, CaptureMode.Element);
        }

        private void Center_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _centerSliderPressed = false;
            Mouse.Capture(CenterThumb, CaptureMode.None);
        }

        public void SetLowerValue(double value)
        {
            LowerValue = value;
            var percent = value * 100 / Maximum;
            var margin = percent * Track.Width / 100;
            LeftThumbMargin = new Thickness(margin-5, 0, 0, 0);
            MoveCenterThumbAndFill();
        }

        public void SetUpperValue(double value)
        {
            UpperValue = value;
            var percent = Math.Abs(Math.Round(value * 100 / Maximum, 2) - 100);
            var margin = Math.Round(percent * (Track.Width) / 100, 2);
            RightThumbMargin = new Thickness(0, 0, margin-5, 0);
            MoveCenterThumbAndFill();
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
            CenterThumbOpacity = 1;
        }

        private void RangeSlider_OnMouseLeave(object sender, MouseEventArgs e)
        {
            CenterThumbOpacity = .5;
        }
    }
}