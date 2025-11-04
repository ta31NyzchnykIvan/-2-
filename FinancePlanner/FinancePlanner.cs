namespace FinancePlanner
{
    public class PersonalFinancePlanner
    {
        private decimal _balance;

        public decimal GetBalance()
        {
            return _balance;
        }

        public void AddIncome(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сума доходу має бути додатною.");
            _balance += amount;
            Console.WriteLine($"Додано дохід: {amount} грн. Поточний баланс: {_balance} грн");
        }

        public void AddExpense(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сума витрат має бути додатною.");

            if (amount > _balance)
                throw new InvalidOperationException("Витрата не може перевищувати поточний баланс.");

            _balance -= amount;
            Console.WriteLine($"Додано витрату: {amount} грн. Поточний баланс: {_balance} грн");
        }

    }
}