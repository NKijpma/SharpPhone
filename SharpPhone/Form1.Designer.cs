namespace SharpPhone
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            BtnAddPhone = new Button();
            BtnModify = new Button();
            BtnDelete = new Button();
            ListPhones = new ListBox();
            SplitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.SuspendLayout();
            SuspendLayout();

            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = DockStyle.Fill;
            SplitContainer1.Location = new Point(0, 0);
            SplitContainer1.Name = "SplitContainer1";
            SplitContainer1.Size = new Size(800, 450);
            SplitContainer1.SplitterDistance = 400; 
            SplitContainer1.TabIndex = 4;

            // 
            // ListPhones panel 2 right
            // 
            ListPhones.BackColor = Color.FromArgb(28, 98, 86);
            ListPhones.ForeColor = Color.FromArgb(255, 231, 138);
            ListPhones.Dock = DockStyle.Fill;
            ListPhones.Name = "ListPhones";
            ListPhones.TabIndex = 3;
            SplitContainer1.Panel2.Controls.Add(ListPhones);

            // 
            // BtnAddPhone
            // 
            BtnAddPhone.BackColor = Color.FromArgb(255, 231, 138);
            BtnAddPhone.Font = new Font("Segoe UI", 18F);
            BtnAddPhone.ForeColor = Color.FromArgb(28, 98, 86);
            BtnAddPhone.Location = new Point(20, 20);
            BtnAddPhone.Name = "BtnAddPhone";
            BtnAddPhone.Size = new Size(50, 50);
            BtnAddPhone.TabIndex = 0;
            BtnAddPhone.Text = "+";
            BtnAddPhone.UseVisualStyleBackColor = false;
            BtnAddPhone.Click += BtnAddPhone_Click;

            // 
            // BtnModify
            // 
            BtnModify.BackColor = Color.FromArgb(255, 231, 138);
            BtnModify.ForeColor = Color.FromArgb(28, 98, 86);
            BtnModify.Location = new Point(20, 90);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(94, 29);
            BtnModify.TabIndex = 1;
            BtnModify.Text = "modify";
            BtnModify.UseVisualStyleBackColor = false;
            BtnModify.Click += BtnModify_Click;

            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(255, 231, 138);
            BtnDelete.ForeColor = Color.FromArgb(28, 98, 86);
            BtnDelete.Location = new Point(20, 140);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "del";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;

            // Add buttons to Panel1 left
            SplitContainer1.Panel1.Controls.Add(BtnAddPhone);
            SplitContainer1.Panel1.Controls.Add(BtnModify);
            SplitContainer1.Panel1.Controls.Add(BtnDelete);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 1, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(SplitContainer1);
            Name = "Form1";
            Text = "SharpPhone";

            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddPhone;
        private Button BtnModify;
        private Button BtnDelete;
        private ListBox ListPhones;
        private SplitContainer SplitContainer1;
    }
}
