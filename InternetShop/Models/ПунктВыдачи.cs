using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class ПунктВыдачи
    {
        public int Код_Пункта_выдачи { get; set; }
        public string Адрес { get; set; }
        public int Оборот_заказов { get; set; }
        public float Рейтинг_пункта_выдачи { get; set; }
        public int Количество_доступных_мест { get; set; }
    }
}
