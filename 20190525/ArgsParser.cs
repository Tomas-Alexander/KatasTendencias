using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata3
{
    class ArgsParser
    {
        Schema Schema;
        List<Flag> Flags;
        public ArgsParser(Schema schema, string[] args)
        {
            Schema = schema;
            Flags = new List<Flag>();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith('-') && (i+1) < args.Length)
                {
                    Flag flag = Schema.GetFlag(args[i][1]);
                    
                    if (args[i + 1].StartsWith('-') && !Int32.TryParse(args[i + 1], out int b))
                    {
                        continue;
                    }
                    try
                    {
                        object value = Convert.ChangeType(args[i + 1], flag.Type);
                        if (value != null)
                        {
                            flag.Value = args[i + 1];
                            Flags.Add(flag);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The argument value for '" + flag.Name + "' is not valid");
                    }
                }
            }
        }

        public T getArgument<T>(char name)
        {
            Flag flag = Flags.Find(x => x.Name == name);
            if (flag != null)
            {
                return (T)Convert.ChangeType(flag.Value, flag.Type);
            }
            else
            {
                return default(T);
            }
        }
    }
}
