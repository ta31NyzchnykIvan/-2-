using Xunit;
using FinancePlanner;

namespace FinancePlanner.Tests
{
    public class PlannerTests
    {
        [Fact]
        public void CanCreatePlannerInstance()
        {
            var planner = new FinPlanner();
            Assert.NotNull(planner);
        }
    }
}