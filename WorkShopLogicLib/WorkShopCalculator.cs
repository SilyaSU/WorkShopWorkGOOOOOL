using WorkShopControlLib;

namespace WorkShopLogicLib
{
    public class WorkShopCalculator
    {
        public int CalculateCompletedRequests(IEnumerable<RecordsUserControl> controls)
        {
            int completedCount = 0;
            foreach (var control in controls)
            {
                if (control.Status == "Выполнено")
                {
                    completedCount++;
                }
            }
            return completedCount;
        }

        public TimeSpan CalculateAverageCompletionTime(IEnumerable<RecordsUserControl> controls)
        {
            TimeSpan totalCompletionTime = TimeSpan.Zero;
            int completedRequestCount = 0;

            foreach (var control in controls)
            {
                if (control.Status == "Выполнено")
                {
                    totalCompletionTime += DateTime.Now - control.CompletionTime;
                    completedRequestCount++;
                }
            }

            return completedRequestCount > 0 ? totalCompletionTime / completedRequestCount : TimeSpan.Zero;
        }

        public class MockRecordsUserControl : RecordsUserControl
        {
            public MockRecordsUserControl(string status, DateTime completionTime)
            {
                Status = status;
                CompletionTime = completionTime;
            }
        }

    }
}
