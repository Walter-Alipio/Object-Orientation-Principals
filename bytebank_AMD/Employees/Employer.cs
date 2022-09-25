namespace bytebank_AMD.Employees
{
  public abstract class Employer
  {
    public string Name { get; private set; }
    public string Cpf { get; private set; }
    public double Salary { get; protected set; }
    public static int TotalEmployers { get; private set; }

    public Employer(string name, string cpf, double salary)
    {
      Name = name;
      Cpf = cpf;
      Salary = salary;
      TotalEmployers++;
    }

    public abstract void increaseSalary();
    public abstract double getBonus();

    public virtual double semestralPrize()
    {
      return Salary * 0.2;
    }

    /*
      ~Employer(){} Metodo destrutor
    */
  }
}