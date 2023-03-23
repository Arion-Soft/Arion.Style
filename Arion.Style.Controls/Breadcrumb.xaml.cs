using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Arion.Style.Controls
{
    public partial class Breadcrumb
    {
        public Breadcrumb()
        {
            InitializeComponent();
            Items = new List<BreadcrumbItem>();
            Visualization(Items);
        }

        public List<BreadcrumbItem> Items
        {
            get => (List<BreadcrumbItem>)GetValue(ItemsProperty);
            set
            {
                SetValue(ItemsProperty, value);
                Visualization(value);
            }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(nameof(Items), typeof(List<BreadcrumbItem>), typeof(Breadcrumb), new PropertyMetadata());

        private void Visualization(List<BreadcrumbItem> items)
        {
            if (SpMain.Children.Count != 0) SpMain.Children.Clear();
            foreach (var item in items)
            {
                SpMain.Children.Add(item);
                if(items.Last() != item)
                    SpMain.Children.Add(new Icon { Kind = EIcons.ChevronRight, Fill = new SolidColorBrush(Color.FromRgb(0xB0, 0xBA, 0xBF)), Width = 10, Height = 10 });
            }
        }

        private void Breadcrumb_OnLoaded(object sender, RoutedEventArgs e)
        {
            Visualization(Items);
        }
    }
}