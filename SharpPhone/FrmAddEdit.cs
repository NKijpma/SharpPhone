using System.ComponentModel;

namespace SharpPhone
{
    public partial class FrmAddEdit : Form
    {
        public FrmAddEdit()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                if (Phone == null) return;
                TxtBrand.Text = Phone.Brand;
                TxtModel.Text = Phone.Model;
                TxtSize.Text = Phone.StorageSizeMb.ToString();
                TxtPrice.Text = Phone.Price.ToString();
                TxtStock.Text = Phone.Stock.ToString();
            };
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SmartPhone? Phone { get; set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TxtSize.Text, out int StorageSize))
            {
                MessageBox.Show("Please enter a valid storage size in MB.", "Input Error", MessageBoxButtons.OK);
                return;
            }

            if (!decimal.TryParse(TxtPrice.Text, out decimal Price))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(TxtStock.Text, out int Stock))
            {
                MessageBox.Show("Please enter a valid stock amount.", "Input Error", MessageBoxButtons.OK);
                return;
            }

            Phone = new SmartPhone
            {
                Brand = TxtBrand.Text,
                Model = TxtModel.Text,
                StorageSizeMb = StorageSize,
                Price = Price,
                Stock = Stock
            };
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show(
                "Are you sure you want to cancel?\n All unsaved changes will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.OKCancel
            );
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }

        }

    }
}
