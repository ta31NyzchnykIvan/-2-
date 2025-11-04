using FinancePlanner;

var planner = new PersonalFinancePlanner();

Console.WriteLine("Ласкаво просимо до вашого планувальника фінансів!");
Console.WriteLine("Команди:");
Console.WriteLine("  income <сума>  — додати дохід");
Console.WriteLine("  expense <сума> — додати витрату");
Console.WriteLine("  balance        — показати баланс");
Console.WriteLine("  exit           — вийти з програми");

while (true)
{
    Console.Write("\nВведіть команду: ");
    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input))
        continue;

    var parts = input.Split(' ');
    var command = parts[0].ToLower();

    try
    {
        switch (command)
        {
            case "income":
                if (parts.Length < 2 || !decimal.TryParse(parts[1], out var incomeAmount))
                {
                    Console.WriteLine("Неправильна команда. Спробуйте: income 1000");
                    break;
                }
                planner.AddIncome(incomeAmount);
                break;

            case "expense":
                if (parts.Length < 2 || !decimal.TryParse(parts[1], out var expenseAmount))
                {
                    Console.WriteLine("Неправильна команда. Спробуйте: expense 500");
                    break;
                }
                planner.AddExpense(expenseAmount);
                break;

            case "balance":
                Console.WriteLine($"Поточний баланс: {planner.GetBalance()} грн");
                break;

            case "exit":
                Console.WriteLine("Дякуємо за використання планувальника. До побачення!");
                return;

            default:
                Console.WriteLine("Невідома команда. Використовуйте: income, expense, balance, exit");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }
}