using InternetShop.ViewModels;
using System.Windows;

namespace InternetShop.Views
{
    public partial class ClientView : Window
    {
        public ClientView()
        {
            InitializeComponent();

            // Создание экземпляра ViewModel и установка его контекста данных для окна
            ClientViewModel viewModel = new ClientViewModel();
            DataContext = viewModel;
        }
    }
}
