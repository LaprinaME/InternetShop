using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Сотрудник
    {
        [Key]
        public int Код_Сотрудника { get; set; }
        public string ФИО { get; set; }
        public string Должность { get; set; }
        public decimal Зарплата { get; set; }

        [ForeignKey("ПунктВыдачи")]
        public int Код_ПВЗ { get; set; }
        public ПунктВыдачи ПунктВыдачи { get; set; }

        [ForeignKey("Пользователь")]
        public int Код_Пользователя { get; set; }
        public Пользователь Пользователь { get; set; }

        public string СНИЛС { get; set; }
        public string ИНН { get; set; }
        public DateTime Дата_рождения { get; set; }
        public string Номер_телефона { get; set; }
        public string Почта { get; set; }
    }
}