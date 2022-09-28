
public class NotEnoughBalanceException : FinantialOperationExcepetion
{
  public double Balance { get; }
  public double WithDrawValue { get; }

  public NotEnoughBalanceException() { }
  public NotEnoughBalanceException(string message) : base(message)
  { }
  public NotEnoughBalanceException(double balance, double withDrawValue)
    : this($"Tentativa de saque de {withDrawValue}, saldo insufuciente!")
  {
    Balance = balance;
    WithDrawValue = withDrawValue;
  }
}