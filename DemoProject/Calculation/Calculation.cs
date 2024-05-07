namespace Calculation
{
    public class Calculator
    {
        public List<RequestForRepairs> RequestsForRepair;
        public double AverageTime;

        public Calculator(List<RequestForRepairs> requests)
        {
            RequestsForRepair = requests;
            AverageTime = 0;
        }

        public int CalculateAverageTime()
        {
            if (RequestsForRepair.Count == 0) return 0;

            var time = new TimeSpan();
            var count = 0;
            foreach (var request in RequestsForRepair)
            {
                if (request.Status != RequestStatus.Completed) continue;

                time += request.EndAt.Subtract(request.EndAt);
                count++;
            }

            if (count == 0) return 0;

            AverageTime = time.TotalDays / count;
            return Convert.ToInt32(Math.Floor(AverageTime));
        }

        public int Count()
        {
            return RequestsForRepair.Count;
        }

        public string? Statistics()
        {
            if (RequestsForRepair.Count == 0) return null;

            return RequestsForRepair
                .GroupBy(request => request.Defect)
                .OrderByDescending(group => group.Count())
                .FirstOrDefault()?
                .Key;
        }
    }
}