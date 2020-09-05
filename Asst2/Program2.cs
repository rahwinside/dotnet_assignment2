using System;
namespace Asst2
{
    public class Program2
    {
        public static void MainX(string[] args)
        {
            String name = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            int hr = int.Parse(Console.ReadLine());
            int hw = int.Parse(Console.ReadLine());

            HourlyEmployee he = new HourlyEmployee(name, id, hr, hw);
            Console.WriteLine(he.id);
            Console.WriteLine(he.name);
            Console.WriteLine(he.getGrosspay());
        }
    }

    class HourlyEmployee : Employee{
        int hourlyRate;
        int hoursWorked;

        public HourlyEmployee(String NAME, int ID, int HR, int HW) : base(NAME, ID)
        {
            this.hourlyRate = HR;
            this.hoursWorked = HW;
        }

        public int getGrosspay() {
            return hourlyRate * hoursWorked;
        }
    }

    class Employee {
        public String name;
        public int id;

        public Employee(String name, int id) {
            this.name = name;
            this.id = id;
        }
    }
}
