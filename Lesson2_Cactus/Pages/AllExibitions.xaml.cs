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
    /// Логика взаимодействия для AllExibitions.xaml
    /// </summary>
    public partial class AllExibitions : Page
    {
        public AllExibitions()
        {
            InitializeComponent();
            ListExibitions.ItemsSource = Classes.db.Exibitions.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListExibitions.SelectedItem != null)
            {
                Exibitions selectedEx = ListExibitions.SelectedItem as Exibitions;
                var exibitionid = Classes.db.Exibitions.FirstOrDefault(idex => idex.ID_Exibition == selectedEx.ID_Exibition);
                var contex = Classes.db.Contestant.FirstOrDefault();
                Classes.db.Exibitions.Remove(selectedEx);
                Classes.db.SaveChanges();
                ListExibitions.ItemsSource = Classes.db.Exibitions.ToList();
                return;
            }
            else
            {
                MessageBox.Show("Выставка не выбрана");
            }
        }

        private void EditCactusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListExibitions.SelectedItem != null)
            {
                if (EditCB.SelectedItem is ComboBoxItem item)
                {
                    if (item.Content.ToString() == "Название")
                    {
                        Exibitions selectedEx = ListExibitions.SelectedItem as Exibitions;
                        selectedEx.Name_Exibition = ChangesTxt.Text;
                        Classes.db.SaveChanges();
                        ListExibitions.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Место проведения")
                    {
                        Exibitions selectedEx = ListExibitions.SelectedItem as Exibitions;
                        selectedEx.Place_Exibition = Convert.ToString(ChangesTxt.Text);
                        Classes.db.SaveChanges();
                        ListExibitions.ItemsSource = Classes.db.Cactus.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Кактус не выбран");
            }
            ListExibitions.ItemsSource = Classes.db.Cactus.ToList();
        }

        private void EditCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
