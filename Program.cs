using System;
using Newtonsoft.Json;

namespace myNewtonSoft
{
    class Program
    {
        static void Main(string[] args)
        {
             Person person = new Person{
                Name = "Farooq",
                Email = "f@f.com",
                DOB = new DateTime(1983, 5, 10, 0, 0, 0, DateTimeKind.Utc),
            };

            Console.WriteLine("Person Info!");
            Console.WriteLine("Name = {0}",person.Name);
            Console.WriteLine("Email = {0}",person.Email);
            Console.WriteLine("Name = {0}\n",person.DOB);

            string personJSON = JsonConvert.SerializeObject(person);

            Console.WriteLine(personJSON);

            Console.WriteLine("Done...!");
        }
    }
}
