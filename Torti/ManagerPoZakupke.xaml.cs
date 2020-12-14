using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для ManagerPoZakupke.xaml
    /// </summary>
    public partial class ManagerPoZakupke : Window
    {
        public ManagerPoZakupke()
        {
            InitializeComponent();
        }

        private void UkrasheniyaClick(object sender, RoutedEventArgs e)
        {
            DataBase.Visibility = Visibility.Visible;
            TortEntities baza = new TortEntities();
            baza.Tort_decoration.Load();
            var Ukrashenie = from ukr in baza.Tort_decoration
                             select new { ukr.Arctikul, ukr.Name, ukr.Edinitsa_izmereniya, ukr.Main_postavshik, ukr.Amount, ukr.Type, ukr.Price };
            DataBase.ItemsSource = Ukrashenie.ToList();
        }

        private void IngredientyClick(object sender, RoutedEventArgs e)
        {
            DataBase.Visibility = Visibility.Visible;
            TortEntities baza = new TortEntities();
            baza.Ingredienty.Load();

            var Ingredients = from ing in baza.Ingredienty select new {ing.Arctikul, ing.Type, ing.Price, ing.Main_postavshik, ing.GOST, ing.Characteristic };
            DataBase.ItemsSource = Ingredients.ToList();
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void DelUkrClick(object sender, RoutedEventArgs e)
        {
            DeleteUkrMan delukr = new DeleteUkrMan();
            delukr.Show();
            Close();
        }

        private void DelIngClick(object sender, RoutedEventArgs e)
        {
            DeleteIngMan deling = new DeleteIngMan();
            deling.Show();
            Close();
        }
    }
}
