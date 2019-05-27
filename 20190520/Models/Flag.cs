using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata1.Models
{
    class Flag
    {
        public char Name { get; set; }
        public Type Type { get; set; }

        public Flag(char name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
