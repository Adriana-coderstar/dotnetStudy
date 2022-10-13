using SalaryCalculation.Entities.Enums;
using System.Collections.Generic;

namespace SalaryCalculation.Entities {
  public class Worker {
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
  }
}