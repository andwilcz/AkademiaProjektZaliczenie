using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AkademiaProjektZaliczenie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ResultValues> listofoptions;
        public int pricePerDay;
        public string Option;
        public int Price;
        public int Days;
        enum OptionOfTrip
        {
            Sun,
            Adventure,
            Adrenaline,
            Snow,
            Lazy,
            Survival
        };

        Place Place = new Place(0);
        Place Italy = new Place(300);
        Place Spain = new Place(450);
        Place Mexico = new Place(1200);
        Place Maldives = new Place(2500);
        Place Hawaii = new Place(1100);
        Place Australia = new Place(1000);
        Place France = new Place(974);
        Place Tanzania = new Place(1050);
        Place Tonga = new Place(3870);
        Place Vietnam = new Place(1100);
        Place Madagascar = new Place(6957);
        Place Austria = new Place(740);
        Place India = new Place(880);
        Place Mongolia = new Place(1137);
        Place Indonesia = new Place(1050);
        Place Nepal = new Place(13640);
        Place Somalia = new Place(1200);
        Place Chile = new Place(2000);
        Place Italy_ValDiSole = new Place(500);
        Place Switzerland = new Place(1275);
        Place Chile_Andy = new Place(1000);
        Place Antarctica = new Place(7090);
        Place Nepal_Mountains = new Place(12886);
        Place Kilimanjaro = new Place(2010);
        Place Croatia = new Place(150);
        Place Morocco = new Place(357);
        Place Portugal_Madera = new Place(270);
        Place Dominican_Republic = new Place(571);
        Place Cuba = new Place(660);
        Place Zanzibar = new Place(3625);
        Place Knyszyn_Forest = new Place(170);
        Place Tazi_Island = new Place(6400);
        Place Gambolo_Island = new Place(3324);
        Place Amparo_Island = new Place(560);
        Place Devils_Island = new Place(1520);
        Place Caribbean_Survival = new Place(1040);

        ResultValues OptionResult = new ResultValues();

        public MainWindow()
        {
            InitializeComponent();
            listofoptions = new ObservableCollection<ResultValues>();
            this.ListView.ItemsSource = listofoptions;
        }

        
        private void search_Click(object sender, RoutedEventArgs e)
        {
           
            listofoptions.Clear();

            Option = this.Options.Text;
            Price = int.Parse(this.priceoptions.Text);
            Days = int.Parse(this.daysnumber.Text);

            pricePerDay = Price / Days;

            OptionOfTrip value = OptionOfTrip.Sun;

            if (Option == "Sun")
                value = OptionOfTrip.Sun;
            else if (Option == "Adventure")
                value = OptionOfTrip.Adventure;
            else if (Option == "Adrenaline")
                value = OptionOfTrip.Adrenaline;
            else if (Option == "Snow")
                value = OptionOfTrip.Snow;
            else if (Option == "Lazy")
                value = OptionOfTrip.Lazy;
            else if (Option == "Survival")
                value = OptionOfTrip.Survival;

            if (pricePerDay <= 500)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        ItalyExecutive();
                        break;
                    case OptionOfTrip.Adventure:
                        SpainExecutive();
                        break;
                    case OptionOfTrip.Adrenaline:
                        Default();
                        break;
                    case OptionOfTrip.Snow:
                        Italy_ValDiSoleExecutive();
                        break;
                    case OptionOfTrip.Lazy: 
                        Portugal_MaderaExecutive();
                        break;
                    case OptionOfTrip.Survival:
                        Knyszyn_ForestExecutive(); 
                        break;
                }
            }
            else if (pricePerDay <= 1000)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        AustraliaExecutive();
                        break;
                    case OptionOfTrip.Adventure:
                        FranceExecutive();
                        break;
                    case OptionOfTrip.Adrenaline:
                        IndiaExecutive();
                        break;
                    case OptionOfTrip.Snow:
                        Chile_AndyExecutive();
                        break;
                    case OptionOfTrip.Lazy:
                        Dominican_RepublicExecutive();
                        break;
                    case OptionOfTrip.Survival:
                        Amparo_IslandExecutive();
                        break;
                }
            }
            else if (pricePerDay <= 2000)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        MexicoExecutive();
                        break;
                    case OptionOfTrip.Adventure:
                        TanzaniaExecutive();
                        break;
                    case OptionOfTrip.Adrenaline:
                        IndonesiaExecutive();
                        break;
                    case OptionOfTrip.Snow:
                        SwitzerlandExecutive();
                        break;
                    case OptionOfTrip.Lazy:
                        HawaiiExecutive();
                        break;
                    case OptionOfTrip.Survival:
                        Devils_IslandExecutive();
                        break;
                }
            }
            else if (pricePerDay <= 5000)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        MaldivesExecutive();
                        break;
                    case OptionOfTrip.Adventure:
                        Default();
                        break;
                    case OptionOfTrip.Adrenaline:
                        Default();
                        break;
                    case OptionOfTrip.Snow:
                        Default();
                        break;
                    case OptionOfTrip.Lazy:
                        ZanzibarExecutive();
                        break;
                    case OptionOfTrip.Survival:
                        Gambolo_IslandExecutive();
                        break;
                }
            }
            else if (pricePerDay <= 10000)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        Default();
                        break;
                    case OptionOfTrip.Adventure:
                        MadagascarExecutive();
                        break;
                    case OptionOfTrip.Adrenaline:
                        Default();
                        break;
                    case OptionOfTrip.Snow:
                        Default();
                        break;
                    case OptionOfTrip.Lazy:
                        Default();
                        break;
                    case OptionOfTrip.Survival:
                        Tazi_IslandExecutive();  
                        break;
                }
            }
            else if (pricePerDay <= 15000)
            {
                switch (value)
                {
                    case OptionOfTrip.Sun:
                        Default();
                        break;
                    case OptionOfTrip.Adventure:
                        NepalExecutive();
                        break;
                    case OptionOfTrip.Adrenaline:
                        Default();
                        break;
                    case OptionOfTrip.Snow:
                        Nepal_MountainsExecutive();
                        break;
                    case OptionOfTrip.Lazy:
                        Default();
                        break;
                    case OptionOfTrip.Survival:
                        Default();
                        break;
                }
            }
        }
        private void ItalyExecutive()
        {
            OptionResult.Place = "Włochy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Italy.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void SpainExecutive()
        {
            OptionResult.Place = "Hiszpania";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Spain.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void MexicoExecutive()
        {
            OptionResult.Place = "Meksyk";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Mexico.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void MaldivesExecutive()
        {
            OptionResult.Place = "Malediwy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Maldives.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void HawaiiExecutive()
        {
            OptionResult.Place = "Hawaje";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Hawaii.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void AustraliaExecutive()
        {
            OptionResult.Place = "Australia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Australia.establishedPrice * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void FranceExecutive()
        {
            OptionResult.Place = "Francja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = France.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void TanzaniaExecutive()
        {
            OptionResult.Place = "Tanzania";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tanzania.establishedPrice * Days;
            OptionResult.Entertainment = "Samotne zwiedzanie afrykańskiej dzungli";
            listofoptions.Add(OptionResult);
        }
        private void TongaExecutive()
        {
            OptionResult.Place = "Tonga";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tonga.establishedPrice * Days;
            OptionResult.Entertainment = "Pływanie z wielorybami";
            listofoptions.Add(OptionResult);
        }
        private void VietnamExecutive()
        {
            OptionResult.Place = "Wietnam";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Vietnam.establishedPrice * Days;
            OptionResult.Entertainment = "Nurkowanie, kolarstwo górskie";
            listofoptions.Add(OptionResult);
        }
        private void MadagascarExecutive()
        {
            OptionResult.Place = "Madagaskar";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Madagascar.establishedPrice * Days;
            OptionResult.Entertainment = "Oglądanie rafy koralowej";
            listofoptions.Add(OptionResult);
        }
        private void AustriaExecutive()
        {
            OptionResult.Place = "Austria";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Austria.establishedPrice * Days;
            OptionResult.Entertainment = "Wspinaczka, kolarstwo górskie";
            listofoptions.Add(OptionResult);
        }
        private void IndiaExecutive()
        {
            OptionResult.Place = "Indie";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = India.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void MongoliaExecutive()
        {
            OptionResult.Place = "Mongolia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Mongolia.establishedPrice * Days;
            OptionResult.Entertainment = "Rajd motocyklowy po pustyni Gobi";
            listofoptions.Add(OptionResult);
        }
        private void IndonesiaExecutive()
        {
            OptionResult.Place = "Indonezja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Indonesia.establishedPrice * Days;
            OptionResult.Entertainment = "Spływy kajakowe";
            listofoptions.Add(OptionResult);
        }
        private void NepalExecutive()
        {
            OptionResult.Place = "Nepal";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Nepal.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void SomaliaExecutive()
        {
            OptionResult.Place = "Somalia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Somalia.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void ChileExecutive()
        {
            OptionResult.Place = "Chile";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Chile.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Italy_ValDiSoleExecutive()
        {
            OptionResult.Place = "Włochy - Val di Sole";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Italy_ValDiSole.establishedPrice * Days;
            OptionResult.Entertainment = "Narciarstwo";
            listofoptions.Add(OptionResult);
        }
        private void SwitzerlandExecutive()
        {
            OptionResult.Place = "Szwajcaria";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Switzerland.establishedPrice * Days;
            OptionResult.Entertainment = "Maraton narciarski";
            listofoptions.Add(OptionResult);
        }
        private void Chile_AndyExecutive()
        {
            OptionResult.Place = "Chile - Andy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Chile_Andy.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void AntarcticaExecutive()
        {
            OptionResult.Place = "Antarktyda";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Antarctica.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Nepal_MountainsExecutive()
        {
            OptionResult.Place = "Nepal - Góry";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Nepal_Mountains.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void KilimanjaroExecutive()
        {
            OptionResult.Place = "Kilimandżaro";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Kilimanjaro.establishedPrice * Days;
            OptionResult.Entertainment = "Wspinaczka";
            listofoptions.Add(OptionResult);
        }
        private void CroatiaExecutive()
        {
            OptionResult.Place = "Chorwacja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Croatia.establishedPrice * Days;
            OptionResult.Entertainment = "Piękne widoki";
            listofoptions.Add(OptionResult);
        }
        private void MoroccoExecutive()
        {
            OptionResult.Place = "Maroko";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Morocco.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Portugal_MaderaExecutive()
        {
            OptionResult.Place = "Portugalia - Madera";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Portugal_Madera.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Dominican_RepublicExecutive()
        {
            OptionResult.Place = "Dominikana";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Dominican_Republic.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void CubaExecutive()
        {
            OptionResult.Place = "Kuba";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Cuba.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void ZanzibarExecutive()
        {
            OptionResult.Place = "Zanzibar";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Zanzibar.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Knyszyn_ForestExecutive()
        {
            OptionResult.Place = "Puszcza Knyszyńska";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Knyszyn_Forest.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Tazi_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Tazi";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tazi_Island.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Gambolo_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Gambolo";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Gambolo_Island.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Amparo_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Amparo";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Amparo_Island.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Devils_IslandExecutive()
        {
            OptionResult.Place = "Diabelska Wyspa";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Devils_Island.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Caribbean_SurvivalExecutive()
        {
            OptionResult.Place = "Karaiby";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Caribbean_Survival.establishedPrice * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Default()
        {
            OptionResult.Place = "Brak pasujących ofert";
            OptionResult.SelectedOption = "";
            OptionResult.FinalPrice = 0;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
    }
}
