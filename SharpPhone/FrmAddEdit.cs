using System.ComponentModel;

namespace SharpPhone
{
    public partial class FrmAddEdit : Form
    {
        public FrmAddEdit()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SmartPhone Phone { get; set; }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TxtSize.Text, out int size))
            {
                MessageBox.Show("Please enter a valid number for storage size.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TxtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Phone = new SmartPhone
            {
                Brand = TxtBrand.Text,
                Model = TxtModel.Text,
                StorageSizeMb = size,
                Price = price,
                Stock = 0
            };

        }
        public SmartPhone GetPhoneFromInput()
        {
            return new SmartPhone
            {
                Brand = TxtBrand.Text,
                Model = TxtModel.Text,
                StorageSizeMb = int.TryParse(TxtSize.Text, out int size) ? size : 0,
                Price = decimal.TryParse(TxtPrice.Text, out decimal price) ? price : 0m
            };
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = new();
            DialogResult = MessageBox.Show(
                "Are you sure you want to cancel?\n All unsaved changes will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

    }
}
