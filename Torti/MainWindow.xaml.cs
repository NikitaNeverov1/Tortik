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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn_click(object sender, RoutedEventArgs e)
        {
            string UserLogin = txtLogin.Text;
            string UserPass = txtPassword.Password;
            TortEntities baza = new TortEntities();
            baza.Polzovatel.Load();
            var login = baza.Polzovatel
                .Where(u => u.Login == UserLogin && u.Password == UserPass)
                .FirstOrDefault();

            if (login == null)
            {
                MessageBox.Show("Логин или пароль введены неверно!");
            }

            if (login != null)
            {
                if (login != null && login.Role == "Менеджер по продажам")
                {
                    ManagerPoRabote manager = new ManagerPoRabote();
                    manager.Show();
                    Close();
                }

                if (login != null && login.Role == "Директор")
                {
                    Direсtor dir = new Direсtor();
                    dir.Show();
                    Close();
                }

                if (login != null && login.Role == "Мастер")
                {
                    Master mast = new Master();
                    mast.Show();
                    Close();
                }

                if (login != null && login.Role == "Заказчик")
                {
                    Zakazchik zakaz = new Zakazchik();
                    zakaz.Show();
                    Close();
                }

                if (login != null && login.Role == "Менеджер по закупкам")
                {
                    ManagerPoZakupke manzak = new ManagerPoZakupke();
                    manzak.Show();
                    Close();
                }
                if ((login != null) && login.Role == "")
                {
                    Zakazchik zakazchik = new Zakazchik();
                    zakazchik.Show();
                    Close();
                }
            }
        }

        private void Registr_click(object sender, RoutedEventArgs e)
        {
            Registr reg = new Registr();
            reg.Show();
            Close();
        }
    }
}
