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

namespace WpfApp1
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

   

        private void Button_Chek(object sender, RoutedEventArgs e)
        {
            if (otvet1.Text == "while" || otvet1.Text == "While")
            {
                otvet1.Background = Brushes.LightGreen;
            }
            else
            {
                otvet1.Background = Brushes.LightBlue;
            }


            if (otvet2.Text == "++")
            {
                otvet2.Background = Brushes.LightGreen;
            }
            else
            {
                otvet2.Background = Brushes.LightBlue;
            }


            if (otvet3.Text == "!=")
            {
                otvet3.Background = Brushes.LightGreen;
            }
            else
            {
                otvet3.Background = Brushes.LightBlue;
            }

            if ((otvet1.Text == "while" || otvet1.Text == "While") && otvet2.Text == "++" && otvet3.Text == "!=")
            {
                Chek.Content = "Все правильно";
                Chek.Background = Brushes.Green;
            }

            else if ((otvet1.Text == "while" || otvet1.Text == "While") || otvet2.Text == "++" || otvet3.Text == "!=")
             {
                Chek.Content = "Где-то ошибка";
                Chek.Background = Brushes.Yellow;
            }


            else
            {
                Chek.Content = "Неправильно";
                Chek.Background = Brushes.Red;
            }
        }
    }
}
