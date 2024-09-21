using Lesson2_Cactus.DataBase;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для RegExibition.xaml
    /// </summary>
    public partial class RegExibition : Page
    {
        public RegExibition()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            string place = PlaceTxt.Text;
            DateTime? selectedDate = DateCal.SelectedDate;
            DateTime? date = null;
            if (DateCal.SelectedDate.HasValue)
            {
                date = DateCal.SelectedDate.Value;
            }
            var Ex = Classes.db.Exibitions.FirstOrDefault(name => name.Place_Exibition == place && name.Date_Exibition == date);
            if (NameTxt.Text == "" || RewardTxt.Text == "" || PlaceTxt.Text == "" || CommTxt.Text == "" || DateCal == null)
            {
                MessageBox.Show("Заполните все данные!!");
            }
            else if (Ex != null)
            {
                MessageBox.Show("Выставка в этом месте на эту дату уже зарегестрирована!!");
            }
            else
            {
                selectedDate = DateCal.SelectedDate;
                string name = NameTxt.Text;
                string rewards = RewardTxt.Text;
                string commentaries = CommTxt.Text;
                place = PlaceTxt.Text;
                date = null;
                if (DateCal.SelectedDate.HasValue)
                {
                    date = DateCal.SelectedDate.Value;
                }
                var tempEx = new Exibitions() {
                    Name_Exibition = name,
                    Rewards_Exibition = rewards,
                    Commentaries = commentaries,
                    Place_Exibition = place,
                    Date_Exibition = date
                };
                Classes.db.Exibitions.Add(tempEx);
                Classes.db.SaveChanges();
                MessageBox.Show("Зарегестрировано!");
            }
        }
    }
}
