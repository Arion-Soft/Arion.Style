using System.Collections.Generic;
using System.Linq;
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
            var icons = new List<Icon>();

            foreach (var key in Icons.IconsDictionary.Select(x => x.Key))
            {
                icons.Add(new Icon { Kind = key });
            }

            LvIcons.ItemsSource = icons;
        }
    }
}