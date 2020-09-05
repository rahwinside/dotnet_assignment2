using System;
namespace Asst2
{
    public class Program9
    {
        public static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            int basic = int.Parse(Console.ReadLine());
            int da = int.Parse(Console.ReadLine());
            int ma = int.Parse(Console.ReadLine());
            int oa = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    AssistantProfessor assistantProfessor = new AssistantProfessor(name, basic, da);
                    Console.WriteLine(assistantProfessor.getDetails());
                    break;
                case 2:
                    AssociateProfessor associateProfessor = new AssociateProfessor(name, basic, da, ma);
                    Console.WriteLine(associateProfessor.getDetails());
                    break;
                case 3:
                    Professor professor = new Professor(name, basic, da, ma, oa);
                    Console.WriteLine(professor.getDetails());
                    break;
            }
        }
    }

    class Faculty {
        public String name;
        private int basic;

        public int getBasic() => this.basic;

        public Faculty(String name, int basic) {
            this.name = name;
            this.basic = basic;
        }

        public String getDetails()
        {
            return this.name + " " + this.getSalary();
        }

        public double getSalary() {
            return basic;
        }
    }

    class AssistantProfessor : Faculty {
        public int da;
        public AssistantProfessor(String name, int basic, int da) : base(name, basic) {
            this.da = da;
        }

        public new double getSalary()
        {
            return this.getBasic() + (this.getBasic() * this.da / 100.0f);
        }

        public new String getDetails()
        {
            return "AssiProf " + this.name + " " + this.getSalary();
        }

    }

    class AssociateProfessor : AssistantProfessor
    {
        public int MedAllowance;
        public AssociateProfessor(String name, int basic, int da, int MedAllowance) : base(name, basic, da)
        {
            this.da = da;
            this.MedAllowance = MedAllowance;
        }

        public new double getSalary()
        {
            return this.getBasic() + (this.getBasic() * this.da / 100.0f) + this.MedAllowance;
        }

        public new String getDetails()
        {
            return "AssoProf " + this.name + " " + this.getSalary();
        }

    }

    class Professor : AssociateProfessor
    {
        public int OtherAllowance;
        public Professor(String name, int basic, int da, int MedAllowance, int OtherAllowance) : base(name, basic, da, MedAllowance)
        {
            this.da = da;
            this.MedAllowance = MedAllowance;
            this.OtherAllowance = OtherAllowance;
        }

        public new double getSalary()
        {
            return base.getSalary() + (this.OtherAllowance / 100.0f * base.getSalary());
        }

        public new String getDetails()
        {
            return "Prof " + this.name + " " + this.getSalary();
        }

    }
}
