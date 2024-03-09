using InternetShop.Commands;
using InternetShop.Views;
using System.ComponentModel;

namespace InternetShop.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private RelayCommand _startCommand;

        public RelayCommand StartCommand
        {
            get
            {
                return _startCommand ?? (_startCommand = new RelayCommand(param => StartAction()));
            }
        }

        private void StartAction()
        {
            // Создаем экземпляр LoginViewModel
            LoginViewModel loginViewModel = new LoginViewModel();

            // Открываем окно авторизации и передаем ему экземпляр LoginViewModel
            LoginView loginView = new LoginView(loginViewModel);
            loginView.Show();

            // Закрываем текущее окно
            App.Current.MainWindow.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
