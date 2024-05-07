using Microsoft.VisualBasic.ApplicationServices;

namespace UserControlProject
{
    public partial class PersonEditForm : Form
    {
        public PersonEditForm(PersonUserControl person)
        {
            InitializeComponent();

            ID = person.ID;
            Name = person.Name;
            Surname = person.Surname;
            MiddleName = person.MiddleName;
            Age = person.Age;
        }

        public string ID
        {
            get => IDBox.Text;
            set => IDBox.Text = value;
        }

        public string Name
        {
            get => NameBox.Text;
            set => NameBox.Text = value;
        }

        public string MiddleName
        {
            get => MiddleNameBox.Text;
            set => MiddleNameBox.Text = value;
        }

        public string Surname
        {
            get => SurnameBox.Text;
            set => SurnameBox.Text = value;
        }

        public string Age
        {
            get => AgeBox.Text;
            set => AgeBox.Text = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidatePerson())
            {
                DialogResult = DialogResult.OK;
                return;
            }

            DialogResult = DialogResult.Cancel;
        }

        private bool ValidatePerson()
        {
            return ID != "" && Name != "" && Surname != "" && MiddleName != "" && Age != "";
        }
    }
}
