using bytebank_AMD.Employees;

namespace bytebank_AMD.Utilits
{
  public class BonusManager
  {
    public double TotalBonus { get; set; }

    public void Register(Employees.Employer employer)
    {
      TotalBonus += employer.getBonus();
    }
    public double getBonus()
    {
      return TotalBonus;
    }
  }
}