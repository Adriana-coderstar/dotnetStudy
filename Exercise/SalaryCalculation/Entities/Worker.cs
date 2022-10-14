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

    public void removeContract(HourContract contract) {
      Contracts.Remove(contract);
    }

    public double Income(int year, int moth) {
      double sum = BaseSalary;

      foreach (HourContract contract in Contracts) {
        if (contract.Date.Year == year && contract.Date.Month == moth) {
          sum += contract.TotalValue();
        }
      }
      return sum;
    }
  }
}