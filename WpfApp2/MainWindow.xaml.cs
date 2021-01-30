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

namespace WpfApp2
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

        private void btnProverka_Click(object sender, RoutedEventArgs e)
        {
            double znachenie;
            double.TryParse(tBoxVvod.Text, out znachenie);
            Num chislo = new Num(znachenie);
            bool Znachenie = chislo.DvaZnach();
            if (Znachenie)
            {lblOtvet.Content = "Число является двузначным";}
                else{lblOtvet.Content = "Число не является двузначным";}
        }
    }
}
