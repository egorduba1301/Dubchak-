using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_19_Pr_2
{
    /// <summary>
    /// класс. в котором реалезуется интерфейс
    /// </summary>
    internal class DerivedClass : IInterface1
    {
        /// <summary>
        /// реалезованный интерфейс
        /// </summary>
        public void Method()
        {
            Console.WriteLine("метод ,реалезованный в классе DerivedClass");
        }
    }
}
