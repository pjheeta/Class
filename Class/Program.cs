using System;

namespace Class
{

    public class Person
    {
        public string Name;
        public static int PeopleCount = 0;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);

        }    
        
        public void Introduce2(string newPerson)
        {
            Console.WriteLine("Hi {0}, I am {1}", newPerson, Name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var banana = new Person();
            //You can use 'var' incase your class is big, or if you're lazy

            Console.Write("What is your name? ");
            banana.Name = Console.ReadLine();
            //banana.Introduce();
            banana.Introduce2("Pawan");
            fart.sayHI("Tutty");

        }
    }
}
