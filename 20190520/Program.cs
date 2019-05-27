using ArgsKata1.Models;
using System;
using System.Collections.Generic;

namespace ArgsKata1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schema
            Schema schema = new Schema(new List<Flag>() {
                new Flag('l', typeof(bool)),
                new Flag('p', typeof(int)),
                new Flag('d', typeof(string)) });
            //Parse arguments


            //Show Arguments
            Console.WriteLine("Hello World!");
        }
    }
}
