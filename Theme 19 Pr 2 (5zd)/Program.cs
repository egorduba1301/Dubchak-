using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_19_Pr_2__5zd_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                List<ISwitchable> devices = new List<ISwitchable>();
                devices.Add(new TVSet());
                devices.Add(new PersonalComputer());
                foreach (var s in devices)
                {
                    s.Off();
                    s.On();
                }
                Console.ReadLine();
            }
        }
    }
}
