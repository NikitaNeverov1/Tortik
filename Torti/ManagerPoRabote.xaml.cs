﻿using System;
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

namespace Torti
{
    /// <summary>
    /// Логика взаимодействия для ManagerPoRabote.xaml
    /// </summary>
    public partial class ManagerPoRabote : Window
    {
        public ManagerPoRabote()
        {
            InitializeComponent();
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        } //Выход в главное меню
    }
}
