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
    /// Interaction logic for EditUserDataWindow.xaml
    /// </summary>
    public partial class EditUserDataWindow : Window
    {
        public EditUserDataWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditUserDataCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
