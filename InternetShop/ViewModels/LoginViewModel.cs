using System.Linq; ;
using System.Windows.Input;
using System.Windows;
using InternetShop.Commands;
using InternetShop.DataContext;
using InternetShop.Views;
using InternetShop.Models;

namespace InternetShop.ViewModels
{
    public enum UserRole
    {
        Клиент,
        Сотрудник,
        Администратор
    }
    public class LoginViewModel : ViewModelBase
    {
        private string _login;
        private string _password;

        public string Login
        {
            get { return _login; }
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged(nameof(Login));
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginAction, CanLogin);
        }

        private bool CanLogin(object parameter)
        {
            // Логика проверки, может ли пользователь войти
            return !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password) && CheckCredentials(Login, Password);
        }
        private bool CheckCredentials(string login, string password)
        {
           
            using (var context = new InternetShopDbContext()) // Контекст базы данных
            {
                var user = context.Пользователи.FirstOrDefault(u => u.Логин == login && u.Пароль == password);

                return user != null;
            }
        }
        private void LoginAction(object parameter)
        {
            if (CanLogin(null))
            {
                UserRole userRole = DetermineUserRole(Login, Password);

                switch (userRole)
                {
                    case UserRole.Клиент:
                        ShowClientView();
                        break;
                    case UserRole.Сотрудник:
                        ShowEmployeeView();
                        break;
                    case UserRole.Администратор:
                        ShowAdminView();
                        break;
                    default:
                        MessageBox.Show("Не удалось определить роль пользователя.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка входа. Пожалуйста, проверьте логин и пароль.");
            }
        }

        private UserRole DetermineUserRole(string login, string password)
        {
            using (var context = new InternetShopDbContext()) // Контекст базы данных
            {
                var user = context.Пользователи.FirstOrDefault(u => u.Логин == login && u.Пароль == password);

                if (user != null)
                {
                    // Получаем код роли пользователя
                    int userRoleCode = user.Код_Роли;

                    // Используем код роли для определения enum UserRole
                    switch (userRoleCode)
                    {
                        case 1:
                            return UserRole.Клиент;
                        case 2:
                            return UserRole.Сотрудник;
                        case 3:
                            return UserRole.Администратор;
                        default:
                            // В случае, если код роли неизвестен, можно вернуть роль по умолчанию
                            return UserRole.Клиент;
                    }
                }
                else
                {
                    // В случае, если пользователь не найден, можно вернуть роль по умолчанию
                    return UserRole.Клиент;
                }
            }
        }
        private void ShowClientView()
        {
            // Создать и отобразить окно для клиента
            ClientView clientView = new ClientView();
            clientView.Show();
        }

        private void ShowEmployeeView()
        {
            // Создать и отобразить окно для сотрудника
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
        }

        private void ShowAdminView()
        {
            // Создать и отобразить окно для администратора
            AdminView adminView = new AdminView();
            adminView.Show();
        }

    }
}
