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

namespace checkBoxes
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

        private void cbParent_Checked(object sender, RoutedEventArgs e)
        {
            bool value = (cbParent.IsChecked == true);
            cbCheese.IsChecked = value;
            cbChicken.IsChecked = value;
            cbPepper.IsChecked = value;
            cbBeef.IsChecked = value;
        }

        private void cbParent_Unchecked(object sender, RoutedEventArgs e)
        {
            if(cbChicken.IsChecked == true && cbCheese.IsChecked == true && cbPepper.IsChecked == true && cbBeef.IsChecked == true)
            {
                bool value = (cbParent.IsChecked == false);
                cbCheese.IsChecked = !value;
                cbChicken.IsChecked = !value;
                cbPepper.IsChecked = !value;
                cbBeef.IsChecked = !value;
            }
        }



        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            cbCheese.IsChecked = true;
            if (cbChicken.IsChecked == true && cbBeef.IsChecked == true && cbPepper.IsChecked == true)
            {
                cbParent.IsChecked = true;
            }
        }

        private void cbChicken_Checked(object sender, RoutedEventArgs e)
        {
            cbChicken.IsChecked = true;
            if (cbCheese.IsChecked == true && cbBeef.IsChecked == true && cbPepper.IsChecked == true)
            {
                cbParent.IsChecked = true;
            }
        }

        private void cbBeef_Checked(object sender, RoutedEventArgs e)
        {
            cbBeef.IsChecked = true;
            if (cbChicken.IsChecked == true && cbCheese.IsChecked == true && cbPepper.IsChecked == true)
            {
                cbParent.IsChecked = true;
            }
        }

        private void cbPepper_Checked(object sender, RoutedEventArgs e)
        {
            cbPepper.IsChecked = true;
            if (cbChicken.IsChecked == true && cbBeef.IsChecked == true && cbCheese.IsChecked == true)
            {
                cbParent.IsChecked = true;
            }
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            cbCheese.IsChecked = false;
            if(cbParent.IsChecked == true)
            {
                cbParent.IsChecked = false;
            }
        }

        private void cbPepper_Unchecked(object sender, RoutedEventArgs e)
        {
            cbPepper.IsChecked = false;
            if (cbParent.IsChecked == true)
            {
                cbParent.IsChecked = false;
            }
        }

        private void cbBeef_Unchecked(object sender, RoutedEventArgs e)
        {
            cbBeef.IsChecked = false;
            if (cbParent.IsChecked == true)
            {
                cbParent.IsChecked = false;
            }
        }

        private void cbChicken_Unchecked(object sender, RoutedEventArgs e)
        {
            cbChicken.IsChecked = false;
            if (cbParent.IsChecked == true)
            {
                cbParent.IsChecked = false;
            }
        }
    }
}
