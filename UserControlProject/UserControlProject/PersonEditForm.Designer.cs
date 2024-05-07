namespace UserControlProject
{
    partial class PersonEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            label1 = new Label();
            MiddleNameBox = new TextBox();
            label3 = new Label();
            SurnameBox = new TextBox();
            label4 = new Label();
            AgeBox = new TextBox();
            label5 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(34, 55);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(75, 23);
            IDBox.TabIndex = 6;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(34, 116);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(179, 23);
            NameBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 92);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // MiddleNameBox
            // 
            MiddleNameBox.Location = new Point(34, 186);
            MiddleNameBox.Name = "MiddleNameBox";
            MiddleNameBox.Size = new Size(179, 23);
            MiddleNameBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(34, 162);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 9;
            label3.Text = "Middle name";
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(34, 259);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(179, 23);
            SurnameBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 235);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 11;
            label4.Text = "Surname";
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(34, 344);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(75, 23);
            AgeBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(34, 320);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 13;
            label5.Text = "Age";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14.25F);
            buttonSave.Location = new Point(259, 344);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(122, 44);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // PersonEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(buttonSave);
            Controls.Add(AgeBox);
            Controls.Add(label5);
            Controls.Add(SurnameBox);
            Controls.Add(label4);
            Controls.Add(MiddleNameBox);
            Controls.Add(label3);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(IDBox);
            Controls.Add(label2);
            Name = "PersonEditForm";
            Text = "PersonEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox IDBox;
        private TextBox NameBox;
        private Label label1;
        private TextBox MiddleNameBox;
        private Label label3;
        private TextBox SurnameBox;
        private Label label4;
        private TextBox AgeBox;
        private Label label5;
        private Button buttonSave;
    }
}