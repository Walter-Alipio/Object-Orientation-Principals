

namespace bytebank_ADM.InterSystem
{
  public class InterSystem
  {
    public bool Login(IAuthenticable employer, string loginName, string password)
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