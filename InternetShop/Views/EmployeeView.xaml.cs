using InternetShop.ViewModels;
using System.Windows;

namespace InternetShop.Views
{
    public partial class EmployeeView : Window
    {
        private readonly EmployeeViewModel _viewModel;

        public EmployeeView()
        {
            InitializeComponent();
            // Создание экземпляра ViewModel и установка его контекста данных для окна
            _viewModel = new EmployeeViewModel();
            DataContext = _viewModel; 
        }
    }
}
