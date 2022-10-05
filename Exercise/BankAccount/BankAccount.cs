using System.Globalization;
class BankAccount {
  public int AccountNumber { get; private set; }
  public string NameHolder { get; set; }
  
  public double AccountBalance { get; private set;}

  public BankAccount(int account, string holder) {
    AccountNumber = account;
    NameHolder = holder;
  }
  public BankAccount(int account, string holder, double currentBalance): this(account, holder) {
    AccountBalance = currentBalance;
  }

  public override string ToString()
  {
    return ($"Account: {AccountNumber}, Holder: {NameHolder}, Current balance: {AccountBalance.ToString("F2", CultureInfo.InvariantCulture )}");
  }

}