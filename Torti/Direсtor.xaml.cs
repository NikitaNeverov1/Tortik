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
using System.Data;

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для Direсtor.xaml
    /// </summary>
    public partial class Direсtor : Window
    {
        public Direсtor()
        {
            InitializeComponent();
        }

        private void OutInstr_Click(object sender, RoutedEventArgs e)
        {
            BasaTable.Visibility = Visibility.Visible;
            TortEntities baza = new TortEntities();
            baza.Instruments.Load();
            var query = from instr in baza.Instruments
                        select new { instr.Name, instr.Type, instr.Date, instr.Amount };
            BasaTable.ItemsSource = query.ToList();
        } //Вывод списка инструментов в таблицу

        private void AddInstr_Click(object sender, RoutedEventArgs e)
        {
            AddInstruments addInstr = new AddInstruments();
            addInstr.Show();
            Close();
        }

        private void UkrTortClick(object sender, RoutedEventArgs e)
        {
            BasaTable.Visibility = Visibility.Visible;
            TortEntities baza = new TortEntities();
            baza.Tort_decoration.Load();
            var Ukrasheniya = from tortdec in baza.Tort_decoration
                              select new { tortdec.Arctikul, tortdec.Name, tortdec.Edinitsa_izmereniya, tortdec.Amount, tortdec.Main_postavshik, tortdec.Type, tortdec.Price };
            BasaTable.ItemsSource = Ukrasheniya.ToList();
        }

        private void IngridClick(object sender, RoutedEventArgs e)
        {
            BasaTable.Visibility = Visibility.Visible;
            TortEntities baza = new TortEntities();
            baza.Ingredienty.Load();

            var Ingredients = from ingr in baza.Ingredienty select new {ingr.Arctikul, ingr.Type, ingr.Price, ingr.Main_postavshik, ingr.GOST, ingr.Characteristic };
            BasaTable.ItemsSource = Ingredients.ToList();
        }

        private void DelUkrClick(object sender, RoutedEventArgs e)
        {
            DeleteUkrasheniya delukr = new DeleteUkrasheniya();
            delukr.Show();
            Close();
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        } //Выход в главное меню

        private void DelIngClick(object sender, RoutedEventArgs e)
        {
            DeleteIngridients deling = new DeleteIngridients();
            deling.Show();
            Close();
        }
    }
}
