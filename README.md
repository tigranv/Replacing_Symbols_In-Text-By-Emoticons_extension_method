# Replacing Symbols By Emoticons (ext. method) <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 
### This method provides an opportunity to replace symbols in latin text by corresponding [Unicode Emoticons] (https://en.wikipedia.org/wiki/Emoticons_(Unicode_block))
![emoticonsext](https://cloud.githubusercontent.com/assets/24522089/22016876/41975f82-dcc1-11e6-9d41-d1f42d06c7d4.gif)

### Method supports replacement of following combinations of symbols 

* :) or :-) to  &#128522;
* :( or :-( to  &#9785;
* -> or :--> to  &#9755;
* <- or :<-- to  &#9754;
* => or :==> to  &#10152;
* ...

## How To Use
Just add [This] (https://github.com/tigranv/Replacing_Symbols_In-Text-By-Emoticons_extension_method/blob/master/EmoticonsConverter/EmoticonsConverter/ConvertEmoticonsExtention.cs) extension method to Your class or use it like class lybrary, and call method **ReplaceEmoticons()**  in any string.
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

### See Also

My another project for converting  [latin letters to armenian] (https://github.com/tigranv/Useful-examples/tree/master/LatinToArmenianConverter)

![lattoarm](https://cloud.githubusercontent.com/assets/24522089/21999629/84782556-dc54-11e6-87df-d6780b7d9649.gif)

![lattoarmtrans](https://cloud.githubusercontent.com/assets/24522089/22148698/0f54593e-df29-11e6-9d17-b007d0440909.png)


> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition



