using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{
    class ItemViewModel : BindableBase
    {
        public string AAA
        {
            get { return _AAA; }
            set { SetProperty(ref _AAA, value); }
        }
        private string _AAA = null;

        public string BBB
        {
            get { return _BBB; }
            set { SetProperty(ref _BBB, value); }
        }
        private string _BBB = null;

        public string CCC
        {
            get { return _CCC; }
            set { SetProperty(ref _CCC, value); }
        }
        private string _CCC = null;

        public ICommand Command
        {
            get
            {
                return _Command = _Command ?? new RelayCommand(
                    _ =>
                    {
                        Console.WriteLine("ItemViewModel Command");
                    });
            }
        }
        public ICommand _Command;
    }
}
