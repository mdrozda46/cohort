using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups;

namespace WarmupsTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings obj = new Strings();
            //String Warmup 1
            Console.WriteLine(obj.SayHi("Bob"));
            Console.WriteLine(obj.SayHi("Alice"));
            Console.WriteLine(obj.SayHi("X"));
            //String Warmup 2
            Console.WriteLine(obj.Abba("Hi", "Bye"));
            Console.WriteLine(obj.Abba("Yo", "Alice"));
            Console.WriteLine(obj.Abba("What", "Up"));
            //String Warmup 3
            Console.WriteLine(obj.MakeTags("i", "Yay"));
            Console.WriteLine(obj.MakeTags("i", "Hello"));
            Console.WriteLine(obj.MakeTags("cite", "Yay"));
            //String Warmup 4
            Console.WriteLine(obj.InsertWord("<<>>", "Yay"));
            Console.WriteLine(obj.InsertWord("<<>>", "WooHoo"));
            Console.WriteLine(obj.InsertWord("[[]]", "word"));
            //String Warmup 5
            Console.WriteLine(obj.MultipleEndings("Hello"));
            Console.WriteLine(obj.MultipleEndings("ab"));
            Console.WriteLine(obj.MultipleEndings("Hi"));
            //String Warmup 6
            Console.WriteLine(obj.FirstHalf("WooHoo"));
            Console.WriteLine(obj.FirstHalf("HelloThere"));
            Console.WriteLine(obj.FirstHalf("abcdef"));
            //String Warmup 7 
            Console.WriteLine(obj.TrimOne("Hello"));
            Console.WriteLine(obj.TrimOne("java"));
            Console.WriteLine(obj.TrimOne("coding"));
            //String Warmup 8 
            Console.WriteLine(obj.LongInMiddle("Hello", "hi"));
            Console.WriteLine(obj.LongInMiddle("hi", "Hello"));
            Console.WriteLine(obj.LongInMiddle("aaa", "b"));
            //String Warmup 9
            Console.WriteLine(obj.Rotateleft2("Hello"));
            Console.WriteLine(obj.Rotateleft2("java"));
            Console.WriteLine(obj.Rotateleft2("Hi"));
            //String Warmup 10
            Console.WriteLine(obj.RotateRight2("Hello"));
            Console.WriteLine(obj.RotateRight2("java"));
            Console.WriteLine(obj.RotateRight2("Hi"));
            //String Warmup 11
            Console.WriteLine(obj.TakeOne("Hello", true));
            Console.WriteLine(obj.TakeOne("Hello", false));
            Console.WriteLine(obj.TakeOne("oh", true));
            //String Warmup 12
            Console.WriteLine(obj.MiddleTwo("string"));
            Console.WriteLine(obj.MiddleTwo("code"));
            Console.WriteLine(obj.MiddleTwo("Practice"));
            //String Warmup 13
            Console.WriteLine(obj.EndsWithLy("oddly"));
            Console.WriteLine(obj.EndsWithLy("y"));
            Console.WriteLine(obj.EndsWithLy("oddy"));
            Console.ReadLine();
        }

        
    }
}

