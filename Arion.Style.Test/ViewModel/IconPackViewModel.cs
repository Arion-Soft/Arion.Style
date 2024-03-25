using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using Arion.Style.Controls;
using Arion.Style.Theme.Extensions;
using Arion.Theme.Test.Models;
using Arion.Theme.Test.ViewModel.Base;

namespace Arion.Theme.Test.ViewModel
{
    public class IconPackViewModel : BaseViewModel
    {
        private ObservableCollection<EIcons> _icons;

        public ObservableCollection<EIcons> Icons
        {
            get => _icons;
            set => SetField(ref _icons, value);
        }

        private string _search;

        public string Search
        {
            get => _search;
            set
            {
                SetField(ref _search, value);
                LoadIcons(Search);
            }
        }

        public Dictionary<EIcons, string> Kinds2;

        public IconPackViewModel()
        {
            Icons = new ObservableCollection<EIcons>();
            Kinds2 = IconLibrary.IconsDictionary;
            
            LoadIcons();
            
            Search = "";
        }

        private void LoadIcons(string searchText = "")
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                for (var i = 0; i < 170; i++)
                {
                    Icons.Add(Kinds2.Keys.ToList()[i]);
                }
            }
            else
            {
                Icons.Clear();
                var iconsLibrary = Kinds2.Where(x => x.Key.ToString().ToLower().Contains(searchText.ToLower())).ToList();
            
                var max = iconsLibrary.Count > 170 ? 170 : iconsLibrary.Count;
            
                for (int i = 0; i < max; i++)
                {
                    Icons.Add(iconsLibrary[i].Key);
                }
            }
        }
    }
}