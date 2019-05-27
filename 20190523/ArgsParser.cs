using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ArgsParser
    {
        public List<Flag> Flags { get; set; }
        public Schema Schema { get; set; }

        public ArgsParser(Schema schema, string[] args)
        {
            Flags = new List<Flag>();
            Schema = schema;

            for(int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith('-'))
                {
                    if (args[i+1].StartsWith('-') && !Int32.TryParse(args[i + 1], out int b))
                    {
                        i++;
                        continue;
                    }
                    Flag flag = schema.GetFlag(args[i][1]);
                    try
                    {
                        string argument = args[i + 1];
                        object value = Convert.ChangeType(argument, flag.Type);                        
                        flag.Value = value.ToString();
                        Flags.Add(flag);
                    }
                    catch
                    {
                        Console.WriteLine("The value given for the argument '" +args[i]+"' do not match the schema");
                    }
                    i++;
                }
                
            }
        }

        public T GetArgumentValue<T>(char name)
        {
            Flag flag = Flags.Find(x => x.Name == name);
            try
            {
                return (T)Convert.ChangeType(flag.Value, flag.Type);
            }
            catch
            {
                return default(T);
            }


        }
    }
}
