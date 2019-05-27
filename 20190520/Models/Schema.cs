using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata1.Models
{
    class Schema
    {
        public List<Flag> Flags { get; set; }

        public Schema(Flag flag)
        {
            Flags.Add(flag);
        }

        public Schema(List<Flag> flags)
        {
            Flags = flags;
        }

        public void AddFlag(Flag flag)
        {
            Flags.Add(flag);
        }

        public Flag GetFlag(char name)
        {
            return Flags.Find(x => x.Name == name);
        }
    }
}
