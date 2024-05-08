using Calculation;

namespace CalculationTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CalculateAverageTimeNoCompletedRequestsReturnsZero()
        {
            var requests = new List<RequestForRepairs>();
            var calculator = new Calculator(requests);

            var result = calculator.CalculateAverageTime();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateAverageTime_SingleCompletedRequest_ReturnsCorrectValue()
        {
            var request = new RequestForRepairs(1, DateTime.Now.AddDays(-1), "Test", "Test", "Test", "Test");
            request.EndAt = DateTime.Now;
            
            var calculator = new Calculator(new List<RequestForRepairs> { request });

            var result = calculator.CalculateAverageTime();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void StatisticsMultipleRequestsReturnsMostCommonDefect()
        {
            var requests = new List<RequestForRepairs>
            {
                new RequestForRepairs(1, DateTime.Now, "Test1", "Test1", "Test1", "Test1"),
                new RequestForRepairs(2, DateTime.Now, "Test2", "Test2", "Test2", "Test2"),
                new RequestForRepairs(3, DateTime.Now, "Test3", "Test3", "Test3", "Test3")
            };
            var calculator = new Calculator(requests);

            var result = calculator.Statistics();

            Assert.AreEqual("Test1", result);
        }

        [TestMethod]
        public void StatisticsNoRequestsReturnsNull()
        {
            var requests = new List<RequestForRepairs>();
            var calculator = new Calculator(requests);

            var result = calculator.Statistics();

            Assert.IsNull(result);
        }
    }
}