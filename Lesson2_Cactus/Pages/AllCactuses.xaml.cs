using Lesson2_Cactus.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для AllCactuses.xaml
    /// </summary>
    public partial class AllCactuses : Page
    {
        public AllCactuses()
        {
            InitializeComponent();
            ListCactuses.ItemsSource = Classes.db.Cactus.ToList();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DeleteCactusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ListCactuses.SelectedItem != null)
            {
                Cactus selectedCacti = ListCactuses.SelectedItem as Cactus;
                var cactiid = Classes.db.Cactus.FirstOrDefault(idex => idex.ID_Cactus == selectedCacti.ID_Cactus);
                var contex = Classes.db.Contestant.FirstOrDefault();
                Classes.db.Cactus.Remove(selectedCacti);
                Classes.db.SaveChanges();
                ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                return;
            }
            else
            {
                MessageBox.Show("Кактус не выбран");
            }
        }

        private void AddCactusBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegCactus());
        }

        private void EditCactusBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (ListCactuses.SelectedItem != null)
            {
                if (EditCB.SelectedItem is ComboBoxItem item)
                {
                    if (item.Content.ToString() == "Имя")
                    {
                        Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                        selectedCactus.Name_Cactus = ChangesTxt.Text;
                        TypeCactusCB.SelectedValue = null;
                        Classes.db.SaveChanges();
                        ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Цена")
                    {
                        Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                        selectedCactus.Cost_cactus = Convert.ToInt32(ChangesTxt.Text);
                        TypeCactusCB.SelectedValue = null;
                        Classes.db.SaveChanges();
                        ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Возраст")
                    {
                        Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                        selectedCactus.Age_cactus = Convert.ToInt32(ChangesTxt.Text);
                        TypeCactusCB.SelectedValue = null;
                        Classes.db.SaveChanges();
                        ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Происхождение")
                    {
                        Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                        selectedCactus.Origins_cactus = ChangesTxt.Text;
                        TypeCactusCB.SelectedValue = null;
                        Classes.db.SaveChanges();
                        ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Рекомендации")
                    {
                        Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                        selectedCactus.Manuals_cactus = ChangesTxt.Text;
                        TypeCactusCB.SelectedValue = null;
                        Classes.db.SaveChanges();
                        ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                    }
                    else if (item.Content.ToString() == "Вид")
                    {
                        if(TypeCactusCB == null)
                        {
                            MessageBox.Show("Выберите вид кактуса!!");
                        }
                        else
                        {
                            string selectedValueType = Convert.ToString(TypeCactusCB.SelectedValue).Remove(0, 38);
                            Cactus selectedCactus = ListCactuses.SelectedItem as Cactus;
                            selectedCactus.Type_of_cactus = Convert.ToString(selectedValueType);
                            Classes.db.SaveChanges();
                            ListCactuses.ItemsSource = Classes.db.Cactus.ToList();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Кактус не выбран");
            }
        }

        private void EditCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EditCB.SelectedItem is ComboBoxItem item)
            {
                if (item.Content.ToString() == "Вид")
                {
                    TypeCactusCB.Visibility = Visibility.Visible;
                }
                else
                {
                    TypeCactusCB.SelectedValue = null;
                    TypeCactusCB.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
