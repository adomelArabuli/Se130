using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Windows;

namespace PasswordBox
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
    }

    class Person
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [JsonIgnore]
        public string Token { get; set; }

        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}
