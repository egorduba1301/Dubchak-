﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_19_Pr_2__5zd_
{
    /// <summary>
    /// класс в котором реалезован интерфкйс 
    /// </summary>
    internal class PersonalComputer : ISwitchable
    {  /// <summary>
       /// реалезованный метод 
       /// </summary>
        public void On()
        {
            Console.WriteLine("Компьютер включен");
        }
        /// <summary>
        /// реалезованный метод 
        /// </summary>
        public void Off()
        {
            Console.WriteLine("Компьютер выключен");
        }
    }
}
