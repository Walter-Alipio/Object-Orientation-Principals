using bytebank_ADM.InterSystem;

namespace bytebank_AMD.Employees
{
  public abstract class AuthenticableEmployer : Employer, IAuthenticable
  {
    public AuthenticableEmployer(string name, string cpf, double salary) : base(name, cpf, salary)
    { }
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
  }
}