using Lesson2_Cactus.DataBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace Lesson2_Cactus.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegContestant.xaml
    /// </summary>
    public partial class RegContestant : Page
    {
        public RegContestant()
        {
            InitializeComponent();
            ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
            ListExibitions.ItemsSource = Classes.db.Exibitions.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
            Exibitions selectedExibition = ListExibitions.SelectedItem as Exibitions;
            int cactusid = selectedCactus.ID_Cactus;
            int exibitionid = selectedExibition.ID_Exibition;
            var cacti_ex = Classes.db.Contestant.FirstOrDefault(cacexid => cacexid.ID_Cactus == cactusid && cacexid.ID_Exibition == exibitionid);
            if(ListCactuses.SelectedItem == null || ListExibitions.SelectedItem == null)
            {
                MessageBox.Show("Выберите выставку и кактус!!");
            }
            else if(cacti_ex != null)
            {
                MessageBox.Show("Такой кактус уже зарегестрирован на этом мероприятии");
            }
            else
            {
                var tempcontestant = new Contestant()
                {
                    ID_Cactus = cactusid,
                    ID_Exibition = exibitionid,
                };
                Classes.db.Contestant.Add(tempcontestant);
                Classes.db.SaveChanges();
                MessageBox.Show("Зарегестрировано!");
            }
        }
    }
}
