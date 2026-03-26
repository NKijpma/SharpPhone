namespace SharpPhone
{
    public partial class Form1 : Form
    {

        private readonly List<SmartPhone> Phones = new List<SmartPhone>();
        public Form1()
        {
            InitializeComponent();
            Phones.Add(new SmartPhone { Brand = "tester", Model = "test phone 1", StorageSizeMb = 128000, Price = 999m, Stock = 4 });
            UpdatePhoneList();
        }


        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            UpdatePhoneList();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            Form FrmAddEdit = new FrmAddEdit();
            FrmAddEdit.ShowDialog();
        }

        private void UpdatePhoneList()
        {
            foreach (var phone in Phones)
            {
                ListPhones.Items.Add($"{"brand: " + phone.Brand} {"model: " + phone.Model} {phone.StorageSizeMb / 1000 + " GB"}");
            }
        }
    }
}


