using InternetShop.Commands;
using InternetShop.ViewModels;
using System.Windows.Input;
using System.Windows;

public class UserRoleViewModel : ViewModelBase
{
    private string _userName;

    public string UserName
    {
        get { return _userName; }
        set
        {
            if (_userName != value)
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
    }

    public ICommand LogoutCommand { get; }

    public UserRoleViewModel()
    {
        LogoutCommand = new RelayCommand(Logout);
    }

    private void Logout(object parameter)
    {
        // Логика входа
        MessageBox.Show("Пользователь вышел из системы");
    }
}
