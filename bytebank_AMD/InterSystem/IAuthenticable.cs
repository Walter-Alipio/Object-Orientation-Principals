
using bytebank_AMD.Employees;

namespace bytebank_ADM.InterSystem
{
  public interface IAuthenticable
  {
    public bool Authenticate(string loginName, string password);

  }
}