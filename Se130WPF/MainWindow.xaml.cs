using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Se130WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string dbConnectionString = ConfigurationManager.ConnectionStrings["DefaultDbConnection"].ConnectionString;
        }

        private void java_Checked(object sender, RoutedEventArgs e)
        {
            myLabel.Foreground = Brushes.Green;
        }

        private void java_Unchecked(object sender, RoutedEventArgs e)
        {
            myLabel.Foreground = Brushes.Black;
        }

        private void java_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Red;
        }

        private void java_MouseLeave(object sender, MouseEventArgs e)
        {
            //myLabel.Foreground = Brushes.Black;

            if (java.IsChecked.HasValue || java.IsChecked.Value)
            {
                // Add your custom MouseLeave logic here
                // For example, revert the background color
                java.Foreground = Brushes.Transparent;
            }
        }
    }
}
