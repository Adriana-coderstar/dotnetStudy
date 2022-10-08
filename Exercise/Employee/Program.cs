using System.Globalization;
using System.Collections.Generic;

class Program {
  static void Main(string[] args) {
    Console.Write("How many employees will be registered? ");
    int n = int.Parse(Console.ReadLine());

    List<Employee> list = new List<Employee>();

    for (int i = 1; i <= n; i++) {
      Console.WriteLine($"Emplyoee #{i}: ");

      Console.Write("Id: ");
      int id = int.Parse(Console.ReadLine());

      Console.Write("Name: ");
      string name = Console.ReadLine();

      Console.Write("Salary: ");
      double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      list.Add(new Employee(id, name, salary));

      Console.WriteLine();
    }

    Console.Write("Enter the employee id that will have salary increase : ");
    int searchId = int.Parse(Console.ReadLine());

    Employee emp = list.Find(x => x.Id == searchId);

    if (emp != null) {
      Console.Write("Enter the percentage: ");
      double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      emp.SalaryIncrease(percentage);
    } else {
      System.Console.WriteLine("This id does not exist!");
    }

    Console.WriteLine();

    foreach (Employee obj in list) {
      Console.WriteLine(obj);
    }
  }
}