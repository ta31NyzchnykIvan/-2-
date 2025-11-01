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
    }
}