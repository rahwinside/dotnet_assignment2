using System;
namespace Asst2
{
    public class Program6
    {
        public static void MainX(string[] args)
        {
            EmployeeX e = new EmployeeX();
            String gender = Console.ReadLine();
            double income = double.Parse(Console.ReadLine());

            e.setInformation(gender, income);
            e.showInformation();
            Console.WriteLine(e.calculateTax());
        }
    }

    interface Customer {
        void setInformation(String gender, double income);
        void showInformation();
    }

    internal class EmployeeX : Customer
    {
        String gender;
        double income;

        public void setInformation(string gender, double income)
        {
            this.gender = gender;
            this.income = income;
        }

        public void showInformation()
        {
            Console.WriteLine(this.gender);
            Console.WriteLine(this.income);
        }

        public double calculateTax() {
            double tax = 0;
            if (this.gender == "Male") {
                if (this.income <= 190000) {
                    tax = 0;
                }
                else if (this.income <= 200000) {
                    tax = 0.1 * this.income;
                }
                else if (this.income <= 500000)
                {
                    tax = 0.2 * this.income;
                }
                else
                {
                    tax = 0.25 * this.income;
                }
            }
            else {
                if (this.income <= 190000)
                {
                    tax = 0;
                }
                else if (this.income <= 200000)
                {
                    tax = 0;
                }
                else if (this.income <= 500000)
                {
                    tax = 0.1 * this.income;
                }
                else
                {
                    tax = 0.2 * this.income;
                }
            }
            return tax;
        }
    }
}
