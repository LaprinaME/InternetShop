using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Обслуживание
    {
        public int Код_Обслуживания { get; set; }
        public int Код_Сотрудника { get; set; }
        public int Код_Клиента { get; set; }
        public DateTime Дата_обслуживания { get; set; }
    }
}
