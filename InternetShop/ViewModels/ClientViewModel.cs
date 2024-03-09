using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using InternetShop.Commands;
using InternetShop.Models;

namespace InternetShop.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private ObservableCollection<Товар> _товары;
        private string _searchText;

        public ObservableCollection<Товар> Товары
        {
            get { return _товары; }
            set
            {
                if (_товары != value)
                {
                    _товары = value;
                    OnPropertyChanged(nameof(Товары));
                }
            }
        }

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged(nameof(SearchText));
                    ApplySearch();
                }
            }
        }

        public ICommand SearchProductCommand { get; private set; }
        public ICommand FilterByAlphabetCommand { get; private set; }
        public ICommand FilterByQuantityCommand { get; private set; }

        public ClientViewModel()
        {
            ЗагрузитьТовары();
            InitializeCommands();
        }

        private void ЗагрузитьТовары()
        {
            // Добавление данных в коллекцию:
            Товары = new ObservableCollection<Товар>
            {
                // Загрузка товаров
            };
        }

        private void ApplySearch()
        {
            // Применяем фильтр поиска
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                // Если поле поиска пустое, отображаем все товары
                ЗагрузитьТовары();
            }
            else
            {
                // Иначе отображаем только товары, соответствующие поисковому запросу
                Товары = new ObservableCollection<Товар>(
                    _товары.Where(товар => товар.Наименование.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                );
            }
        }

        private void InitializeCommands()
        {
            SearchProductCommand = new RelayCommand(param => ApplySearch());
            FilterByAlphabetCommand = new RelayCommand(param => SortByAlphabet());
            FilterByQuantityCommand = new RelayCommand(param => SortByQuantity());
        }

        private void SortByAlphabet()
        {
            // Сортировка товаров по алфавиту
            Товары = new ObservableCollection<Товар>(_товары.OrderBy(товар => товар.Наименование));
        }

        private void SortByQuantity()
        {
            // Сортировка товаров по количеству
            Товары = new ObservableCollection<Товар>(_товары.OrderBy(товар => товар.Количество));
        }
    }
}
