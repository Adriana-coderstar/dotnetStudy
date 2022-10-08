class Employee {
  public int Id {get; set;}
  public string Name { get; set; }

  public double Salary { get; private set;}

  public Employee(int id, string name, double salary) {
    id = id;
    Name = name;
    Salary = salary;
  }
}