using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (ValidateUser(username, password))
            {
                HomeWindow homewindow = new HomeWindow();
                homewindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден или неверный пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool ValidateUser(string username, string password)
        {
            return username == "Admin" && password == "1234";
        }
    }
}