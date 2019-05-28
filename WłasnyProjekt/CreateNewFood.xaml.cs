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
    /// Interaction logic for CreateNewFood.xaml
    /// </summary>
    public partial class CreateNewFood : Window
    {
        public Food food;

        public CreateNewFood()
        {
            InitializeComponent();
        }

        private void addNewFoodAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (isTypeCorrect())
            {
                food = new Food(addFoodName.Text, Convert.ToDouble(addKcal.Text), Convert.ToDouble(addProtein.Text), Convert.ToDouble(addCarbs.Text), Convert.ToDouble(addFats.Text), chooseCategory.SelectedIndex);
                this.Close();
            }
        }



        public bool isTypeCorrect()
        {
            bool isCorrect = true;

            if(addFoodName.Text!="" && isNumeric(addKcal.Text) && isNumeric(addProtein.Text) && isNumeric(addCarbs.Text) && isNumeric(addFats.Text)) { }
            else
                isCorrect = false;


            return isCorrect;
        }


        public static bool isNumeric(string text)
        {
            int x;
            bool isNumeric = int.TryParse(text, out x);
            return isNumeric;
        }


    }
}
