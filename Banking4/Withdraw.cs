public class Withdraw
{
    private Account _account;
    private decimal _amount;
    private bool _success = false;
    public bool Success
    {
        get
        {
            return _success;
        }
    }
    public Withdraw(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }
    public void Execute()
    {
        _success = _account.Withdraw(_amount);
    }
    public void Print()
    {
        // print here
    }
}