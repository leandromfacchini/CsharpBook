using System;
using System.Text;

namespace LanguageBasics
{
    internal static class Program
    {
        static int x;

        static string X = "Old Value";

        static ref string GetX() => ref X;

        static void Main(string[] args)
        {
            // int x = 12 * 30;

            // Console.WriteLine(x);

            // Console.WriteLine(FeetToInches(30));
            // Console.WriteLine(FeetToInches(100));

            // UnitConvert feetToInchesConverter = new UnitConvert(12);
            // UnitConvert milesToFeetConverter = new UnitConvert(5280);

            // Console.WriteLine(feetToInchesConverter.Convert(30));//360
            // Console.WriteLine(feetToInchesConverter.Convert(100));//1200

            // Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));//63360


            // Panda p1 =  new Panda("Pan Dee");
            // Panda p2 = new Panda("Pan Dah");

            // Console.WriteLine(p1.Name);
            // Console.WriteLine(p2.Name);

            // Console.WriteLine(Panda.Population);

            //VALUES TYPES

            // StrunctPoint p1 = new StrunctPoint
            // {
            //     x = 7,
            //     y = 7
            // };

            // StrunctPoint p2 = p1;

            // Console.WriteLine(p1.x);
            // Console.WriteLine(p2.x);

            // p1.x = 9;

            // Console.WriteLine(p1.x);
            // Console.WriteLine(p2.x);

            //REFERENCE TYPES

            // Point p1 = new Point();
            // p1.x = 7;

            // Point p2 = p1;

            // Console.WriteLine(p1.x);
            // Console.WriteLine(p2.x);

            // p1.x = 9;

            // Console.WriteLine(p1.x);
            // Console.WriteLine(p2.x);

            // NumericLiteralsExamples();

            // RectangularArrays();

            // var value = Factorial(10);
            // Console.WriteLine(value);

            // HeapMemoryExample();

            // int x = 8;
            // Foo(x);
            // Console.WriteLine(x);

            // StringBuilder sb = new StringBuilder();
            // Foo(sb);
            // Console.WriteLine(sb.ToString());

            // int x = 8;
            // Foo(ref x);
            // Console.WriteLine(x);

            // string x = "Penn";
            // string y = "Teller";
            // Swap(ref x, ref y);
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // string a, b;
            // Split("Stevie Ray Vaughan", out a, out b);
            // Console.WriteLine(a);
            // Console.WriteLine(b);

            // FooOut(out x);

            // int total = Sum(1, 2, 3, 4);
            // int total = Sum(new int[] { 1, 2, 3, 4 });
            // Console.WriteLine(total);

            // OptionalParameters();
            // OptionalParameters(11);

            // OptionalParametersTwo();
            // OptionalParametersTwo(1);
            // OptionalParametersTwo(2, 3);

            // int a = 0;
            // NamedArguments(x: 10, y: 12);
            // NamedArguments(y: ++a, x: --a);

            // int[] numbers = new int[] { 0, 1, 2, 3, 4 };
            // ref int numRef = ref numbers[2];
            // Console.WriteLine(numRef);

            // numRef *= 10;
            // Console.WriteLine(numRef);
            // Console.WriteLine(numbers[2]);

            // CreateTeste();

            // Console.Write("Informe uma opção:");
            // string option = Console.ReadLine();

            // SwitchStatement(int.Parse(option));

            // TellMeTheType(12);
            // TellMeTheType("hello");
            // TellMeTheType(true);

            // AnotherSwitch();
            // AnotherSwitch2();

            // ref string xRef = ref GetX();
            // Console.WriteLine(xRef);
            // xRef = "New Value";
            // Console.WriteLine(xRef);

            // ExampleWhileOne();
            // ExampleDoWhile();
            // ExampleFor();
            // ExampleWhile();
            // ExampleForBreak();
            decimal valor = ExampleReturnDecimal();
            Console.WriteLine(valor);

            Console.ReadKey();

        }

        private static decimal ExampleReturnDecimal()
        {
            decimal p = 1000 * 100m;
            return p;
        }

        private static void ExampleForBreak()
        {
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0) continue;

                Console.WriteLine($"{i} ");
            }
        }

        private static void ExampleWhile()
        {
            int x = 0;
            while (true)
            {
                if (x++ > 5) break;

                Console.WriteLine($"Valor: {x}");
            }
        }

        private static void ExampleFor()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void ExampleDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 100);
        }

        private static void ExampleWhileOne()
        {
            int i = 0;
            while (i < 1000)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void AnotherSwitch2()
        {
            var x = 1000;

            // switch (x)
            // {
            //     case float f when f > 1000;
            //     case double d when d > 1000;
            //     case decimal m when m > 1000;
            //         Console.WriteLine("We can refer to x here but not f or d or m");
            //         break;
            // }
        }

        private static void AnotherSwitch()
        {
            var x = true;

            switch (x)
            {
                case bool b when b == true:
                    Console.WriteLine("True");
                    break;
                case bool b:
                    Console.WriteLine("False");
                    break;
            }
        }

        private static void TellMeTheType(object x)
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("it's an int");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }

        private static void SwitchStatement(int option)
        {
            switch (option)
            {
                case 13:
                case 12:
                case 11:
                    Console.WriteLine("Face card");
                    break;
                default:
                    Console.WriteLine("Plain card");
                    break;
            }
        }

        private static void CreateTeste()
        {
            Random random = new Random();
            var r = random.Next();
            Console.WriteLine(r.ToString());
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;

            return inches;
        }

        static void NumericLiteralsExamples()
        {
            int x = int.MaxValue;
            int y = unchecked(int.MaxValue + 1);

            Console.WriteLine(1.0.GetType());//Double
            Console.WriteLine(1E06.GetType());//Double
            Console.WriteLine(1.GetType());//Int32
            Console.WriteLine(0xF0000000.GetType());//UInt32
            Console.WriteLine(0x100000000.GetType());//Int64
        }

        static void RectangularArrays()
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.WriteLine(matrix[i, j]);
        }

        static void JaggedArrays()
        {
            int[][] matrix = new int[3][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = i * 3 + j;
                }
            }
        }

        static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        static void HeapMemoryExample()
        {
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;

            Console.WriteLine(ref3);
        }

        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        static void Foo(StringBuilder fooSb)
        {
            fooSb.Append("test");
            fooSb = null;
        }

        static void Foo(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        static void FooOut(out int y)
        {
            Console.WriteLine(x);
            y = 1;
            Console.WriteLine(x);
        }

        static int Sum(params int[] ints)
        {
            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            return sum;
        }

        static void OptionalParameters(int x = 23)
        {
            Console.WriteLine(x);
        }

        static void OptionalParametersTwo(int x = 0, int y = 0)
        {
            Console.WriteLine(x + " - " + y);
        }

        static void NamedArguments(int x, int y)
        {
            Console.WriteLine(x + " - " + y);
        }
    }
}
