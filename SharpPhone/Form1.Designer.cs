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
            SplitContainer1 = new SplitContainer();
            LstViewPhones = new ListView();
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            SuspendLayout();
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
            // 
            // SplitContainer1
            // 
            SplitContainer1.Dock = DockStyle.Fill;
            SplitContainer1.Location = new Point(0, 0);
            SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(BtnAddPhone);
            SplitContainer1.Panel1.Controls.Add(BtnModify);
            SplitContainer1.Panel1.Controls.Add(BtnDelete);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(LstViewPhones);
            SplitContainer1.Size = new Size(800, 450);
            SplitContainer1.SplitterDistance = 400;
            SplitContainer1.TabIndex = 4;
            // 
            // LstViewPhones
            // 
            LstViewPhones.BackColor = Color.FromArgb(28, 98, 86);
            LstViewPhones.Dock = DockStyle.Fill;
            LstViewPhones.ForeColor = Color.FromArgb(255, 231, 138);
            LstViewPhones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LstViewPhones.Location = new Point(0, 0);
            LstViewPhones.Name = "LstViewPhones";
            LstViewPhones.Size = new Size(396, 450);
            LstViewPhones.TabIndex = 3;
            LstViewPhones.UseCompatibleStateImageBehavior = false;
            LstViewPhones.GridLines = true;
            LstViewPhones.FullRowSelect = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 1, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(SplitContainer1);
            Name = "Form1";
            Text = "Phones";
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
            SplitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddPhone;
        private Button BtnModify;
        private Button BtnDelete;
        private SplitContainer SplitContainer1;
        private ListView LstViewPhones;
    }
}
