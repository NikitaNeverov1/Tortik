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
using System.Data.Entity.Validation;

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для DeleteUkrasheniya.xaml
    /// </summary>
    public partial class DeleteUkrasheniya : Window
    {
        public DeleteUkrasheniya()
        {
            InitializeComponent();
        }

        private void Arcticul_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        } //Ввод только для чисел

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (Arcticul.Text == "")
            {
                MessageBox.Show("Введите арктикул!");
            } //Проверка на ввод арктикула
            else
            {
                String Arct = Arcticul.Text;
                TortEntities baza = new TortEntities();
                baza.Tort_decoration.Load();
                var DelArc = baza.Tort_decoration
                    .Where(d => d.Arctikul == Arct)
                    .FirstOrDefault(); //Подключение к БД

                if (DelArc == null)
                {
                    MessageBox.Show("Украшений с таким арктикулом не найдено!");
                } //Проверка на наличие арктикула в бд

                if (DelArc != null && Arcticul.Text != "")
                {
                    MessageBoxResult confirm = MessageBox.Show("Вы дествительно хотите удалить?", "Удаление", MessageBoxButton.YesNo);
                    if (confirm == MessageBoxResult.Yes)
                    {
                        baza.Tort_decoration.Remove(DelArc);
                        baza.SaveChanges();
                        MessageBox.Show("Данные сохранены!");
                    }// Удаление данных из таблицы, если пользователь нажал "Yes"
                }
            }
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }//Выход в главное меню

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Direсtor dir = new Direсtor();
            dir.Show();
            Close();
        }//Выход в меню директора
    }
}
