using System.Text;
using System.Runtime.Serialization.Json;
using bytebank;
using bytebank.Holder;


public class Program
{
  public static void Main(string[] args)
  {
    Customer customer1 = new Customer("Carlos",
      "12332112",
      "Mercenário");

    CheckingAccount account1 = new CheckingAccount(
      customer1,
      "12345-2",
      23,
      "Agencia central"
      );

    System.Console.WriteLine(account1);
  }
}

//Console.ReadKey();