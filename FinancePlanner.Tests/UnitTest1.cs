using Xunit;
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
            planner.AddExpense(400);

            Assert.Equal(600, planner.GetBalance());
        }
        [Fact]
        public void AddIncome_ShouldThrow_WhenAmountIsNegative()
        {
            var planner = new PersonalFinancePlanner();
            Assert.Throws<ArgumentException>(() => planner.AddIncome(-100));
        }

    }
}