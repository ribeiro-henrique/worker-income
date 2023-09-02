using Delivery.Entities;
using Delivery.Entities.Enums;
using System.Threading.Channels;

namespace Delivery {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Write the department name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter the worker data:");

            Console.Write("Name: ");
            string wName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel wLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double bSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(depName);
            Worker laborer = new Worker(wName, wLevel, bSalary, dept);

            Console.Write("How many contracts for this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Enter the #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());

                Console.Write("Contract duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, duration);
                laborer.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter the month and year to calculate the total income (MM/YYYY): ");
            string bothData = Console.ReadLine();
            int month = int.Parse(bothData.Substring(0, 2));
            int year = int.Parse(bothData.Substring (3));

            Console.WriteLine($"Name: {laborer.Name}");
            Console.WriteLine($"Department: {laborer.Department.Name}");
            Console.WriteLine($"Incoming for {bothData}: {laborer.Income(year, month)}");



        }
    }
}