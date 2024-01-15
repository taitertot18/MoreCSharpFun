using MoreCSharpFun;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff();

        /*putting name without an = means its null which is not good...*/
        string name = "";
        
        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }

}