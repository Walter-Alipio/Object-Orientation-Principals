using bytebank_AMD.Employees;

namespace bytebank_AMD.Employees
{
  public class Developer : Employer
  {
    public Developer(string name, string cpf) : base(name, cpf, 3000)
    { }

    public override double getBonus()
    {
      return Salary * 0.1;
    }

    public override void increaseSalary()
    {
      this.Salary *= 0.15;
    }
  }
}