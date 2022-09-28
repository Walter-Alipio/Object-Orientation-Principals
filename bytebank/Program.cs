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
      123452,
      23
      );

    Customer customer2 = new Customer("Maria",
      "12442113",
      "Mercenária");

    try
    {
      CheckingAccount account2 = new CheckingAccount(
        customer2,
        232322,
        33
      );

      account2.deposit(150);
    }
    catch (ArgumentException err)
    {
      System.Console.WriteLine(err.StackTrace);
      System.Console.WriteLine(err.Message);
      System.Console.WriteLine(err.ParamName);
    }
    catch (FinantialOperationExcepetion ex)
    {
      System.Console.WriteLine(ex.Message);
      System.Console.WriteLine(ex.StackTrace);

      System.Console.WriteLine("Exceção do tipo INNER EXCEPTION (exceção interna)");

      System.Console.WriteLine(ex.InnerException.Message);
      System.Console.WriteLine(ex.InnerException.StackTrace);
    }

    LoadAccounts();
    System.Console.WriteLine(account1.ToString());
    Console.ReadKey();
  }

  private static void LoadAccounts()
  {
    ReadFiles file = null;
    try
    {
      file = new ReadFiles("contas.txt");
      file.ReadNextLine();
      file.ReadNextLine();
      file.ReadNextLine();
    }
    catch (FileNotFoundException ex)
    {
      System.Console.WriteLine(ex.Message);
    }
    catch (IOException ex)
    {
      System.Console.WriteLine(ex.Message);
    }
    finally
    {
      if (file != null)
        file.Close();
    }
  }
}
