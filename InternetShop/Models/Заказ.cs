using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Заказ
    {
        public int Код_Заказа { get; set; }
        public int Код_Обслуживания { get; set; }
        public int Код_Клиента { get; set; }
        public decimal Общая_стоимость_заказа { get; set; }
        public string Статус_заказа { get; set; }
        public DateTime Дата_заказа { get; set; }
    }
}
