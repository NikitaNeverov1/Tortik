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
    /// Логика взаимодействия для Reistr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            string UserLastName = LastName.Text;
            string UserFirstName = FirstName.Text;
            string UserLogin = Login.Text;
            string UserPassword = Password.Text;

            TortEntities baza = new TortEntities();
            baza.Polzovatel.Load(); //Подключение к базе данных
            var polz = baza.Polzovatel
                .Where(u => u.Login == UserLogin)
                .FirstOrDefault();

            if (polz != null)
            {
                MessageBox.Show("Этот логин уже занят.");
            }  //Проверка на наличие существующего пользователя
            
            if (UserLastName == "" || UserFirstName == "" || UserLogin == "" || UserPassword == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }  //Проверка на заполнение полей
            
            else
            {
                if (Password.Text == Login.Text)
                {
                    MessageBox.Show("Ваш пароль не должен совпадать с введеным логином.");
                } // Проверка совпадения логина и пароля
                else
                {
                    if (UserPassword.Length < 5 && UserPassword.Length > 20)
                    {
                        MessageBox.Show("Пароль должен содержать от 5 до 20 символов.");
                    } // Проверка на условия количества символов в пароле.
                    else
                    {
                        if (Regex.IsMatch(UserPassword, @"[А-ЯЁ]"))
                        {
                            MessageBox.Show("Пароль должен не должен содержать кириллицу.");
                        } // Проверка на кириллицу в пароле.
                        else
                        {
                            if ((polz == null) && UserLastName != "" && UserFirstName != "" && UserLogin != "" && UserPassword != ""
                            && Regex.IsMatch(UserPassword, @"[a-z]") && Regex.IsMatch(UserPassword, @"[A-Z]"))
                            {
                                polz = new Polzovatel();
                                polz.Last_name = UserLastName;
                                polz.First_name = UserFirstName;
                                polz.Login = UserLogin;
                                polz.Password = UserPassword;
                                polz.Role = "Заказчик";
                                baza.Polzovatel.Add(polz);
                                baza.SaveChanges();
                                MessageBox.Show("Регистрация завершена успешно.");
                            } // Сохранение нового пользователя.
                            else
                            {
                                MessageBox.Show("Пароль должен содержать заглавные и строчные буквы");
                            } // Вывод о безналичии заглавной или строчной буквы.
                        }
                    }
                }
            }
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
