namespace InternetShop.Models
{
    public class Товар
    {
        public int Код_Товара { get; set; }
        public string Наименование { get; set; }
        public decimal Цена { get; set; }
        public float Рейтинг_товара { get; set; }
        public int Количество { get; set; }
        public string Категория { get; set; }
        public string Бренд { get; set; }
        public string Производитель { get; set; }
        public int Код_Продавца { get; set; }
    }
}
