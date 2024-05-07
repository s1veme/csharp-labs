namespace UserControlProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddPerson = new Button();
            AllRecordsCountLabel = new Label();
            SumAgeLabel = new Label();
            AllRecordsCount = new TextBox();
            SumAgeCount = new TextBox();
            usersPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // AddPerson
            // 
            AddPerson.Location = new Point(66, 22);
            AddPerson.Name = "AddPerson";
            AddPerson.Size = new Size(136, 45);
            AddPerson.TabIndex = 0;
            AddPerson.Text = "Add";
            AddPerson.UseVisualStyleBackColor = true;
            AddPerson.Click += button1_Click;
            // 
            // AllRecordsCountLabel
            // 
            AllRecordsCountLabel.AutoSize = true;
            AllRecordsCountLabel.Font = new Font("Segoe UI", 12F);
            AllRecordsCountLabel.Location = new Point(219, 22);
            AllRecordsCountLabel.Name = "AllRecordsCountLabel";
            AllRecordsCountLabel.Size = new Size(130, 21);
            AllRecordsCountLabel.TabIndex = 2;
            AllRecordsCountLabel.Text = "All records count:";
            // 
            // SumAgeLabel
            // 
            SumAgeLabel.AutoSize = true;
            SumAgeLabel.Font = new Font("Segoe UI", 12F);
            SumAgeLabel.Location = new Point(219, 46);
            SumAgeLabel.Name = "SumAgeLabel";
            SumAgeLabel.Size = new Size(74, 21);
            SumAgeLabel.TabIndex = 3;
            SumAgeLabel.Text = "Sum age:";
            // 
            // AllRecordsCount
            // 
            AllRecordsCount.Location = new Point(355, 22);
            AllRecordsCount.Name = "AllRecordsCount";
            AllRecordsCount.Size = new Size(67, 23);
            AllRecordsCount.TabIndex = 4;
            // 
            // SumAgeCount
            // 
            SumAgeCount.Location = new Point(299, 48);
            SumAgeCount.Name = "SumAgeCount";
            SumAgeCount.Size = new Size(67, 23);
            SumAgeCount.TabIndex = 5;
            // 
            // usersPanel
            // 
            usersPanel.AutoScroll = true;
            usersPanel.Location = new Point(12, 95);
            usersPanel.Name = "usersPanel";
            usersPanel.Size = new Size(776, 343);
            usersPanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usersPanel);
            Controls.Add(SumAgeCount);
            Controls.Add(AllRecordsCount);
            Controls.Add(SumAgeLabel);
            Controls.Add(AllRecordsCountLabel);
            Controls.Add(AddPerson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPerson;
        private Label AllRecordsCountLabel;
        private Label SumAgeLabel;
        private TextBox AllRecordsCount;
        private TextBox SumAgeCount;
        private FlowLayoutPanel usersPanel;
    }
}
