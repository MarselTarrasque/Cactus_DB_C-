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

namespace Lesson2_Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPagefFimoz.xaml
    /// </summary>
    public partial class MainMenuPagefFimoz : Page
    {
        public MainMenuPagefFimoz()
        {
            InitializeComponent();
        }
        private void NavRegCactus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegCactus());
        }

        private void NavRegExibition_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegExibition());
        }

        private void NavRegContestant_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegContestant());
        }

        private void NavRegWinner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllContestants());
        }

        private void NavShowAllCactuses_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllCactuses());
        }

        private void NavShowAllExibition_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllExibitions());
        }
    }
}
