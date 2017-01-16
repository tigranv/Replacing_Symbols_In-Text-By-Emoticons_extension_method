using System;
using EmoticonsConverter;

namespace TestExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter eny text");
            string st = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(st.ConvertEmoticons());

            Console.ReadKey();
        }
    }
}
