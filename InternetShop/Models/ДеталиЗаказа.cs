﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class ДеталиЗаказа
    {
        public int Код_Деталей_заказа { get; set; }
        public int Код_Заказа { get; set; }
        public int Код_Товара { get; set; }
        public int Количество_товара { get; set; }
        public decimal Цена_единицы { get; set; }
    }
}
