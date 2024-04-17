using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_19_Pr_2__5zd_
{
    /// <summary>
    /// класс, в котором реалезован интерфейс
    /// </summary>
    internal class TVSet : ISwitchable
    {/// <summary>
     /// реалезованный метод
     /// </summary>
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }
        /// <summary>
        /// реалезованный метод
        /// </summary>
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }

    }
}
