﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_16_Pr_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //DateTime date1 = new DateTime(2022, 1, 20);
            //Console.WriteLine(date1);
            //DateTime date2 = new DateTime(2022, 1, 25, 21, 30, 25);
            //Console.WriteLine(date2.DayOfWeek);
            //Console.WriteLine(date2.Month);
            //Console.WriteLine(date2.Year);
            //Console.WriteLine(date2.ToLongDateString());
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(date2.ToLongDateString());
            //Console.WriteLine(date2.ToShortTimeString());
            //Console.Write($"{date2.DayOfWeek}\t{date2.Day}\t" +
            //    $"{date2.Month}\t{date2.Year}\t{date2.TimeOfDay}" +
            //    $"");
            //Задание 2 
            //Console.Write("Введите возраст человека ");
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    int year = DateTime.Now.Year - DateTime.Now.Month-age;
            //    Console.WriteLine($"ты родился в {year}году ");
            //}
            //Задача 3
            Console.Write("Год рождения ");
            {
                int year = Convert.ToInt32(Console.ReadLine());
                int age = DateTime.Now.Year - DateTime.Now.Month - year;
                Console.WriteLine($"Твой возраст  {age}");
            }

            Console.ReadKey();
        }
    }
    }

