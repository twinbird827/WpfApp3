using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{
    class MainViewModel : BindableBase
    {
        public ObservableCollection<ItemViewModel> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }
        private ObservableCollection<ItemViewModel> _Items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel(){AAA="A1",BBB="B1",CCC="C1"},
                new ItemViewModel(){AAA="A2",BBB="B2",CCC="C2"},
                new ItemViewModel(){AAA="A3",BBB="B3",CCC="C3"},
                new ItemViewModel(){AAA="A4",BBB="B4",CCC="C4"},
                new ItemViewModel(){AAA="A5",BBB="B5",CCC="C5"},
            };
        }
        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("MainViewModel ListViewItem_MouseDoubleClick");
        }
    }
}
