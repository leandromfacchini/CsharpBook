using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CreateTypes.Classes;

namespace CreateTypes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //TestIndex();
            // SwitchExpressions();
            // TuplePatterns();
            // NullableEnable();

            // await foreach (var number in RangeAsync(0, 10, 100))
            //     Console.WriteLine(number);

            // RectangleTest();

            FooTest();
            
            Console.ReadKey();
        }

        static async IAsyncEnumerable<int> RangeAsync(int start, int count, int delay)
        {
            for (int i = start; i < start + count; i++)
            {
                await Task.Delay(delay);
                yield return i;
            }
        }

        private static void NullableEnable()
        {
#nullable enable
            string s1 = null;
            string? s2 = null;

            var teste = s1.Length;
        }

        private static void TuplePatterns()
        {
            int cardNumber = 12;
            string suite = "spades";
            string cardName = (cardNumber, suite) switch
            {
                (13, "spades") => "King of spades",
                (13, "clubs") => "King of clubs",
            };

            Console.WriteLine($"{cardNumber} - {suite} - {cardName}");
        }

        private static void SwitchExpressions()
        {
            int cardNumber = 13;
            string cardName = cardNumber switch
            {
                13 => "King",
                12 => "Queen",
                11 => "Jack",
                _ => "Pip card"
            };

            Console.WriteLine($"{cardNumber} - {cardName}");
        }

        private static void TestIndex()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lasElement = vowels[^1];
            char secondElement = vowels[^2];
            char[] firstTwo = vowels[..2];
            char[] middleOne = vowels[2..3];
            char[] lastTwo = vowels[^2..];

            Index last = ^1;
            Range firstTowRange = 0..2;
            char[] firstTwo2 = vowels[firstTowRange];

            Console.WriteLine(lasElement);
            Console.WriteLine(secondElement);
            Console.WriteLine(firstTwo);
            Console.WriteLine(middleOne);
            Console.WriteLine(lastTwo);
            Console.WriteLine(firstTwo2);
        }

        public static void RectangleTest()
        {
            var rectangle = new Rectangle(3, 4);
            (float width, float heigth) = rectangle;
            Console.WriteLine(width + " - " + heigth);
        }

        public static void BunnyTest()
        {
            Bunny b1 = new Bunny { Name = "Bo", LikeCarrots = true, LikeHumans = false };
            Bunny b2 = new Bunny("Bo") { LikeCarrots = true, LikeHumans = false };
            Bunny b3 = new Bunny(name: "Bo", likeCarrots: false);
        }

        public static void FooTest()
        {
            Foo foo = new Foo();
            foo.X = 10;

            Console.WriteLine($"Value: {foo.X}");
        }
    }
}
