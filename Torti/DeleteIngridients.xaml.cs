using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для DeleteIngridients.xaml
    /// </summary>
    public partial class DeleteIngridients : Window
    {
        public DeleteIngridients()
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
                int Arct = Convert.ToInt32(Arcticul.Text);
                TortEntities baza = new TortEntities();
                baza.Ingredienty.Load();
                var DelArct = baza.Ingredienty
                    .Where(d => d.Arctikul == Arct)
                    .FirstOrDefault(); //Подключение к БД

                if (DelArct == null)
                {
                    MessageBox.Show("Ингридиентов в таким арктикулом не найдено!");
                }//Проверка на наличие арктикула в бд

                if (DelArct != null && Arcticul.Text != "")
                {
                    MessageBoxResult confirm = MessageBox.Show("Вы дествительно хотите удалить?", "Удаление", MessageBoxButton.YesNo);
                    if (confirm == MessageBoxResult.Yes)
                    {
                        baza.Ingredienty.Remove(DelArct);
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
