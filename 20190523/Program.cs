using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set Schema
            Schema schema = new Schema(new List<Flag> {
                new Flag('l', typeof(Boolean)),
                new Flag('p', typeof(int)),
                new Flag('d', typeof(string))});

            //Send the schema and the commmand-line arguments
            ArgsParser parser = new ArgsParser(schema, args);

            //Ask for the argument Values

            Console.WriteLine("Argument 'l': " + parser.GetArgumentValue<bool>('l'));
            Console.WriteLine("Argument 'p': " + parser.GetArgumentValue<int>('p'));
            Console.WriteLine("Argument 'd': " + parser.GetArgumentValue<string>('d'));
            Console.ReadLine();
        }
    }
}
