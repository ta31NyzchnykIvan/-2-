namespace FinancePlanner;

public class PersonalFinancePlanner
{
    private decimal balance;

    public PersonalFinancePlanner()
    {
        balance = 0;
    }

    public void AddIncome(decimal amount)
    {
        balance += amount;
    }

    public void AddExpense(decimal amount)
    {
        balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}