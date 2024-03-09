using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using InternetShop.Commands;
using InternetShop.DataContext;
using InternetShop.Models;

namespace InternetShop.ViewModels
{
    public class EmployeeViewModel : ViewModelBase
    {
        private ObservableCollection<Заказ> _orders;
        private ObservableCollection<Товар> _products;

        public ObservableCollection<Заказ> Orders
        {
            get { return _orders; }
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    OnPropertyChanged(nameof(Orders));
                }
            }
        }

        public ObservableCollection<Товар> Products
        {
            get { return _products; }
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        public ICommand ChangeProductQuantityCommand { get; private set; }
        public ICommand ViewOrdersCommand { get; private set; }

        public EmployeeViewModel()
        {
            ЗагрузитьЗаказы();
            ЗагрузитьТовары();
            InitializeCommands();
        }

        private void ЗагрузитьЗаказы()
        {
            // Добавление данных в коллекцию:

            // Получение заказов из базы данных
            var заказыИзБазыДанных = InternetShopDBContext.ПолучитьВсеЗаказы();

            // Преобразование данных из базы данных в объекты Заказ
            Orders = new ObservableCollection<Заказ>(заказыИзБазыДанных);
        }

        private void ЗагрузитьТовары()
        {
            // Добавление данных в коллекцию:

            // Получение товаров из базы данных
            var товарыИзБазыДанных = InternetShopDBContext.ПолучитьВсеТовары();

            // Преобразование данных из базы данных в объекты "Товар"
            Products = new ObservableCollection<Товар>(товарыИзБазыДанных);
        }

        private void InitializeCommands()
        {
            ChangeProductQuantityCommand = new RelayCommand(param => ИзменитьКоличествоТоваров());
            ViewOrdersCommand = new RelayCommand(param => ПросмотретьЗаказыНаПунктеВыдачи());
        }

        private void ИзменитьКоличествоТоваров()
        {
            // Логика изменения количества товаров
        }

        private void ПросмотретьЗаказыНаПунктеВыдачи()
        {
            // Логика просмотра заказов на пункте выдачи
        }
    }
}
