using System;
using EmoticonsConverter;

namespace TestExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Text");
            string st = Console.ReadLine();
            Console.WriteLine(new string('-', 50));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(st.ConvertEmoticons());

            Console.ReadKey();
        }
    }
}
