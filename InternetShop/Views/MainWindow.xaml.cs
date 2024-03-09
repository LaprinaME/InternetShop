using System.Windows;
using InternetShop.ViewModels;

namespace InternetShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(); // Установка DataContext для привязки данных в XAML
        }
    }
}
