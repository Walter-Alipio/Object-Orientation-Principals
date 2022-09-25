using bytebank_ADM.InterSystem;
using bytebank_AMD.Employees;
using bytebank_AMD.Utilits;
using bytebank_ADM.BusinessPartnership;

internal class Program
{
  private static void Main(string[] args)
  {
    // Console.WriteLine("Hello, World!");

    // BonusManager bonusManager = new();
    // Assistant assitant1 = new Assistant("João", "123.321.423-71");
    // System.Console.WriteLine($"Total de funcionários: {Assistant.TotalEmployers}");

    // Principal principal1 = new Principal("Marta", "432,234,565-34");

    // Designer designer1 = new Designer("Rita", "657.544.345-87");

    // AccountManager accountManager1 = new AccountManager("Tadeu", "234.512.241-23");

    // Developer developer1 = new Developer("Samya", "234.512.241-23");
    // System.Console.WriteLine($"Total de funcionários: {Assistant.TotalEmployers}");



    // System.Console.WriteLine(assitant1.getBonus());
    // System.Console.WriteLine(principal1.getBonus());

    // bonusManager.Register(assitant1);
    // bonusManager.Register(principal1);
    // bonusManager.Register(designer1);
    // bonusManager.Register(accountManager1);
    // bonusManager.Register(developer1);

    //System.Console.WriteLine($"Total de bonificações: {bonusManager.getBonus()}");

    void useSystem()
    {
      InterSystem interSystem = new();

      Principal principal1 = new Principal("Marta", "432,234,565-34");
      principal1.LoginName = "marta@corporativo.com";
      principal1.Password = "darthvader";

      AccountManager accountManager1 = new AccountManager("Tadeu", "234.512.241-23");
      accountManager1.LoginName = "tadeu@corporativo.com";
      accountManager1.Password = "admin.admin";

      interSystem.Login(principal1, "marta@corporativo.com", "darthvader");
      interSystem.Login(accountManager1, "tadeu@corporativo.com", "admin.admin");


      BusinessPartner businessPartner1 = new();
      businessPartner1.LoginName = "joao@corporativo.com";
      businessPartner1.Password = "123deoliveira4";

      interSystem.Login(businessPartner1, "joao@corporativo.com", "123deoliveira4");

    }

    useSystem();
  }
}