using System;

namespace Class
{

    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);

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
            banana.Introduce();

        }
    }
}
