namespace SharpPhone
{
    public partial class FrmLogin : Form
    {
        private readonly SharpPhoneFileStorage _storage = new(
            Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!
                .Parent!.Parent!.Parent!.FullName, "data.json"));
        private SharpPhoneDatabase _db;

        public FrmLogin()
        {
            InitializeComponent();
            _db = _storage.Load();
        }

        private int Attempts = 0;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == TxtUsername.Text);

            if (user == null || user.Password != TxtPassword.Text)
            {
                Attempts++;

                if (user != null)
                {
                    user.FailedAttempts++;
                    _storage.Save(_db);
                }

                if (Attempts >= 3)
                {
                    MessageBox.Show("Too many failed attempts. App will close.");
                    this.Close();
                    return;
                }

                MessageBox.Show($"Invalid login. ({Attempts}/3 attempts)");
                return;
            }
            _storage.Save(_db);
            DialogResult = DialogResult.OK;
        }
    }
}
