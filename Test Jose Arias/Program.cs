namespace Test_1_Jose_Arias
{
    internal class Class
    {
        static void Main(String[] args)
        {
            //Solution to problem 1A
            Object obj = new Object();
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine(obj.Hello(name));

        }
    }
    public class Object
    {
        public string a = "Hello ";

        public string Hello(string name)
        {
            return a + name;
        }
    }
}

// Solution 1B
// To make "name" inmutable you will need to write readonly when creating the atribute
