using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace Junckers_el
{
    class KabelListViewModel
    {

        public ObservableCollection<Kabel> Kabler { get; set; }
        public string KabelName { get; set; }
     


        public KabelListViewModel()
        {




            Kabler = new ObservableCollection<Kabel>();
            {

                Kabler.Add(new Kabel(1, "400/230V(AC):", "Sort", "lyseblå"));
                Kabler.Add(new Kabel(2, "Svagstrøm 24V(AC):", "Rød", "lysegrå"));
                Kabler.Add(new Kabel(3, "Svagstrøm 24V(DC):", "Orange", "Grå"));
                Kabler.Add(new Kabel(4, "Fremmed styrspænding:", "Orange", "Grå"));
                Kabler.Add(new Kabel(5, "Sikkerhedskredse/Nødstop:", "Hvid", "Hvid"));
                Kabler.Add(new Kabel(6, "Egensikkekreds(EX):", "Mørkeblå", "Mørkeblå"));
                Kabler.Add(new Kabel(7, "PE:", "Grøngul", "Grøngul"));




                //"400V/230V(AC):", "Sort", "Lyseblå",
                //"Svagstrøm 24V(AC):", "Rød", "Lysegrå",
                //"Svagstrøm 24V(DC):", "Orange", "grå",
                //"Fremmed styrspænding:", "Brun", "Brun",
                //"Analog signaler:", "Violet", "Violet",
                //"Sikkerhedskredse/Nødstop:", "Hvid", "Hvid",
                //"Egensikkekreds(EX):", "Mørkeblå", "Mørkeblå",
                //"PE:", "Gulgrøn", "Gulgrøn",
            }





            //    //string[] arrKabler = new string[] { "400V/230V(AC)Fase", "Svagstrøm 24V(AC)", "Svagstrøm 24V(DC)", "Fremmed styrspænding", "Analog signaler", "Sikkerhedskredse/Nødstop", "Egensikkekreds(EX)", "PE" };

            //    //kabler = arrKabler;


            //}



            //<!--<ListView.ItemsSource >

            //        <x:Array Type = "{x:Type x:String}" >
            //                < x:String>400V/230V(AC)Fase/+ Sort: Null/-: Lyseblå</x:String>
            //                <x:String>Svagstrøm 24V(AC) Fase/+: Rød Null/-: Lysegrå</x:String>
            //                <x:String>Svagstrøm 24V(DC) Fase/+ Orange Null/-: Grå</x:String>
            //                <x:String>Fremmed styrspænding Fase/+ Brun: Null/-: Brun</x:String>
            //                <x:String>Analog signaler Fase/+ Violet: Null/-: Violet</x:String>
            //                <x:String>Sikkerhedskredse/Nødstop Fase/+ Hvid: Null/-: Hvid</x:String>
            //                <x:String>Egensikkekreds(EX) Fase/+ Mørkeblå: Null/-: Mørkeblå</x:String>
            //                <x:String>PE: Grøn/Gul</x:String>
            //            </x:Array>

            //    </ListView.ItemsSource>-->


        }
    }
}
