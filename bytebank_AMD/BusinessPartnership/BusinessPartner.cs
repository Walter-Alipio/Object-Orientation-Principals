using bytebank_ADM.InterSystem;

namespace bytebank_ADM.BusinessPartnership
{
  public class BusinessPartner : IAuthenticable, IBonification
  {
    public string LoginName { get; set; }
    public string Password { get; set; }
    public bool Authenticate(string loginName, string password)
    {
      if (this.LoginName == loginName && this.Password == password)
      {
        return true;
      }
      return false;
    }

    public double getBonus()
    {
      return 100;
    }

    public bool Login(BusinessPartner employer, string loginName, string password)
    {
      bool authenticatedUser = employer.Authenticate(loginName, password);
      if (!authenticatedUser)
      {
        System.Console.WriteLine("Usuário ou senha incorreta.");
        return false;
      }
      System.Console.WriteLine("Bem vindo(a) ao sistema.");
      return true;
    }
  }
}