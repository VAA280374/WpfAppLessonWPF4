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

namespace WpfAppLessonWPF4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEuro.Text);
            double sum = Convert.ToDouble(sumEuro.Text);
            double res = rate * sum;
            resSumEuro.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateGriv.Text);
            double sum = Convert.ToDouble(sumGriv.Text);
            double res = rate * sum;
            resSumGriv.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateArm.Text);
            double sum = Convert.ToDouble(sumArm.Text);
            double res = rate * sum;
            resSumArm.Text = res.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateA.Text);
            double sum = Convert.ToDouble(sumA.Text);
            double res = rate * sum;
            resA.Text = res.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateM.Text);
            double sum = Convert.ToDouble(sumM.Text);
            double res = rate * sum;
            resM.Text = res.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateMm.Text);
            double sum = Convert.ToDouble(sumMm.Text);
            double res = rate * sum;
            resMm.Text = res.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateV.Text);
            double sum = Convert.ToDouble(sumV.Text);
            double res = rate * sum;
            resV.Text = res.ToString();
        }
    }
}
