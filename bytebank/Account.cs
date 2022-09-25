
using bytebank.Holder;

namespace bytebank
{
  public class CheckingAccount
  {
    public Customer Holder { get; set; }
    private string _account;
    private int _agency;
    public string AgencyName { get; set; }
    private double _balance;

    public CheckingAccount(Customer holder, string account, int agency, string agencyName)
    {
      Holder = holder;
      Account = account;
      Agency = agency;
      AgencyName = agencyName;
    }


    public bool withDraw(double value)
    {
      if (_balance < value || value < 0)
      {
        return false;
      }
      _balance = _balance - value;
      return true;
    }

    public bool deposit(double value)
    {
      if (value < 0)
      {
        return false;
      }
      _balance += value;
      return true;
    }

    public bool transfer(double value, CheckingAccount destiny)
    {

      if (_balance < value || value < 0)
      {
        return false;
      }

      _balance -= value;
      destiny._balance += value;
      return true;
    }
    public string Account
    {
      get
      {
        return _account;
      }
      set
      {
        if (value == null)
        {
          return;
        }
        _account = value;
      }
    }
    public int Agency
    {
      get
      {
        return _agency;
      }
      set
      {
        if (value <= 0)
        {
          return;
        }
        _agency = value;
      }
    }
    public double Balance
    {
      get
      {
        return _balance;
      }
      set
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