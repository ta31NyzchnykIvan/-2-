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
            if (amount <= 0) throw new ArgumentException("Сума доходу має бути додатною.");
            _balance += amount;
        }

        public void AddExpense(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сума витрат має бути додатною.");
            _balance -= amount;
        }
    }
    
}