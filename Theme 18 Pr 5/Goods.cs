﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_5
{
    /// <summary>
    /// абстрактный класс
    /// </summary>
    abstract class Goods
    {/// <summary>
     /// поле описывающее имя
     /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// поле описывающее цену
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// поле описывающее дату производства
        /// </summary>
        /// <returns></returns>
        public abstract string DeadlineExpirationDate();
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Название: {Name}\n Цена:{Price}";
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Goods() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Goods(string name, int price)
        {
            Name = name;
            Price = price;
        }

    }
}
