using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata3
{
    class Schema
    {
        List<Flag> Flags;

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
