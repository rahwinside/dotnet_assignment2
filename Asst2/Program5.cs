using System;
namespace Asst2
{
    public class Program5
    {
        public static void MainX(string[] args)
        {
            Bat bat = new Bat();
            bat.eat();
            bat.breathe();
            bat.flap();
        }
    }

    interface Mammal {
        void breathe();
    }

    interface Animal {
        void eat();
    }

    interface WingedAnimal : Animal {
        void flap();
    }

    class Bat : Mammal, WingedAnimal
    {
        public void breathe()
        {
            Console.WriteLine("Bat can breathe");
        }

        public void eat()
        {
            Console.WriteLine("Bat can eat");
        }

        public void flap()
        {
            Console.Write("Bat can flap");
        }
    }
}
