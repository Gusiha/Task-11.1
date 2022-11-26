using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._1
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class NameAttribute : Attribute
    {
        public string Description { get; set; }
        public NameAttribute(string number)
        {
            Description = number; 
        }
    }
}
