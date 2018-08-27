namespace CSharp7.Discards
{
    public class Program
    {
        public static void Main(string[] args) => new Program().Run();

        public void Run()
        {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
            Example7();
            Example8();
            Example9();
        }

        // Let's have a method that returns a value
        private int DoSomethingAndReturnValue() => 24;

        private void Example1()
        {
            // Get the value
            var myValue = DoSomethingAndReturnValue();

            // Ignore the value
            DoSomethingAndReturnValue();
        }

        private void DoSomethingAndGiveValue(out int value) => value = 42;

        private void Example2()
        {
            int ignoredVariable;
            DoSomethingAndGiveValue(out ignoredVariable);
        }

        private void Example3()
        {
            DoSomethingAndGiveValue(out var ignoredVariable);
        }

        private void Example4()
        {
            DoSomethingAndGiveValue(out int _);
        }

        private void Example5()
        {
            DoSomethingAndGiveValue(out _);

            // The following won't compile as discards is not a variable that one can read from.
            // System.Console.WriteLine("Print discard: " + _);
        }

        private void GetManyValues(out int first, out int second, out int third, out int forth) =>
            first = second = third = forth = 13;

        private void Example6()
        {
            GetManyValues(out _, out int thisOneWeNeed, out _, out _);
        }

        private void Example7()
        {
            // Here is the simplest discard example
            _ = 1 + 2;

            // The following still won't work
            // System.Console.WriteLine("Try print discard again: " + _);
        }

        private void Example8()
        {
            var tuple = (1, 1, 2, 3, 5, 8);
            (_, _, _, _, var fifth, _) = tuple;
        }

        private void Example9()
        {
            object x = 13;
            if (x is var _)
            {
                // Still can't use discard as variable :)
                // System.Console.WriteLine("Print: " + _);
            }
        }
    }
}
