using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Arion.Style.Controls;

namespace Arion.Theme.Test.Views
{
    public partial class IconPack : UserControl
    {
        public IconPack()
        {
            InitializeComponent();
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

        private void IconPack_OnLoaded(object sender, RoutedEventArgs e)
        {
            List<Icon> icons = new List<Icon>();
            var iconsLibrary = IconLibrary.IconsDictionary.Select(x => x.Key).ToList();

            for (int i = 0; i < 312; i++)
            {
                icons.Add(new Icon { Kind = iconsLibrary[i] });
            }

            LvIcons.ItemsSource = icons;
        }
    }
}