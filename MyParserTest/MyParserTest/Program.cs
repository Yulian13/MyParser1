using MyParserTest.Core;
using MyParserTest.Core.Habra;
using System;

namespace MyParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new ParserWorker<string[]>(
                    new HabraParser("anime-title","a"),
                    new HabraSettings("https://yummyanime.club", "catalog/item/aktery")
                );
            test.OnNewData += Test_OnNewData;
            Console.WriteLine("------Begin------");
            test.Start();
            Console.ReadKey();
        }

        private static void Test_OnNewData(object arg1, string[] arg2)
        {
            foreach(var title in arg2)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine(arg2.Length);
            Console.WriteLine("------End------");
}
    }
}
