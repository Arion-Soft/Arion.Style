﻿using System;
using System.Windows;
using System.Windows.Controls;
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
        public event EventHandler CenterValueChanged;
        

        #endregion
    
        public RangeSlider()
        {
            InitializeComponent();
            RightValue = Maximum;
            LeftValue = Minimum;

            #region LeftThumb

            LeftThumbBackground = new SolidColorBrush(Colors.Black);
            LeftThumbBorderBrush = new SolidColorBrush(Colors.White);
            LeftThumbBorder = new Thickness(1);
            LeftThumbWidth = 20;
            LeftThumbHeight = 20;

            #endregion

            #region RightThumb

            RightThumbBackground = new SolidColorBrush(Colors.White);
            RightThumbBorderBrush = new SolidColorBrush(Colors.Black);
            RightThumbBorder = new Thickness(1);
            RightThumbWidth = 20;
            RightThumbHeight = 20;

            #endregion

            #region CenterThumb

            CenterThumbBackground = new SolidColorBrush(Color.FromRgb(0x6B, 0xB3, 0xFA));

            #endregion

            #region Track

            TrackBackground = new SolidColorBrush(Colors.Gray);
            TrackHeight = 2;

            #endregion

            #region SelectedTrack

            SelectedTrackBackground = new SolidColorBrush(Colors.CornflowerBlue);
            SelectedTrackHeight = 4;

            #endregion
        }

        private void RangeSlider_OnLoaded(object sender, RoutedEventArgs e)
        {
            RightValue = Maximum;
            LeftValue = Minimum;
        }

        #region Properties

        #region General

        #region RightValue

        public double RightValue
        {
            get => (double)GetValue(RightValueProperty);
            set
            {
                SetValue(RightValueProperty, value);
                RightValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty RightValueProperty =
            DependencyProperty.Register(nameof(RightValue), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

        #endregion

        #region LeftValue

        public double LeftValue
        {
            get => (double)GetValue(LeftValueProperty);
            set
            {
                SetValue(LeftValueProperty, value); 
                LeftValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty LeftValueProperty =
            DependencyProperty.Register(nameof(LeftValue), typeof(double), typeof(RangeSlider), new PropertyMetadata());

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

        #region CenterThumb

        #region CenterThumbWidth

        public double CenterThumbWidth
        {
            get => (double)GetValue(CenterThumbWidthProperty);
            set => SetValue(CenterThumbWidthProperty, value);
        }

        public static readonly DependencyProperty CenterThumbWidthProperty =
            DependencyProperty.Register(nameof(CenterThumbWidth), typeof(double), typeof(RangeSlider),
                new PropertyMetadata());

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
                _leftSliderPoint = e.GetPosition(Thumb1);

                var changedMargin = LeftThumbMargin.Left + _leftSliderPoint.X - Thumb1.Width / 2;
                if (_leftSliderPoint.X > 10)
                {
                    if (LeftThumbMargin.Left + Thumb1.Width <= Track.Width - RightThumbMargin.Right - Thumb2.Width / 2)
                        LeftThumbMargin = new Thickness(changedMargin, 0, 0, 0);
                }
                else if (_leftSliderPoint.X < 10)
                {
                    if (LeftThumbMargin.Left >= 0)
                        LeftThumbMargin = new Thickness(changedMargin, 0, 0, 0);
                }

                if (LeftThumbMargin.Left < 0) LeftThumbMargin = new Thickness(0);
            }
            else if (_rightSliderPressed)
            {
                _rightSliderPoint = e.GetPosition(Thumb2);
                var changedMargin = RightThumbMargin.Right - _rightSliderPoint.X + Thumb2.Width / 2;

                // Если перемещается вправо ->
                if (_rightSliderPoint.X > 10)
                {
                    RightThumbMargin = RightThumbMargin.Right <= 0
                        ? new Thickness(0)
                        : new Thickness(0, 0, changedMargin, 0);
                }
                // Если перемещается влево <-
                else if (_rightSliderPoint.X < 10)
                {
                    // Если отступ справа + ширина ползунка больше чем ширина, тогда не перемещать
                    if (RightThumbMargin.Right + Thumb2.Width <= Track.Width - LeftThumbMargin.Left - Thumb1.Width / 2)
                        RightThumbMargin = new Thickness(0, 0, changedMargin, 0);
                }
            }
            else if (_centerSliderPressed)
            {
                _centerSliderPoint = e.GetPosition(CenterThumb);

                if (_centerSliderPoint.X > 10)
                {
                    if (LeftThumbMargin.Left + Thumb1.Width <= Track.Width - RightThumbMargin.Right - Thumb2.Width / 2)
                        LeftThumbMargin = new Thickness(LeftThumbMargin.Left + _centerSliderPoint.X - Thumb1.Width / 2,
                            0, 0, 0);
                    RightThumbMargin = RightThumbMargin.Right <= 0
                        ? new Thickness(0)
                        : new Thickness(0, 0, RightThumbMargin.Right - _centerSliderPoint.X + Thumb2.Width / 2, 0);
                }
                else if (_centerSliderPoint.X < 10)
                {
                    if (LeftThumbMargin.Left >= 0)
                        LeftThumbMargin = new Thickness(LeftThumbMargin.Left + _centerSliderPoint.X - Thumb1.Width / 2,
                            0, 0, 0);
                    if (RightThumbMargin.Right + Thumb2.Width <= Track.Width - LeftThumbMargin.Left - Thumb1.Width / 2)
                        RightThumbMargin = new Thickness(0, 0,
                            RightThumbMargin.Right - _centerSliderPoint.X + Thumb2.Width / 2, 0);
                }

                if (LeftThumbMargin.Left < 0) LeftThumbMargin = new Thickness(0);
            }

            var leftMiddle = Maximum - Minimum;
            var leftPercent = leftMiddle * LeftThumbMargin.Left / Track.Width;
            LeftValue = Math.Round(leftPercent + Minimum);

            var rightMiddle = Maximum - Minimum;
            var rightPercent = rightMiddle * RightThumbMargin.Right / Track.Width;
            RightValue = Math.Round(Maximum - rightPercent);

            if (LeftThumbMargin.Left + RightThumbMargin.Right > Width * .8)
            {
                _centerSliderPressed = false;
                CenterThumbVisibility = Visibility.Collapsed;
            }
            else CenterThumbVisibility = Visibility.Visible;

            CenterThumb.Margin = new Thickness(LeftThumbMargin.Left, 0, RightThumbMargin.Right, 0);
            CenterMargin = new Thickness(LeftThumbMargin.Left + Thumb1.Width / 2, 0,
                RightThumbMargin.Right + Thumb2.Width / 2, 0);
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

        private void RangeSlider_OnMouseLeave(object sender, MouseEventArgs e)
        {
            _leftSliderPressed = false;
            _rightSliderPressed = false;
            _centerSliderPressed = false;
        }

        #endregion
    }
}