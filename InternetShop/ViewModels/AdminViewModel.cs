using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using InternetShop.Commands;
using InternetShop.Models;

namespace InternetShop.ViewModels
{
    public class AdminViewModel : ViewModelBase
    {
        private ObservableCollection<Товар> _products;

        public ObservableCollection<Товар> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        // Команды для товаров
        public ICommand AddProductCommand { get; set; }
        public ICommand EditProductCommand { get; set; }
        public ICommand DeleteProductCommand { get; set; }

        public AdminViewModel()
        {
            // Инициализация команд
            AddProductCommand = new RelayCommand(AddProduct);
            EditProductCommand = new RelayCommand(EditProduct);
            DeleteProductCommand = new RelayCommand(DeleteProduct);

            // Инициализация коллекции данными 
            Products = new ObservableCollection<Товар>();
        }

        private void AddProduct(object parameter)
        {
            // Логика добавления товара
            Товар новыйТовар = ПолучитьДанныеОТоваре(); 
            Товары.Add(новыйТовар); 
        }

        private void EditProduct(object parameter)
        {
            // Логика редактирования товара
            if (ВыбранныйТовар != null) 
            {
                Товар измененныйТовар = ПолучитьДанныеОТоваре(); 
                                                                 
                ВыбранныйТовар.Наименование = измененныйТовар.Наименование;
                ВыбранныйТовар.Цена = измененныйТовар.Цена;
                
            }
        }

        private void DeleteProduct(object parameter)
        {
            // Логика удаления товара
            if (ВыбранныйТовар != null) 
            {
                // Проверка, можно ли удалять товар
                if (МожноУдалитьТовар(ВыбранныйТовар))
                {
                    Товары.Remove(ВыбранныйТовар);
                }
                else
                {
                    // Обработка случая, когда товар нельзя удалить
                    MessageBox.Show("Нельзя удалить товар, который находится в заказах за последние два месяца.");
                }
            }
        }

        private bool МожноУдалитьТовар(Товар товар)
        {
            // Логика проверки, можно ли удалить товар
          
            return true;
        }
    }
}