using InternetShop.ViewModels;
using System.Windows;

namespace InternetShop.Views
{
    public partial class LoginView : Window
    {
        public LoginView(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            DataContext = loginViewModel; // Установка DataContext для привязки данных в XAML
        }
    }
}
