using System;

namespace Asst2
{
    class Program
    {
        public static void MainX(string[] args)
        {
            int acc_num = int.Parse(Console.ReadLine());
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            Library lib = new Library();
            lib.setValues(acc_num, title, author);
            lib.display();
            Console.WriteLine(lib.compute(days));
        }
    }

    class Library {
        int acc_num;
        String title;
        String author;

        public void setValues(int acc_num, String title, String author) {
            this.acc_num = acc_num;
            this.title = title;
            this.author = author;
        }

        public int compute(int days) {
            return days * 2;
        }

        public void display() {
            Console.WriteLine(acc_num + " " + title + " " + author);
        }
    }
}
