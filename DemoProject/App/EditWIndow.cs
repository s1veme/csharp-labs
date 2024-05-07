using Calculation;
using System.Diagnostics;

namespace App
{
    public partial class EditWindow : Form
    {
        public RequestForRepairs? request;
        public int id;
        public DateTime startAt, endAt;

        public EditWindow(RequestForRepairs? requestForRepair)
        {
            InitializeComponent();

            request = requestForRepair;

            if (request == null) {
                FillTextBoxesAdd();
                return;
            }
            
            FillTextBoxesEdit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) {
                MessageBox.Show("Fill in all the fields");
                return;
            }

            if (request != null) {
                if (!int.TryParse(textId.Text, out id))
                {
                    MessageBox.Show("Invalid ID");
                    textId.Text = "";
                    return;
                }
            }
            
            if ((boxState.SelectedIndex == 0 || boxState.SelectedIndex == 1) && textResponsible.Text == "")
            {
                MessageBox.Show("Specify the person responsible for completing the request");
                return;
            }

            startAt = textDate.Value;

            DialogResult = DialogResult.OK;
        }

        private bool ValidateFields() {
            return textClient.Text == ""
                || textDate.Text == ""
                || textDefect.Text == ""
                || textEquipment.Text == ""
                || textId.Text == ""
                || textProblemDescription.Text == "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void FillTextBoxesAdd() 
        {
            textResponsible.ReadOnly = true;
            boxState.SelectedIndex = 2;
            boxState.Enabled = false;
        }

        public void FillTextBoxesEdit()
        {
            textClient.Text = request.Client;
            textDate.Text = request.StartAt.ToString();
            textDefect.Text = request.Defect;
            textEquipment.Text = request.Equipment;
            textProblemDescription.Text = request.ProblemDescription;
            textId.Text = request.ID.ToString();
            textResponsible.Text = request.Responsible;

            if (boxState.Items.Contains(request.Status))
            {
                boxState.SelectedItem = request.Status;
            }

            textId.ReadOnly = true;
            textDate.Enabled = false;
            textClient.ReadOnly = true;
            textEquipment.ReadOnly = true;
            textDefect.ReadOnly = true;
        }
    }
}
