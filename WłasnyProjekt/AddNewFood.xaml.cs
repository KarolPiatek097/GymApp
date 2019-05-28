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
using System.Windows.Shapes;

namespace WłasnyProjekt
{
    /// <summary>
    /// Interaction logic for AddNewFood.xaml
    /// </summary>
    public partial class AddNewFood : Window
    {

        public AddNewFood()
        {
            InitializeComponent();
        }

        private void AddFoodCancelButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addNewFoodLoaded(object sender, EventArgs e)
        {
            dataGridOfAvailableFood.ItemsSource = (Application.Current.Resources["user"] as User).listOfFood;
        }


        private void CreateNewFoodButtonClick(object sender, RoutedEventArgs e)
        {
            CreateNewFood createNewFood = new CreateNewFood();
            createNewFood.Top = AddNewFoodWindow.Top;
            createNewFood.Left = AddNewFoodWindow.Left + 100;

            createNewFood.ShowDialog();

            if (createNewFood.food != null)
                (Application.Current.Resources["user"] as User).listOfFood.Add(createNewFood.food);


            dataGridOfAvailableFood.ItemsSource = (Application.Current.Resources["user"] as User).listOfFood;

        }

        private void addFoodAddButton(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
