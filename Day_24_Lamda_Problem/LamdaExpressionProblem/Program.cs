// See https://aka.ms/new-console-template for more information

namespace LamdaExpressionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lamda Expression Problem");
            List<Person> listPersonInCity = new List<Person>();
            listPersonInCity.Add(new Person("897865689","Shivaraj","12 Basaveshwarnagar",14));
            listPersonInCity.Add(new Person("897865690", "Arun", "122 Peenya", 35));
            listPersonInCity.Add(new Person("897865691", "Mahesh", "124 KaveriNagar", 65));
            listPersonInCity.Add(new Person("897865692", "Deepak", "125 Bayaly", 36));
            listPersonInCity.Add(new Person("897865693", "Pramod", "127 eshwarnagar", 68));
            listPersonInCity.Add(new Person("897865694", "Vinay", "129 KHB", 62));
            listPersonInCity.Add(new Person("897865695", "Soma", "126 Tollgate", 17));
            listPersonInCity.Add(new Person("897865696", "Vijay", "128 Mysore", 58));
            listPersonInCity.Add(new Person("897865697", "Cheluvesh", "124 Vijayanagar", 75));


            //UC-2
            Console.WriteLine("Retrieving Top Two Aged persons From List Who Are Older Than 60 Years: ");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
            }
        }
    }
}

