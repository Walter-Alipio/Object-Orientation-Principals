using bytebank_AMD.Employees;

public class Assistant : bytebank_AMD.Employees.Employer
{
  public Assistant(string name, string cpf) : base(name, cpf, 2000)
  { }
  public override void increaseSalary()
  {
    base.Salary *= 0.1;
  }
  public override double getBonus()
  {
    return Salary *= 0.20;
  }

  public override double semestralPrize()
  {
    return Salary + base.semestralPrize();
  }
}