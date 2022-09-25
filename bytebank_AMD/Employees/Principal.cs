using System;
using bytebank_ADM.InterSystem;

namespace bytebank_AMD.Employees
{
  public class Principal : AuthenticableEmployer
  {
    public Principal(string name, string cpf)
        : base(name, cpf, 5000)
    { }
    public override void increaseSalary()
    {
      base.Salary *= 0.15;
    }
    public override double getBonus()
    {
      return Salary += 0.5;
    }

    public override double semestralPrize()
    {
      return Salary + base.semestralPrize();
    }
  }
}