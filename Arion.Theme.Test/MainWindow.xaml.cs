using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Arion.Style.Controls;
using Arion.Style.AttachedProperties;
using Button = Arion.Style.AttachedProperties.Button;

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
            List<Icon> icons = new List<Icon>();
            var iconsLibrary = IconLibrary.IconsDictionary.Select(x => x.Key).ToList();
            
            for (int i = 0; i < 312; i++)
            {
                icons.Add(new Icon { Kind = iconsLibrary[i]});
            }

            LvIcons.ItemsSource = icons;
            
        }

        private void TbFind_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void TbFind_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var icons = new List<Icon>();
            var iconsLibrary = IconLibrary.IconsDictionary.Where(x => x.Key.ToString().ToLower().Contains(TbFind.Text)).ToList();

            var max = iconsLibrary.Count > 256 ? 256 : iconsLibrary.Count;
            
            for (int i = 0; i < max; i++)
            {
                var item = new Icon { Kind = iconsLibrary[i].Key };
                icons.Add(item);
            }
            
            LvIcons.ItemsSource = icons;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Slider65535.SetLowerValue(3000);
            Slider65535.SetUpperValue(17000);
        }

        private void BtnProgress_OnClick(object sender, RoutedEventArgs e)
        {
            Button.SetIcon(BtnTest, EIcons.NULL);
            Button.SetProgressBarMaximum(BtnTest, 100);
            Button.SetProgressBarMinimum(BtnTest, 0);
            Button.SetProgressBarShow(BtnTest, true);
            Button.SetProgressBarType(BtnTest, ProgressBarType.Circle);
            Button.SetProgressBarValue(BtnTest, 50);
        }
    }
}