using WorkShopControlLib;
using static WorkShopLogicLib.WorkShopCalculator;

namespace WorkShopLogicLib.Tests
{
    [TestClass]
    public class WorkShopCalculatorTests
    {
        private List<RecordsUserControl> CreateTestRecords()
        {
            return new List<RecordsUserControl>
            {
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddHours(-1)),
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddHours(-2)),
                new MockRecordsUserControl("В ожидании", DateTime.Now.AddHours(-3)),
                new MockRecordsUserControl("Выполнено", DateTime.Now.AddHours(-4)),
                new MockRecordsUserControl("Отменено", DateTime.Now.AddHours(-5))
            };
        }

        [TestMethod]
        public void CalculateCompletedRequestsTest_NoCompletedRequests()
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("В ожидании", DateTime.Now),
                new MockRecordsUserControl("Отменено", DateTime.Now)
            };
            var calculator = new WorkShopCalculator();

            // Act
            var completedCount = calculator.CalculateCompletedRequests(controls);

            // Assert
            Assert.AreEqual(0, completedCount);
        }

        [TestMethod]
        public void CalculateCompletedRequestsTest_SomeCompletedRequests()
        {
            // Arrange
            var controls = CreateTestRecords();
            var calculator = new WorkShopCalculator();

            // Act
            var completedCount = calculator.CalculateCompletedRequests(controls);

            // Assert
            Assert.AreEqual(3, completedCount);
        }

        [TestMethod]
        public void CalculateCompletedRequestsTest_AllCompletedRequests()
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("Выполнено", DateTime.Now),
                new MockRecordsUserControl("Выполнено", DateTime.Now)
            };
            var calculator = new WorkShopCalculator();

            // Act
            var completedCount = calculator.CalculateCompletedRequests(controls);

            // Assert
            Assert.AreEqual(2, completedCount);
        }

        [TestMethod]
        public void CalculateAverageCompletionTimeTest_NoCompletedRequests()
        {
            // Arrange
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("В ожидании", DateTime.Now),
                new MockRecordsUserControl("Отменено", DateTime.Now)
            };
            var calculator = new WorkShopCalculator();

            // Act
            var averageCompletionTime = calculator.CalculateAverageCompletionTime(controls);

            // Assert
            Assert.AreEqual(TimeSpan.Zero, averageCompletionTime);
        }

        [TestMethod]
        public void CalculateAverageCompletionTimeTest_SomeCompletedRequests()
        {
            // Arrange
            var now = DateTime.Now;
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("Выполнено", now.AddHours(-1)),
                new MockRecordsUserControl("Выполнено", now.AddHours(-2)),
                new MockRecordsUserControl("Выполнено", now.AddHours(-4))
            };
            var calculator = new WorkShopCalculator();
            var expectedAverageTime = new TimeSpan((long)(((now - now.AddHours(-1)).Ticks + (now - now.AddHours(-2)).Ticks + (now - now.AddHours(-4)).Ticks) / 3.0));

            // Act
            var averageCompletionTime = calculator.CalculateAverageCompletionTime(controls);

            // Assert
            Assert.IsTrue(Math.Abs((averageCompletionTime - expectedAverageTime).TotalMilliseconds) < 100,
                $"Expected: {expectedAverageTime}, Actual: {averageCompletionTime}");
        }

        [TestMethod]
        public void CalculateAverageCompletionTimeTest_AllCompletedRequests()
        {
            // Arrange
            var now = DateTime.Now;
            var controls = new List<RecordsUserControl>
            {
                new MockRecordsUserControl("Выполнено", now.AddHours(-1)),
                new MockRecordsUserControl("Выполнено", now.AddHours(-2)),
                new MockRecordsUserControl("Выполнено", now.AddHours(-3))
            };
            var calculator = new WorkShopCalculator();
            var expectedAverageTime = new TimeSpan((long)(((now - now.AddHours(-1)).Ticks + (now - now.AddHours(-2)).Ticks + (now - now.AddHours(-3)).Ticks) / 3.0));

            // Act
            var averageCompletionTime = calculator.CalculateAverageCompletionTime(controls);

            // Assert
            Assert.IsTrue(Math.Abs((averageCompletionTime - expectedAverageTime).TotalMilliseconds) < 100,
                $"Expected: {expectedAverageTime}, Actual: {averageCompletionTime}");
        }
    }
}
