using bytebank_AMD.Employees;

public class Designer : bytebank_AMD.Employees.Employer
{
  public Designer(string name, string cpf) : base(name, cpf, 3000)
  { }
  public override void increaseSalary()
  {
    base.Salary *= 0.11;
  }
  public override double getBonus()
  {
    return Salary *= 0.17;
  }

  public override double semestralPrize()
  {
    return Salary + base.semestralPrize();
  }
}