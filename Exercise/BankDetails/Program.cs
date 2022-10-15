using BankDetails.Entities;

namespace BankDetails {
  public class Program {
    static void Main(string[] args) {
      BusinessAccount account = new BusinessAccount(8050, "Bob Brown", 100.00, 500.00);

      Console.WriteLine($"Number account:{account.Number}");
      Console.WriteLine($"Holder: {account.Holder}");
      Console.WriteLine($"Balance: {account.Balance}");
      Console.WriteLine($"LoanLimit: {account.LoanLimit}");
    }
  }
}