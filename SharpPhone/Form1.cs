namespace SharpPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            Form FrmAddEdit = new FrmAddEdit();
            FrmAddEdit.ShowDialog();

            

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        private void BtnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
