/*
    1. Problem 1 - (A)
    Create an Object with a "hello" method that writes "Hello <name> in the console"
*/
using System.Diagnostics;

namespace Test_1_Jose_Arias
{
    internal class Class
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Solution to problem 1A");
            //Solution to problem 1A
            Object obj = new Object();
            Console.WriteLine(obj.Hello());
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Solution to problem 2");
            Object2 obj2 = new Object2();
            obj2.Logs();

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
        /*
        2. Problem 1 - (B)
        How would you make name inmutable?
        (Can write or just describe)
    */
        //
        // ANSWER: To make "name" inmutable you will need to write readonly when creating the atribute, the code will look like this:

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

        /* Problem 2
   Write a funtion that logs the 5 cities that occur the most in the array below in
   order from the most number of occurrences to least.
    */
        public class Object2
    {
            //Solution to problem 2
        private string[] citiesList = {
                "nasville",
                "nasville",
                "los angeles",
                "nasville",
                "Madrid",
                "memphis",
                "barcelona",
                "los angeles",
                "sevilla",
                "Madrid",
                "canary islands",
                "barcelona",
                "Madrid",
                "Madrid",
                "nasville",
                "barcelona",
                "london",
                "berlin",
                "Madrid",
                "nasville",
                "london",
                "Madrid",
                "Madrid",
            };
        public void Logs()
        {
            //Use a dictionary to store the name of the city and the count of how many times it apears on the list
            Dictionary<String, int> cities = new Dictionary<String, int>()
            {
                {"nasville", 0},
                {"los angeles", 0 },
                {"Madrid", 0 },
                {"memphis", 0 },
                {"barcelona", 0 },
                {"sevilla", 0 },
                {"canary islands", 0 },
                {"london", 0 },
                {"berlin",0 }

            };
            foreach (string city in citiesList)
            {
                //Start filling the dictionary with the information
                switch (city)
                {
                    case "nasville":
                        cities["nasville"] += 1;
                        break;
                    case "los angeles":
                        cities["los angeles"] += 1;
                        break;
                    case "Madrid":
                        cities["Madrid"] += 1;
                        break;
                    case "memphis":
                        cities["memphis"] += 1;
                        break;
                    case "barcelona":
                        cities["barcelona"] += 1;
                        break;
                    case "sevilla":
                        cities["sevilla"] += 1;
                        break;
                    case "canary islands":
                        cities["canary islands"] += 1;
                        break;
                    case "london":
                        cities["london"] += 1;
                        break;
                    case "berlin":
                        cities["berlin"] += 1;
                        break;

                }

            

            }

            //Sort the dictionary from most to least
            var sortedCities = from item in cities orderby item.Value descending select item;

            //Transform Dict to List so we can only select the first 5 of the list
            List<KeyValuePair<string, int>> keys = sortedCities.ToList();

            //Print those 5
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(keys[i]);
            }


            return;
        }
    }
}



