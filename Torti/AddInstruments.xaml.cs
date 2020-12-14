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
    /// Логика взаимодействия для AddInstruments.xaml
    /// </summary>
    public partial class AddInstruments : Window
    {
        public AddInstruments()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (NameInstr.Text == "" || Opisanie.Text == "" ||
                TypeInstr.Text == "" || StepIsnos.Text == "" ||
                Postavshik.Text == "" || Date.Text == "" || Kolvo.Text == "")
            {
                MessageBox.Show("Обязательно заполните каждое поле!");
            } //Проверка на заполнение полей
            else
            {
                TortEntities baza = new TortEntities();
                baza.Instruments.Load();

                var InInstr = baza.Instruments
               .Where(u => u.Name == NameInstr.Text)
               .FirstOrDefault();

                if ((InInstr == null) && NameInstr.Text != "" || Opisanie.Text != "" ||
                TypeInstr.Text != "" || StepIsnos.Text != "" ||
                Postavshik.Text != "" || Date.Text != "" || Kolvo.Text != "")
                {
                    string InNameInstr = NameInstr.Text;
                    string InOpisanie = Opisanie.Text;
                    string InTypeInstr = TypeInstr.Text;
                    string InStepIsnos = StepIsnos.Text;
                    string InPostavshik = Postavshik.Text;
                    string InDate = Date.Text;
                    string InKolvo = Kolvo.Text;

                    InInstr = new Instruments();

                    InInstr.Name = InNameInstr;
                    InInstr.Description = InOpisanie;
                    InInstr.Type = InTypeInstr;
                    InInstr.Stepen_Iznosa = InStepIsnos;
                    InInstr.Postavshik = InPostavshik;
                    InInstr.Date = InDate;
                    InInstr.Amount = InKolvo;

                    baza.Instruments.Add(InInstr);
                    baza.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!");
                }
            }
        }

        private void NameInstr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NameInstr.Clear();
        }
        private void Opisanie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Opisanie.Clear();
        }

        private void TypeInstr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TypeInstr.Clear();
        }
        private void StepIsnos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StepIsnos.Clear();
        }
        private void Postavshik_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Postavshik.Clear();
        }

        private void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = new DatePicker();
            datePicker.DisplayDateStart = new DateTime(2012, 1, 1);
            datePicker.DisplayDateEnd = new DateTime(2020, 12, 31);
            datePicker.SelectedDate = new DateTime(2020, 9, 16);
            datePicker.SelectedDateFormat = DatePickerFormat.Long;
            datePicker.FirstDayOfWeek = DayOfWeek.Monday;
        }
        private void Kolvo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Kolvo.Clear();
        }

        private void OutDirector_Click(object sender, RoutedEventArgs e)
        {
            Direсtor direc = new Direсtor();
            direc.Show();
            Close();
        }

        private void OutMainClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
