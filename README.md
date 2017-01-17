# Replacing Symbols In Text By Emoticons (extension method) <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 
## Use this method to convert symbols to Emoticons   
The method provides an opportunity to replace following combinations of symbols by corresponding emoticons

* :) or :-) to  



## How To Use
Just add [This] (https://github.com/tigranv/Replacing_Symbols_In-Text-By-Emoticons_extension_method/blob/master/EmoticonsConverter/EmoticonsConverter/ConvertEmoticonsExtention.cs) extention method to Your class or use it like class lybrary, and call method **ReplaceEmoticons()** method in eny string.
If You are using method in console application You need activate console unicode fonts, see how to do that [here] (http://stackoverflow.com/questions/5750203/how-to-write-unicode-characters-to-the-console)   

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
## Simple Usage
Instead of instantiating individual Random objects, I recommend that you create a single Random instance to generate all the random numbers needed by your app.

> This class library written on C# 2015 .NET Framework 4.6

Use this method to convert symbols to Emoticons
![emoticonsextention](https://cloud.githubusercontent.com/assets/24522089/22002273/06224dca-dc64-11e6-85f2-62f157775b25.gif)
