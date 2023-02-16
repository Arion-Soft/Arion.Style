using System.Windows;
using System.Windows.Input;
using Arion.Theme.Controls;

namespace Arion.Theme.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
        }
        
        private bool altPressed;
        private bool keyUp;
        private bool keyDown;
        private bool keyLeft;
        private bool keyRight;
        
        private void MainWindow_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightAlt)
            {
                altPressed = true; CbxAlt.IsChecked = true;
            }

            if (e.Key == Key.Up)
            {
                keyUp = true; CbxUp.IsChecked = true;
            }

            if (e.Key == Key.Down)
            {
                keyDown = true; CbxDown.IsChecked = true;
            }

            if (e.Key == Key.Left)
            {
                keyLeft = true; CbxLeft.IsChecked = true;
            }

            if (e.Key == Key.Right)
            {
                keyRight = true; CbxRight.IsChecked = true;
            }
        }

        private void MainWindow_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightAlt)
            {
                altPressed = false; CbxAlt.IsChecked = false;
            }

            if (e.Key == Key.Up)
            {
                keyUp = false; CbxUp.IsChecked = false;
            }

            if (e.Key == Key.Down)
            {
                keyDown = false; CbxDown.IsChecked = false;
            }

            if (e.Key == Key.Left)
            {
                keyLeft = false; CbxLeft.IsChecked = false;
            }

            if (e.Key == Key.Right)
            {
                keyRight = false; CbxRight.IsChecked = false;
            }
        }

        private void UIElement_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightAlt)
            {
                altPressed = true; CbxAlt.IsChecked = true;
            }

            if (e.Key == Key.Up)
            {
                keyUp = true; CbxUp.IsChecked = true;
            }

            if (e.Key == Key.Down)
            {
                keyDown = true; CbxDown.IsChecked = true;
            }

            if (e.Key == Key.Left)
            {
                keyLeft = true; CbxLeft.IsChecked = true;
            }

            if (e.Key == Key.Right)
            {
                keyRight = true; CbxRight.IsChecked = true;
            }
        }

        private void UIElement_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.RightAlt)
            {
                altPressed = false; CbxAlt.IsChecked = false;
            }

            if (e.Key == Key.Up)
            {
                keyUp = false; CbxUp.IsChecked = false;
            }

            if (e.Key == Key.Down)
            {
                keyDown = false; CbxDown.IsChecked = false;
            }

            if (e.Key == Key.Left)
            {
                keyLeft = false; CbxLeft.IsChecked = false;
            }

            if (e.Key == Key.Right)
            {
                keyRight = false; CbxRight.IsChecked = false;
            }
        }
    }
}