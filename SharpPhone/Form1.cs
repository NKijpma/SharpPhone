namespace SharpPhone
{
    public partial class Form1 : Form
    {
        private SharpPhoneDatabase _db = new();
        private static readonly SharpPhoneFileStorage _storage = new(
            Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!
                .Parent!.Parent!.Parent!.FullName, "data.json"));
        public Form1()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                _db = _storage.Load();
                InitializeListView();
                UpdateLstViewPhones();
            };
        }
        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            var form = new FrmAddEdit();
            if (form.ShowDialog() != DialogResult.OK) return;

            var phone = form.Phone!;
            phone.Id = _db.Phones.Count > 0 ? _db.Phones.Max(p => p.Id) + 1 : 1;
            _db.Phones.Add(phone);
            _storage.Save(_db);
            UpdateLstViewPhones();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstViewPhones.SelectedIndices.Count == 0) return;

            var result = MessageBox.Show(
                "Are you sure you want to delete?\nAll data will be lost.",
                "Confirm Delete",
                MessageBoxButtons.OKCancel
            );
            if (result != DialogResult.OK) return;

            _db.Phones.RemoveAt(LstViewPhones.SelectedIndices[0]);
            _storage.Save(_db);
            UpdateLstViewPhones();
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (LstViewPhones.SelectedIndices.Count == 0) return;

            var selected = _db.Phones[LstViewPhones.SelectedIndices[0]];
            var form = new FrmAddEdit();
            form.Phone = selected;

            if (form.ShowDialog() != DialogResult.OK) return;

            _db.Phones[LstViewPhones.SelectedIndices[0]] = form.Phone!;
            _storage.Save(_db);
            UpdateLstViewPhones();
        }

        private void InitializeListView()
        {
            if (LstViewPhones.Columns.Count > 0) return;

            LstViewPhones.View = View.Details;
            int w = LstViewPhones.ClientSize.Width;
            LstViewPhones.Columns.Add("Brand", (int)(w * 0.25));
            LstViewPhones.Columns.Add("Model", (int)(w * 0.35));
            LstViewPhones.Columns.Add("Storage", (int)(w * 0.20));
            LstViewPhones.Columns.Add("Stock", (int)(w * 0.20));
        }

        private void UpdateLstViewPhones()
        {
            LstViewPhones.Items.Clear();
            foreach (var phone in _db.Phones)
            {
                var item = new ListViewItem(phone.Brand);
                item.SubItems.Add(phone.Model);
                item.SubItems.Add(phone.StorageSizeMb / 1000 + " GB");
                item.SubItems.Add(phone.Stock.ToString());
                LstViewPhones.Items.Add(item);
            }
        }
    }
}