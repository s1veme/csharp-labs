using Calculation;
using Controls;
using System.Diagnostics;

namespace App
{
    public partial class MainForm : Form
    {
        public List<RequestForRepairs> requestsForRepair;
        public MainForm()
        {
            InitializeComponent();
            requestsForRepair = new List<RequestForRepairs>();
        }

        public void AddRequest()
        {
            panelApplications.Controls.Add(new RequestForRepairUserControl());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditWindow window = new EditWindow(null);
            window.ShowDialog();
            if (window.DialogResult != DialogResult.OK) return;

            RequestForRepairs request = new RequestForRepairs(
                window.id,
                window.startAt,
                window.textEquipment.Text,
                window.textDefect.Text,
                window.textClient.Text,
                window.textProblemDescription.Text
            );
            requestsForRepair.Add(request);

            var control = new RequestForRepairUserControl();
            panelApplications.Controls.Add(control);
            control.Click += RequestClick;

            ToRequestControl(ref control, request);
        }
        private void RequestClick(object sender, EventArgs e)
        {
            var control = (RequestForRepairUserControl)((Control)sender).Parent;

            var request = requestsForRepair.FirstOrDefault(request => request.ID.ToString() == control.ID);
            if (request == null) return;

            var window = new EditWindow(request);
            window.ShowDialog();
            if (window.DialogResult != DialogResult.OK) return;

            UpdateRequestForRepair(request, window, control);
        }

        private void UpdateRequestForRepair(RequestForRepairs app, EditWindow window, RequestForRepairUserControl control)
        {
            app.Status = window.boxState.Text;
            app.Responsible = window.textResponsible.Text;
            app.ProblemDescription = window.textProblemDescription.Text;

            ToRequestControl(ref control, app);
        }

        public void ToRequestControl(ref RequestForRepairUserControl control, RequestForRepairs request)
        {
            control.ID = request.ID.ToString();
            control.Date = request.StartAt.ToString();
            control.Equipment = request.Equipment;
            control.Defect = request.Defect;
            control.Client = request.Client;
            control.ProblemDescription = request.ProblemDescription;
            control.Status = request.Status;
            control.Responsible = request.Responsible;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSearch.Text))
            {
                MessageBox.Show("Specify the request ID for the search");
                return;
            }

            if (!int.TryParse(textSearch.Text, out int searchID))
            {
                MessageBox.Show("The ID was entered incorrectly");
                return;
            }

            var request = requestsForRepair.FirstOrDefault(app => app.ID == searchID);
            if (request == null)
            {
                MessageBox.Show("The request was not found");
                return;
            }

            ShowRequestDetails(request);
        }

        private void ShowRequestDetails(RequestForRepairs request)
        {
            var message = $@"ID: {request.ID}
                Start date: {request.StartAt}
                Equipment: {request.Equipment}
                Type defect: {request.Defect}
                Client: {request.Client}
                Request status: {request.Status}
                Responsible: {request.Responsible}
                Problem Description: {request.ProblemDescription}";

            MessageBox.Show(message);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator(requestsForRepair);
            int count = calculator.Count();
            int time = calculator.CalculateAverageTime();

            string message = "";
            message += $"Number of requests: {count} \n";
            message += $"Average execution time: {time} \n";

            string statistic = calculator.Statistics();
            if (statistic != null)
            {
                message += $"The most common problem: {statistic}\n";
            }

            MessageBox.Show(message);
        }
    }
}