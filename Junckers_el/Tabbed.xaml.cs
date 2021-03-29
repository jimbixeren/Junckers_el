using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.CompilerServices;

namespace Junckers_el
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
        }

        //private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        //{
        //    if (!Equals(field, newValue))
        //    {
        //        field = newValue;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //        return true;
        //    }

        //    return false;
        //}

        //private System.Collections.IEnumerable kabelstandarter;

        //public System.Collections.IEnumerable Kabelstandarter { get => kabelstandarter; set => SetProperty(ref kabelstandarter, value); }
    }
}