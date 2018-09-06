using System;

namespace CSharp7.Literals
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Run();

        private void Run()
        {
            Example1();
            Example2();
            Example3();
            Example4();
        }

        private void Example1()
        {
            int value = 25758345;
        }

        private void Example2()
        {
            int value = 25_758_345;
        }

        private void Example3()
        {
            int value1 = 25_75_83_45;
            int value2 = 25______7_5_8___________345;

            // Following will not compile
            // int value3 = _1234;
            // int value4 = 1234_;
        }

        private void PrintValue(long value) => System.Console.WriteLine($"DEC={value} HEX={Convert.ToString(value, 16)} BIN={Convert.ToString(value, 2)}");

        private void Example4()
        {
            var hexMask1 = 0xDEAD_C0DE;
            var binaryMask1 = 0b1101_1110_1010_1101___1100_0000_1101_1110;
            PrintValue(hexMask1);
            PrintValue(binaryMask1);

            var hexMask2 = 0xBAD_C0FFEE;
            var binaryMask2 = 0b1011_1010_1101___1100_0000_1111_1111_1110_1110;
            PrintValue(hexMask2);
            PrintValue(binaryMask2);
        }
    }
}
