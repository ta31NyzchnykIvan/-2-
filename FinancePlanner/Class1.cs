namespace FinancePlanner
{
    public class PersonalFinancePlanner
    {
        private decimal _balance = 0;

        public decimal GetBalance()
        {
            return _balance;
        }
        public void AddIncome(decimal amount)
        {
            _balance += amount;
        }
        public void AddExpense(decimal amount)
        {
            _balance -= amount;
        }

    }
    
}