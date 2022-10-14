using SalaryCalculation.Entities.Enums;
using System.Collections.Generic;

namespace SalaryCalculation.Entities {
  public class Worker {
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }

    public Departament Departament { get; set; }
    public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

    public Worker() {}

    public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) {
      Name = name;
      Level = level;
      BaseSalary = baseSalary;
      Departament = departament;
    }

    public void addContract(HourContract contract) {
      Contracts.Add(contract);
    }
  }
}