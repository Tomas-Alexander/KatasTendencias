using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsKata1.Models
{
    class ArgParser
    {
        public string[] Args { get; set; }
        public ArgParser(Schema schema, string[] args)
        {
            Args = args;
            for (int i = 0; i < args.Length; i++) 
            {
                string argument = args[i];
                if (argument.StartsWith('-'))
                {
                    if (args[i + 1].StartsWith('-'))
                    {
                        continue;
                    }
                    string value = args[i + 1];
                    Type type = schema.GetFlag(argument[0]).Type;
                    var hola = Convert.ChangeType(value, type);
                    
                }
            }

        }

    }
}
