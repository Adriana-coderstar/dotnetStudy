using System.Globalization;
using System.Collections.Generic;
using SalaryCalculation.Entities.Enums;
using SalaryCalculation.Entities;

namespace SalaryCalculation {
  public class Program {
    static void Main(string[] args) {
      Console.Write("Enter department's name: ");
      string departamentName = Console.ReadLine();
      Console.WriteLine("Enter worker data: ");

      Console.Write("Name: ");
      string name = Console.ReadLine();
      
      Console.Write("Level (Junior/Pleno/Senior): ");
      WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

      Console.Write("Base salary: ");
      double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Departament dept = new Departament(departamentName);

      Worker worker = new Worker(name, level, salary, dept);

      Console.Write("How many contracts to this worker? ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i <= n; i ++) {
        Console.WriteLine($"Enter #{i} contract data: ");

        Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Duration (hours): ");
        int hours = int.Parse(Console.ReadLine());

      }
    }
  }
}