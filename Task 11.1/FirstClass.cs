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
        public string First { get; set; }
        [Name("Второе свойство")]
        public string Second { get; set; }
        [Name("Третье свойство")]
        public string Third { get; set; }
        [Name("Четвертое свойство")]
        public string Fourth { get; set; }
        [Name("Пятое свойство")]
        public string Fifth { get; set; }
        //[Name("Шестое свойство")]
        public string Sixth { get; set; }
        [Name("Седьмое свойство")]
        public string Seventh { get; set; }
        //[Name("Восьмое свойство")]
        public string Eighth { get; set; }
        [Name("Девятое свойство")]
        public string Ninth { get; set; }
        [Name("Десятое свойство")]
        public string Tenth { get; set; }

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
