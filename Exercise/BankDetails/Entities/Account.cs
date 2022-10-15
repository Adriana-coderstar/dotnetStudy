
namespace BankDetails.Entities {
  public class Account {
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }
  }
}