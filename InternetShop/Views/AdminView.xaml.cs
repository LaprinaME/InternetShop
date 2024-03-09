using InternetShop.ViewModels;
using System.Windows;

namespace InternetShop.Views
{
    public partial class AdminView : Window
    {
        private readonly AdminViewModel _viewModel;
        public AdminView()
        {
            InitializeComponent();
            _viewModel = new AdminViewModel();
            DataContext = _viewModel;
        }
    }
}
