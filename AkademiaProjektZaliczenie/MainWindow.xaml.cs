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

        Place Place = new Place();
        Italy Italy = new Italy();
        Spain Spain = new Spain();
        Mexico Mexico = new Mexico();
        Maldives Maldives = new Maldives();
        Hawaii Hawaii = new Hawaii();
        Australia Australia = new Australia();
        France France = new France();
        Tanzania Tanzania = new Tanzania();
        Tonga Tonga = new Tonga();
        Vietnam Vietnam = new Vietnam();
        Madagascar Madagascar = new Madagascar();
        Austria Austria = new Austria();
        India India = new India();
        Mongolia Mongolia = new Mongolia();
        Indonesia Indonesia = new Indonesia();
        Nepal Nepal = new Nepal();
        Somalia Somalia = new Somalia();
        Chile Chile = new Chile();
        Italy_ValDiSole Italy_ValDiSole = new Italy_ValDiSole();
        Switzerland Switzerland = new Switzerland();
        Chile_Andy Chile_Andy = new Chile_Andy();
        Antarctica Antarctica = new Antarctica();
        Nepal_Mountains Nepal_Mountains = new Nepal_Mountains();
        Kilimanjaro Kilimanjaro = new Kilimanjaro();
        Croatia Croatia = new Croatia();
        Morocco Morocco = new Morocco();
        Portugal_Madera Portugal_Madera = new Portugal_Madera();
        Dominican_Republic Dominican_Republic = new Dominican_Republic();
        Cuba Cuba = new Cuba();
        Zanzibar Zanzibar = new Zanzibar();
        Knyszyn_Forest Knyszyn_Forest = new Knyszyn_Forest();
        Tazi_Island Tazi_Island = new Tazi_Island();
        Gambolo_Island Gambolo_Island = new Gambolo_Island();
        Amparo_Island Amparo_Island = new Amparo_Island();
        Devils_Island Devils_Island = new Devils_Island();
        Caribbean_Survival Caribbean_Survival = new Caribbean_Survival();

        ResultValues OptionResult = new ResultValues();

        public MainWindow()
        {
            InitializeComponent();
            listofoptions = new ObservableCollection<ResultValues>();
            this.ListView.ItemsSource = listofoptions;
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {

            Option = this.Options.Text;
            Price = int.Parse(this.priceoptions.Text);
            Days = int.Parse(this.daysnumber.Text);

            pricePerDay = Price / Days;


            if (pricePerDay <= 500)
            {
                switch (Option)
                {
                    case "Sun":
                        
                            ItalyExecutive();
                            
                        
                        break;
                    case "Adventure":
                        SpainExecutive();
                        ;
                        break;
                    case "Adrenaline":
                        ;
                        break;
                    case "Snow": Italy_ValDiSoleExecutive();
                        ;
                        break;
                    case "Lazy":  CroatiaExecutive();
                            MoroccoExecutive();
                            Portugal_MaderaExecutive();
                     
                        
                        break;
                    case "Survival": Knyszyn_ForestExecutive();
                        Tazi_IslandExecutive();
                        Gambolo_IslandExecutive();        
                        break;
                }
            }
            else if (pricePerDay <= 1000)
            {
                switch (Option)
                {
                    case "Sun":AustraliaExecutive();
                        break;
                    case "Adventure": FranceExecutive();
                        
                        MadagascarExecutive();
                        AustriaExecutive();
                        break;
                    case "Adrenaline":IndiaExecutive();
                        
                        NepalExecutive();
                        ;
                        break;
                    case "Snow":Chile_AndyExecutive();
                        Nepal_MountainsExecutive();
                        ;
                        break;
                    case "Lazy":Dominican_RepublicExecutive();
                        CubaExecutive();
                        ZanzibarExecutive();
                        ;
                        break;
                    case "Survival":Amparo_IslandExecutive();
                        ;
                        break;
                }

            }
            else if (pricePerDay <= 2000)
            {
                switch (Option)
                {
                    case "Sun":MexicoExecutive();
                        HawaiiExecutive();
                        MaldivesExecutive();
                        
                        break;
                    case "Adventure":TanzaniaExecutive();
                        VietnamExecutive();
                        
                        break;
                    case "Adrenaline":IndonesiaExecutive();
                        MongoliaExecutive();
                        SomaliaExecutive();
                        break;
                    case "Snow":SwitzerlandExecutive();
                        
                        break;
                    case "Lazy":;
                        
                        break;
                    case "Survival":Devils_IslandExecutive();
                        Caribbean_SurvivalExecutive();
                        
                        break;
                }

            }
            else if (pricePerDay <= 5000)
            {
                switch (Option)
                {
                    case "Sun":
                        ;
                        break;
                    case "Adventure":
                        ;
                        break;
                    case "Adrenaline":
                        ;
                        break;
                    case "Snow":
                        ;
                        break;
                    case "Lazy":
                        ;
                        break;
                    case "Survival":
                        ;
                        break;
                }
            }
            else if (pricePerDay <= 10000)
            {
                switch (Option)
                {
                    case "Sun":
                        ;
                        break;
                    case "Adventure":
                        ;
                        break;
                    case "Adrenaline":
                        ;
                        break;
                    case "Snow":
                        ;
                        break;
                    case "Lazy":
                        ;
                        break;
                    case "Survival":
                        ;
                        break;
                }
            }
            else if (pricePerDay <= 15000)
            {
                switch (Option)
                {
                    case "Sun":
                        ;
                        break;
                    case "Adventure":
                        ;
                        break;
                    case "Adrenaline":
                        ;
                        break;
                    case "Snow":
                        ;
                        break;
                    case "Lazy":
                        ;
                        break;
                    case "Survival":
                        ;
                        break;
                }
            }
        }
        private void ItalyExecutive()
        {
            OptionResult.Place = "Włochy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Italy.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void SpainExecutive()
        {
            OptionResult.Place = "Hiszpania";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Spain.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void MexicoExecutive()
        {
            OptionResult.Place = "Meksyk";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Mexico.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void MaldivesExecutive()
        {
            OptionResult.Place = "Malediwy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Maldives.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void HawaiiExecutive()
        {
            OptionResult.Place = "Hawaje";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Hawaii.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void AustraliaExecutive()
        {
            OptionResult.Place = "Australia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Australia.setValues() * Days;
            OptionResult.Entertainment = "Opalanie, Zwiedzanie";
            listofoptions.Add(OptionResult);
        }
        private void FranceExecutive()
        {
            OptionResult.Place = "Francja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = France.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void TanzaniaExecutive()
        {
            OptionResult.Place = "Tanzania";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tanzania.setValues() * Days;
            OptionResult.Entertainment = "Samotne zwiedzanie afrykańskiej dzungli";
            listofoptions.Add(OptionResult);
        }
        private void TongaExecutive()
        {
            OptionResult.Place = "Tonga";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tonga.setValues() * Days;
            OptionResult.Entertainment = "Pływanie z wielorybami";
            listofoptions.Add(OptionResult);
        }
        private void VietnamExecutive()
        {
            OptionResult.Place = "Wietnam";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Vietnam.setValues() * Days;
            OptionResult.Entertainment = "Nurkowanie, kolarstwo górskie";
            listofoptions.Add(OptionResult);
        }
        private void MadagascarExecutive()
        {
            OptionResult.Place = "Madagaskar";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Madagascar.setValues() * Days;
            OptionResult.Entertainment = "Oglądanie rafy koralowej";
            listofoptions.Add(OptionResult);
        }
        private void AustriaExecutive()
        {
            OptionResult.Place = "Austria";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Austria.setValues() * Days;
            OptionResult.Entertainment = "Wspinaczka, kolarstwo górskie";
            listofoptions.Add(OptionResult);
        }
        private void IndiaExecutive()
        {
            OptionResult.Place = "Indie";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = India.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void MongoliaExecutive()
        {
            OptionResult.Place = "Mongolia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Mongolia.setValues() * Days;
            OptionResult.Entertainment = "Rajd motocyklowy po pustyni Gobi";
            listofoptions.Add(OptionResult);
        }
        private void IndonesiaExecutive()
        {
            OptionResult.Place = "Indonezja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Indonesia.setValues() * Days;
            OptionResult.Entertainment = "Spływy kajakowe";
            listofoptions.Add(OptionResult);
        }
        private void NepalExecutive()
        {
            OptionResult.Place = "Nepal";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Nepal.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void SomaliaExecutive()
        {
            OptionResult.Place = "Somalia";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Somalia.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void ChileExecutive()
        {
            OptionResult.Place = "Chile";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Chile.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Italy_ValDiSoleExecutive()
        {
            OptionResult.Place = "Włochy - Val di Sole";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Italy_ValDiSole.setValues() * Days;
            OptionResult.Entertainment = "Narciarstwo";
            listofoptions.Add(OptionResult);
        }
        private void SwitzerlandExecutive()
        {
            OptionResult.Place = "Szwajcaria";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Switzerland.setValues() * Days;
            OptionResult.Entertainment = "Maraton narciarski";
            listofoptions.Add(OptionResult);
        }
        private void Chile_AndyExecutive()
        {
            OptionResult.Place = "Chile - Andy";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Chile_Andy.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void AntarcticaExecutive()
        {
            OptionResult.Place = "Antarktyda";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Antarctica.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Nepal_MountainsExecutive()
        {
            OptionResult.Place = "Nepal - Góry";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Nepal_Mountains.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void KilimanjaroExecutive()
        {
            OptionResult.Place = "Kilimandżaro";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Kilimanjaro.setValues() * Days;
            OptionResult.Entertainment = "Wspinaczka";
            listofoptions.Add(OptionResult);
        }
        private void CroatiaExecutive()
        {
            OptionResult.Place = "Chorwacja";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Croatia.setValues() * Days;
            OptionResult.Entertainment = "Piękne widoki";
            listofoptions.Add(OptionResult);
        }
        private void MoroccoExecutive()
        {
            OptionResult.Place = "Maroko";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Morocco.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Portugal_MaderaExecutive()
        {
            OptionResult.Place = "Portugalia - Madera";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Portugal_Madera.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Dominican_RepublicExecutive()
        {
            OptionResult.Place = "Dominikana";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Dominican_Republic.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void CubaExecutive()
        {
            OptionResult.Place = "Kuba";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Cuba.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void ZanzibarExecutive()
        {
            OptionResult.Place = "Zanzibar";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Zanzibar.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Knyszyn_ForestExecutive()
        {
            OptionResult.Place = "Puszcza Knyszyńska";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Knyszyn_Forest.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Tazi_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Tazi";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Tazi_Island.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Gambolo_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Gambolo";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Gambolo_Island.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Amparo_IslandExecutive()
        {
            OptionResult.Place = "Wyspa Amparo";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Amparo_Island.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Devils_IslandExecutive()
        {
            OptionResult.Place = "Diabelska Wyspa";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Devils_Island.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
        private void Caribbean_SurvivalExecutive()
        {
            OptionResult.Place = "Karaiby";
            OptionResult.SelectedOption = Option;
            OptionResult.FinalPrice = Caribbean_Survival.setValues() * Days;
            OptionResult.Entertainment = "";
            listofoptions.Add(OptionResult);
        }
    }
}
