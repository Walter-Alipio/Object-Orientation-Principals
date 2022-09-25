using bytebank_ADM.InterSystem;
using bytebank_AMD.Employees;

public class AccountManager : AuthenticableEmployer
{

  public AccountManager(string name, string cpf) : base(name, cpf, 4000)
  { }
  public override void increaseSalary()
  {
    base.Salary *= 0.05;
  }
  public override double getBonus()
  {
    return Salary *= 0.25;
  }

  public override double semestralPrize()
  {
    return Salary + base.semestralPrize();
  }
}