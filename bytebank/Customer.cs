namespace bytebank.Holder
{
  public class Customer
  {
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string Occupation { get; set; }
    public static int TotalRegistredCustomers { get; set; }

    public Customer(string name, string cpf, string occupation)
    {
      Name = name;
      Cpf = cpf;
      Occupation = occupation;

      TotalRegistredCustomers += 1;
    }
  }
}