namespace SharpPhone
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();

            TxtUsername.Location = new Point(127, 40);
            TxtUsername.Size = new Size(125, 27);
            TxtUsername.Name = "TxtUsername";

            TxtPassword.Location = new Point(127, 80);
            TxtPassword.Size = new Size(125, 27);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';

            BtnLogin.Location = new Point(127, 120);
            BtnLogin.Size = new Size(94, 29);
            BtnLogin.Text = "Login";
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Click += BtnLogin_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 1, 42);
            ForeColor = Color.FromArgb(255, 231, 138);
            ClientSize = new Size(800, 450);
            Controls.Add(TxtUsername);
            Controls.Add(TxtPassword);
            Controls.Add(BtnLogin);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
        }

        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button BtnLogin;
    }
}