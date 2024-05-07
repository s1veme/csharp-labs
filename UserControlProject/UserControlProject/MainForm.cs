namespace UserControlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var control = new PersonUserControl();

            usersPanel.Controls.Add(control);
            control.Click += ControlClick;
        }

        private void ControlClick(object sender, EventArgs e)
        {
            var control = (PersonUserControl)((Control)sender).Parent;

            if (((Button)sender).Name != "buttonEdit")
            {
                usersPanel.Controls.Remove(control);
                AllRecordsCount.Text = usersPanel.Controls.Count.ToString();
                SumAgeCount.Text = CountAgeSum();

                return;
            }

            var window = new PersonEditForm(control);
            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {
                control.ID = window.ID;
                control.Name = window.Name;
                control.Surname = window.Surname;
                control.MiddleName = window.MiddleName;
                control.Age = window.Age;
                AllRecordsCount.Text = usersPanel.Controls.Count.ToString();
                SumAgeCount.Text = CountAgeSum();

                return;
            }

            MessageBox.Show("You didn't fill in all the fields");
        }

        private string CountAgeSum()
        {
            int sum = 0;
            foreach (var control in usersPanel.Controls)
            {
                if (int.TryParse(((PersonUserControl)control).Age, out int age))
                {
                    sum += age;
                }
            }

            return sum.ToString();
        }
    }
}
