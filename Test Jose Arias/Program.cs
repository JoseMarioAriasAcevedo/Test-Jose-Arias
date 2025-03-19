/*
    1. Problem 1 - (A)
    Create an Object with a "hello" method that writes "Hello <name> in the console"
*/
namespace Test_1_Jose_Arias
{
    internal class Class
    {
        static void Main(String[] args)
        {
            //Solution to problem 1A
            Object obj = new Object();
            Console.WriteLine(obj.Hello());

        }
    }
    public class Object
    {
        public string a = "Hello ";
        public readonly string name = "Jose";

        public string Hello()
        {
            return a + name;
        }
    }
}

// Solution 1B
// To make "name" inmutable you will need to write readonly when creating the atribute, the code will look like this:

/*namespace Test_1_Jose_Arias
{
    internal class Class
    {
        static void Main(String[] args)
        {
            //Solution to problem 1A
            Object obj = new Object();
            Console.WriteLine(obj.Hello());

        }
    }
    public class Object
    {
        public string a = "Hello ";
        public readonly string name = "Jose";

        public string Hello()
        {
            return a + name;
        }
    }
}
*/