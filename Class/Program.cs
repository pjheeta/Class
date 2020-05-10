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
        public static void banana(string Jandu)
        {
            Console.WriteLine("Hello There!");
            Console.WriteLine("Heneral {0}!", Jandu);
        }
    }

    public class Amigo
    {
        public static string Name2;
        public static Amigo createAmigo(string borracha)
        {
            Amigo borracho = new Amigo();
            Name2 = borracha;// Amigo.Name2 = borracha;
            return borracho;
        }

        public static void printName(string tutty)
        {
            Console.WriteLine("Hi {0}!, I'm {1}!", tutty, Name2);

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
            Person.banana("Kenobi");
            Amigo.createAmigo("Tutty");
            Amigo.printName("Kutha");
        }
    }
}
