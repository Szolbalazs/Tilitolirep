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

namespace TilitoliFeladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] eredeti = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };
        int[] szamok = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button egyik = sender as Button;
            Button nullA = (Button)FindName("Button0");
            var felul = Math.Abs(egyik.Margin.Top - nullA.Margin.Top);
            var oldalt = Math.Abs(egyik.Margin.Left - nullA.Margin.Left);
            int EgyikFelirat = int.Parse(egyik.Content.ToString());
            int EgyikIndex = Array.IndexOf(szamok, EgyikFelirat);
            int NullIndex = Array.IndexOf(szamok, 0);
            if ((felul == 100 && oldalt == 0) || (oldalt == 100 && oldalt == 0))
            {
                var seged = egyik.Margin;
                egyik.Margin = nullA.Margin;
                nullA.Margin = seged;
                szamok[NullIndex] = szamok[EgyikFelirat];
                szamok[EgyikFelirat] = 0;
            }

        }



    }
}
