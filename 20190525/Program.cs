using System;
using System.Collections.Generic;

namespace ArgsKata3
{
    class Program
    {
        static void Main(string[] args)
        {
            Schema schema = new Schema(new List<Flag>() {
                new Flag('l', typeof(bool)),
                new Flag('p', typeof(int)),
                new Flag('d', typeof(string))
            });

            ArgsParser parser = new ArgsParser(schema, args);

            Boolean argument1 = parser.getArgument<bool>('l');
            int argument2 = parser.getArgument<int>('p');
            string argument3 = parser.getArgument<string>('d');

            Console.WriteLine("Argument 'l': "+ argument1);
            Console.WriteLine("Argument 'p': " + argument2);
            Console.WriteLine("Argument 'd': " + argument3);
            Console.ReadLine();

        }
    }
}
