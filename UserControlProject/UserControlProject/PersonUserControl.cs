using System.ComponentModel;


namespace UserControlProject
{
    [DefaultEvent(nameof(Click))]
    public partial class PersonUserControl : UserControl
    {
        public PersonUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new event EventHandler? Click
        {
            add
            {
                buttonEdit.Click += value;
                buttonDelete.Click += value;
            }
            remove
            {
                buttonEdit.Click -= value;
                buttonDelete.Click -= value;
            }
        }

        [Browsable(true)]
        public string ID
        {
            get => personID.Text;
            set => personID.Text = value;
        }

        [Browsable(true)]
        public string Surname
        {
            get => personSurname.Text;
            set => personSurname.Text = value;
        }

        [Browsable(true)]
        public string Name
        {
            get => personName.Text;
            set => personName.Text = value;
        }

        [Browsable(true)]
        public string MiddleName
        {
            get => personMiddleName.Text;
            set => personMiddleName.Text = value;
        }

        [Browsable(true)]
        public string Age
        {
            get => personAge.Text;
            set => personAge.Text = value;
        }
    }
}
