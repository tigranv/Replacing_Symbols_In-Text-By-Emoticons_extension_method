# Replacing Symbols By Emoticons (ext. method) <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 
### This method provides an opportunity to replace symbols in latin text by corresponding [Unicode Emoticons] (https://en.wikipedia.org/wiki/Emoticons_(Unicode_block))
![emoticonsextention](https://cloud.githubusercontent.com/assets/24522089/22002273/06224dca-dc64-11e6-85f2-62f157775b25.gif)

### Method supports replacement of following combinations of symbols 

* :) or :-) to  &#128512;

## How To Use
Just add [This] (https://github.com/tigranv/Replacing_Symbols_In-Text-By-Emoticons_extension_method/blob/master/EmoticonsConverter/EmoticonsConverter/ConvertEmoticonsExtention.cs) extention method to Your class or use it like class lybrary, and call method **ReplaceEmoticons()**  in any string.
If You are using method in console application You need to activate console unicode fonts, see how to do that [here] (http://stackoverflow.com/questions/5750203/how-to-write-unicode-characters-to-the-console)   

> The example of using this method in c# console application is
```c#
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Text");
        string st = Console.ReadLine();
        Console.WriteLine(new string('-', 30));
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(st.ConvertEmoticons());
        Console.ReadKey();
    }
}
```
> This project written on C# 2015 .NET Framework 4.6



