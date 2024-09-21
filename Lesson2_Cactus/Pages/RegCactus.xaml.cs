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
    /// Логика взаимодействия для RegCactus.xaml
    /// </summary>
    public partial class RegCactus : Page
    {
        public RegCactus()
        {
            InitializeComponent();
        }

        private void RegCactusBtn_Click(object sender, RoutedEventArgs e)
        {
            string NameCactus = NameTxt.Text;
            
            var cactus = Classes.db.Cactus.FirstOrDefault(name => name.Name_Cactus == NameCactus);
            if (NameTxt.Text == "" || AgeCactusTxt.Text == "" || OriginCactusTxt.Text == "" || CostCactusTxt.Text == "" || ManualCactusTxt.Text == "" || TypeCactusCB == null)
            {
                MessageBox.Show("Заполните все данные!!");
            }
            else if (cactus != null)
            {
                MessageBox.Show("Кактус с таким именем уже зарегестрирован!");
            }
            else {
                string selectedValueType = Convert.ToString(TypeCactusCB.SelectedValue).Remove(0, 38);
                var tempCactus = new Cactus() { Name_Cactus = NameTxt.Text, Age_cactus = Convert.ToInt32(AgeCactusTxt.Text), Origins_cactus = OriginCactusTxt.Text, Manuals_cactus = ManualCactusTxt.Text, Cost_cactus = Convert.ToInt32(CostCactusTxt.Text), Type_of_cactus = selectedValueType };
                Classes.db.Cactus.Add(tempCactus);
                Classes.db.SaveChanges();
                MessageBox.Show("Кактус успешно зарегестрирован:\n" + "Название: " + NameTxt.Text + "\nСтоимость: " + CostCactusTxt.Text + "\nВозраст: " + AgeCactusTxt.Text + "\nВид: " + selectedValueType + "\nПроисхождение: " + OriginCactusTxt.Text + "\nРуководство: " + ManualCactusTxt.Text);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
