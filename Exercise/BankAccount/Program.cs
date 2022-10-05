using System.Globalization;
class Program {
  static void Main(string[] args) {
    Console.Write("Enter account number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Enter name of holder: ");
    string holder = Console.ReadLine();

    Console.Write("Will have initial deposit (y/n)? ");
    char answer = char.Parse(Console.ReadLine());

    if ( answer == 'y' || answer == 'Y') {
      Console.Write("Enter initial deposit amount: ");
      double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
  }
}