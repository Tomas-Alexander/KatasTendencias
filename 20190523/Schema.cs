using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Schema
    {
        public List<Flag> Flags { get; set; }

        public Schema(List<Flag> flags)
        {
            Flags = flags;
        }

        public Flag GetFlag(char name)
        {
            return Flags.Find(x => x.Name == name);
        }
    }
}
