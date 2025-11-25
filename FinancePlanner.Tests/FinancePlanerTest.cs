using FinancePlanner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinancePlanner.Tests;

[TestClass]
public class FinancePlannerTest
{
    [TestMethod]
    public void BalanceShouldIncrease()
    {
        var planner = new PersonalFinancePlanner();
        planner.AddIncome(100);

        Assert.AreEqual(100, planner.GetBalance());
    }
}