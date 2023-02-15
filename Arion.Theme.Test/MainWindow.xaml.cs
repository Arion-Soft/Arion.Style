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

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MainWindow_OnKeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}