using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Junckers_el
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        public Test()
        {
            InitializeComponent();

            var assembly = typeof(Test);
            iconImagessolationsMeggning.Source = ImageSource.FromResource("Junckers_el.Assets.Isolationstest.png", assembly);
            iconImagesRcdtest.Source = ImageSource.FromResource("Junckers_el.Assets.Rcdtest.png", assembly);
            iconImagesSuppUdligning.Source = ImageSource.FromResource("Junckers_el.Assets.SuppUdligning.png", assembly);



        }
    }
}