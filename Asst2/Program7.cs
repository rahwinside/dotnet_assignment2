using System;
namespace Asst2
{
    public class Program7
    {
        public static void MainX(string[] args)
        {
            solution();
        }

        static void solution() {
            Object[] array = { new Tiger("Tiger"), new Camel("Camel"), new Deer("Deer"), new Donkey("Donkey") };
            foreach (Object animal in array)
            {
                if (animal is Transport) {
                    var x = animal as Transport;
                    Console.WriteLine(x.deliver());
                }
            }
        }
    }

    interface Transport {
        String deliver();
    }

    abstract class AnimalX {
        public String name;
    }

    class Tiger : AnimalX {
        public Tiger(String name) { this.name = name; }
    }
    class Camel : AnimalX, Transport {
        public Camel(String name) { this.name = name; }

        public string deliver()
        {
            return this.name;
        }
    }
    class Deer : AnimalX {
        public Deer(String name) { this.name = name; }
    }
    class Donkey : AnimalX, Transport {
        public Donkey(String name) { this.name = name; }

        public string deliver()
        {
            return this.name;
        }
    }

}
