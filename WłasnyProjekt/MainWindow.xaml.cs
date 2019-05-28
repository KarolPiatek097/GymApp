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

namespace WłasnyProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void dietAddNewFoodButtonClick(object sender, RoutedEventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();
            addNewFood.Top = myWindow.Top;
            addNewFood.Left = myWindow.Left + 100;

            addNewFood.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditUserDataWindow editUserDataWindow = new EditUserDataWindow();
            editUserDataWindow.Top = myWindow.Top;
            editUserDataWindow.Left = myWindow.Left+250;

            editUserDataWindow.ShowDialog();
        }
    }
}
