using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._1
{
    internal class FirstClass
    {
        [Name("Первое свойство")]
        public string first { get; set; }
        //[Name("Второе свойство")]
        public string second { get; set; }
        [Name("Третье свойство")]
        public string third { get; set; }
        [Name("Четвертое свойство")]
        public string fourth { get; set; }
        [Name("Пятое свойство")]
        public string fifth { get; set; }
        [Name("Шестое свойство")]
        public string sixth { get; set; }
        [Name("Седьмое свойство")]
        public string seventh { get; set; }
        [Name("Восьмое свойство")]
        public string eighth { get; set; }
        [Name("Девятое свойство")]
        public string ninth { get; set; }
        [Name("Десятое свойство")]
        public string tenth { get; set; }

        public FirstClass()
        {
            int i = 1;
            foreach (var item in typeof(FirstClass).GetProperties())
            {
                item.SetValue(this, i.ToString());
                i++;
            }
        }

    }
}
