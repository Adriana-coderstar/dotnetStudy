using System.Globalization;
using System.Collections.Generic;
using SalaryCalculation.Entities.Enums;

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
    }
  }
}