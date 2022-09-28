
using bytebank.Holder;

namespace bytebank
{
  public class CheckingAccount
  {
    public Customer Holder { get; set; }
    private int Account { get; }
    private int Agency { get; }
    private double _balance;
    public int CounterWithDrawNotAllowed { get; private set; }
    public int CounterTransferNotAllowed { get; private set; }

    public static int TotalCreatedAccount { get; private set; }
    public static double OperationalTax { get; private set; }

    public CheckingAccount(Customer holder, int account, int agency)
    {
      Holder = holder;
      Account = account;
      Agency = agency;
      if (account <= 0)
      {
        throw new ArgumentException($"{nameof(account)} deve ser diferentes de zero.");
      }

      if (agency <= 0)
      {
        throw new ArgumentException($"{nameof(agency)} deve ser diferentes de zero.");
      }

      TotalCreatedAccount++;
      OperationalTax = 30 / TotalCreatedAccount;
    }

    public void withDraw(double value)
    {
      if (_balance < value)
      {
        CounterWithDrawNotAllowed++;
        throw new NotEnoughBalanceException(_balance, value);
      }
      if (value < 0)
      {
        CounterWithDrawNotAllowed++;
        throw new ArgumentException("Valor do saque não pode ser negativo", nameof(value));
      }
      _balance = _balance - value;
    }

    public void deposit(double value)
    {
      if (value < 0)
      {
        throw new ArgumentException("Valor do depósito não pode ser negativo!");
      }
      _balance += value;
    }

    public void transfer(double value, CheckingAccount destiny)
    {

      try
      {
        withDraw(value);
      }
      catch (NotEnoughBalanceException ex)
      {
        CounterTransferNotAllowed++;
        throw new FinantialOperationExcepetion($"Operação não realizada{ex}");
      }
      destiny.deposit(value);
    }
    public double Balance
    {
      get
      {
        return _balance;
      }
      private set
      {
        if (value < 0)
        {
          return;
        }
        _balance = value;
      }
    }
  }


}