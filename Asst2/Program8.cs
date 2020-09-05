using System;
namespace Asst2
{
    public class Program8
    {
        public static void MainX(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Rank rank = new Rank(n);
            rank.readvalues();
            rank.highest();
            rank.display();
            rank.toString();
        }
    }

    class Record {
        protected String[] names;
        protected int[] ranks;
        protected int num_of_records;

        public Record(int num_of_records) {
            this.num_of_records = num_of_records;
            names = new String[num_of_records];
            ranks = new int[num_of_records];
        }

        public void readvalues() {
            for (int i = 0; i < this.num_of_records; i++) {
                var input = Console.ReadLine();
                names[i] = input.Split()[0];
                ranks[i] = int.Parse(input.Split()[1]);
            }
        }

        public void display() {
            for (int i = 0; i < this.num_of_records; i++)
            {
                Console.WriteLine(names[i] + " " + ranks[i]);
            }
        }
    }

    class Rank : Record {
        int index;

        public Rank(int num_of_records) : base(num_of_records) {
            this.index = 0;
        }

        public void highest() {
            for (int i = 0; i < this.num_of_records; i++)
            {
                if (ranks[i] < ranks[index]) {
                    index = i;
                }
            }
        }

        public void toString() {
            Console.WriteLine(names[index] + " " + ranks[index]);
        }
    }
}
