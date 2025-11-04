
using FinancePlanner;

namespace FinancePlanner.Tests
{
    public class FinancePlannerTests
    {
        [Fact]
        public void NewPlanner_ShouldHaveZeroBalance()
        {
            // Arrange + Act
            var planner = new PersonalFinancePlanner();

            // Assert
            Assert.Equal(0, planner.GetBalance());
        }
        [Fact]
        public void AddIncome_ShouldIncreaseBalance()
        {
            var planner = new PersonalFinancePlanner();
            planner.AddIncome(1000);

            Assert.Equal(1000, planner.GetBalance());
        }
        [Fact]
        public void AddExpense_ShouldDecreaseBalance()
        {
            var planner = new PersonalFinancePlanner();
            planner.AddIncome(1000);
            Assert.Equal(1000, planner.GetBalance()); 

            planner.AddExpense(400);
            Assert.Equal(600, planner.GetBalance());
        }

        [Fact]
        public void AddIncome_ShouldThrow_WhenAmountIsNegative()
        {
            var planner = new PersonalFinancePlanner();
            Assert.Throws<ArgumentException>(() => planner.AddIncome(-100));
        }
        [Fact]
        public void AddExpense_ShouldThrow_WhenAmountExceedsBalance()
        {
            var planner = new PersonalFinancePlanner();
            planner.AddIncome(500);

            Assert.Throws<InvalidOperationException>(() => planner.AddExpense(600));
        }

    }
}