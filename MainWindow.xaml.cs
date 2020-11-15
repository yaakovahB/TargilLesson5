//Yaakovah Bacharach 340912518
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

namespace TargilCitahLesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// This program goes when the green button is clicked, shows a "breaks" sign and hides the warning sign when the red button is pressed
    /// shows the warning sign and either speeds up or slows down (this is random) when the yellow button is clicked
    /// </summary>
    public partial class MainWindow : Window
    {
        double positionLeft = 299.216;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRedLight_Click(object sender, RoutedEventArgs e)
        {
            warningSign.Visibility = Visibility.Hidden;
            MessageBox.Show("BRAKES!");
        }
        private void ButtonGreenLight_Click(object sender, RoutedEventArgs e)
        {
            car.Margin = new Thickness(positionLeft-=100, 248, 0, 0);
        }

        private void ButtonYellowLight_Click(object sender, RoutedEventArgs e)
        {
            warningSign.Visibility = Visibility.Visible;
            MessageBox.Show("slowing down");
            int randomNum = random.Next(1, 3);

            //randomly choses whether to speed up or slow down
            if(randomNum==1)
                car.Margin = new Thickness(positionLeft -= 50, 248, 0, 0);
            else
                car.Margin = new Thickness(positionLeft -= 200, 248, 0, 0);
        }
    }
}
