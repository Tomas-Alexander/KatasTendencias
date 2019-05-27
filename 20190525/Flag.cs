using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata3
{
    class Flag
    {
        public char Name { get; set; }
        public Type Type { get; set; }
        public string Value { get; set; }

        public Flag(char name, Type type)
        {
            Name = name;
            Type = type;
            Value = null;
        }
    }
}
