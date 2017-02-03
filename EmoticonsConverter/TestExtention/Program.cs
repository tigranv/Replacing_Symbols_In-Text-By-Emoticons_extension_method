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
            Console.WriteLine(st.ReplaceEmoticons());

            // // to replace symbols in file documents, use 
            //Console.WriteLine("Enter file directory");
            //StreamReader sr = File.OpenText(@"directory");
            //string st = "";
            //string line = "";
            //while ((line = sr.ReadLine()) != null)
            //{
            //    st+= st+"\n";
            //}
            
            //st.ReplaceEmoticons()

            Console.ReadKey();
        }
    }
}
