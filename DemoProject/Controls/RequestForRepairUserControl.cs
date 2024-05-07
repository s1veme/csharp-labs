using System.ComponentModel;

namespace Controls
{
    [DefaultEvent(nameof(Click))]
    public partial class RequestForRepairUserControl : UserControl
    {
        public RequestForRepairUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new event EventHandler? Click
        {
            add { EditButton.Click += value; }
            remove { EditButton.Click -= value; }
        }

        [Browsable(true)]
        public string ID
        {
            get => tbID.Text;
            set => tbID.Text = value;
        }

        [Browsable(true)]
        public string Date
        {
            get => tbDate.Text;
            set => tbDate.Text = value;
        }

        [Browsable(true)]
        public string Equipment
        {
            get => tbEquipment.Text;
            set => tbEquipment.Text = value;
        }

        [Browsable(true)]
        public string Defect
        {
            get => tbDefect.Text;
            set => tbDefect.Text = value;
        }

        [Browsable(true)]
        public string Client
        {
            get => tbClient.Text;
            set => tbClient.Text = value;
        }

        [Browsable(true)]
        public string Status
        {
            get => tbStatus.Text;
            set => tbStatus.Text = value;
        }

        [Browsable(true)]
        public string Responsible
        {
            get => tbResponsible.Text;
            set => tbResponsible.Text = value;
        }

        [Browsable(true)]
        public string ProblemDescription
        {
            get => tbProblemDescription.Text;
            set => tbProblemDescription.Text = value;
        }
    }
}