using System;
using System.Text;

namespace LanguageBasics
{
    class Program
    {
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

            string a, b;
            Split("Stevie Ray Vaughan", out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();

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

    }
}
