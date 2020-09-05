using System;
namespace Asst2
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            int cs = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            Suzuki su = new Suzuki(cs);
            su.increaseSpeed(s);
            su.displaySpeed();
        }
    }

    interface Car {
        void displaySpeed();
        void increaseSpeed(int speed);
    }

    class Suzuki : Car
    {
        int currentSpeed;

        public Suzuki(int cs) {
            this.currentSpeed = cs;
        }

        public void displaySpeed()
        {
            Console.WriteLine(this.currentSpeed);
        }

        public void increaseSpeed(int speed)
        {
            this.currentSpeed += speed;
        }
    }
}
