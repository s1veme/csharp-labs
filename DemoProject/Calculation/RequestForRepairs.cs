namespace Calculation
{
    public static class RequestStatus
    {
        public static readonly string NotCompleted = "Not completed";
        public static readonly string InProcess = "In process";
        public static readonly string Completed = "Completed";
    }

    public class RequestForRepairs
    {
        public int ID;
        public DateTime StartAt;
        public DateTime EndAt;
        public string Equipment;
        public string Defect;
        public string Client;
        public string Status;
        public string Responsible;
        public string ProblemDescription;

        public RequestForRepairs(int id, DateTime date, string equipment, string defect, string client,
            string problemDescription)
        {
            ID = id;
            StartAt = date;
            EndAt = new DateTime();
            Equipment = equipment;
            Defect = defect;
            Client = client;
            Status = RequestStatus.NotCompleted;
            Responsible = "";
            ProblemDescription = problemDescription;
        }
    }
}
