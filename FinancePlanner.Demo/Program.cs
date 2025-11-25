using FinancePlanner;

var planner = new PersonalFinancePlanner();

Console.WriteLine("=== Finance Planner Demo ===");

planner.AddIncome(1000);
planner.AddExpense(200);
planner.AddExpense(50);
planner.AddIncome(300);

Console.WriteLine($"Balance: {planner.GetBalance()}");