namespace UserControlProject
{
    partial class PersonUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            personAge = new TextBox();
            personMiddleName = new TextBox();
            personName = new TextBox();
            personSurname = new TextBox();
            personID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(81, 15);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(216, 15);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(332, 15);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 3;
            label4.Text = "Middle name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(488, 15);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(593, 19);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(593, 48);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // personAge
            // 
            personAge.Location = new Point(488, 49);
            personAge.Name = "personAge";
            personAge.ReadOnly = true;
            personAge.Size = new Size(45, 23);
            personAge.TabIndex = 13;
            // 
            // personMiddleName
            // 
            personMiddleName.Location = new Point(332, 48);
            personMiddleName.Name = "personMiddleName";
            personMiddleName.ReadOnly = true;
            personMiddleName.Size = new Size(150, 23);
            personMiddleName.TabIndex = 14;
            // 
            // personName
            // 
            personName.Location = new Point(216, 48);
            personName.Name = "personName";
            personName.ReadOnly = true;
            personName.Size = new Size(110, 23);
            personName.TabIndex = 15;
            // 
            // personSurname
            // 
            personSurname.Location = new Point(85, 49);
            personSurname.Name = "personSurname";
            personSurname.ReadOnly = true;
            personSurname.Size = new Size(120, 23);
            personSurname.TabIndex = 16;
            // 
            // personID
            // 
            personID.Location = new Point(20, 49);
            personID.Name = "personID";
            personID.ReadOnly = true;
            personID.Size = new Size(46, 23);
            personID.TabIndex = 17;
            // 
            // PersonUserControl
            // 
            Controls.Add(personID);
            Controls.Add(personSurname);
            Controls.Add(personName);
            Controls.Add(personMiddleName);
            Controls.Add(personAge);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonUserControl";
            Size = new Size(698, 97);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonEdit;
        private Button buttonDelete;
        private TextBox personAge;
        private TextBox personMiddleName;
        private TextBox personName;
        private TextBox personSurname;
        private TextBox personID;
    }
}
