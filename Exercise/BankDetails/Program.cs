using BankDetails.Entities;

namespace BankDetails {
  public class Program {
    static void Main(string[] args) {
      Account acc1 = new Account(8050, "Bob Brown", 500.0);

      Account acc2 = new SavingAccount(1040, "Anna", 500.0, 0.01);

      acc1.Withdraw(10.00);
      acc2.Withdraw(10.00);

      Console.WriteLine($"Balance Account Acc1:{acc1.Balance}");
      Console.WriteLine($"Balance Account Acc2: {acc2.Balance}");
    }
  }
}