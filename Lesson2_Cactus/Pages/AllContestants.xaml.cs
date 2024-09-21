using Lesson2_Cactus.DataBase;
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
    /// Логика взаимодействия для AllContestants.xaml
    /// </summary>
    public partial class AllContestants : Page
    {
        public AllContestants()
        {
            InitializeComponent();
            ListContest.ItemsSource = Classes.db.Contestant.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DeleteCont_Click(object sender, RoutedEventArgs e)
        {
            Contestant selectedcont = ListContest.SelectedItem as Contestant;
            var tempcont = Classes.db.Contestant.FirstOrDefault(idex => idex.ID_Constestant == selectedcont.ID_Constestant);
            if (ListContest.SelectedItem != null)
            {
                Classes.db.Contestant.Remove(tempcont);
                Classes.db.SaveChanges();
                ListContest.ItemsSource = Classes.db.Cactus.ToList();
            }
            else
            {
                MessageBox.Show("Участник не выбран!!");
            }
            ListContest.ItemsSource = Classes.db.Cactus.ToList();
        }
    }
}
