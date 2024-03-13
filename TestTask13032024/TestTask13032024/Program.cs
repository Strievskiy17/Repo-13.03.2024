using System;
using TestTask13032024;

namespace MindBoxLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krug krug_ = new Krug("Krug", 12);
            Treug treug_ = new Treug("Triangle", 4, 4, 5);

            Console.WriteLine(krug_.Ploshad());
            Console.WriteLine(treug_.Ploshad());

        }
    }
}