namespace SharpPhone
{
    partial class FrmAddEdit
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
            BtnOk = new Button();
            Label1 = new Label();
            TxtBrand = new TextBox();
            Label2 = new Label();
            TxtModel = new TextBox();
            Label3 = new Label();
            TxtSize = new TextBox();
            Label4 = new Label();
            TxtPrice = new TextBox();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(652, 365);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 29);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(73, 43);
            Label1.Name = "Label1";
            Label1.Size = new Size(48, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Brand";
            // 
            // TxtBrand
            // 
            TxtBrand.Location = new Point(127, 43);
            TxtBrand.Name = "TxtBrand";
            TxtBrand.Size = new Size(125, 27);
            TxtBrand.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(73, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(52, 20);
            Label2.TabIndex = 3;
            Label2.Text = "Model";
            // 
            // TxtModel
            // 
            TxtModel.Location = new Point(127, 83);
            TxtModel.Name = "TxtModel";
            TxtModel.Size = new Size(125, 27);
            TxtModel.TabIndex = 4;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(85, 128);
            Label3.Name = "Label3";
            Label3.Size = new Size(36, 20);
            Label3.TabIndex = 5;
            Label3.Text = "Size";
            // 
            // TxtSize
            // 
            TxtSize.Location = new Point(127, 128);
            TxtSize.Name = "TxtSize";
            TxtSize.Size = new Size(125, 27);
            TxtSize.TabIndex = 6;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(85, 170);
            Label4.Name = "Label4";
            Label4.Size = new Size(41, 20);
            Label4.TabIndex = 7;
            Label4.Text = "Price";
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(127, 170);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(125, 27);
            TxtPrice.TabIndex = 8;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(535, 365);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancel);
            Controls.Add(TxtPrice);
            Controls.Add(Label4);
            Controls.Add(TxtSize);
            Controls.Add(Label3);
            Controls.Add(TxtModel);
            Controls.Add(Label2);
            Controls.Add(TxtBrand);
            Controls.Add(Label1);
            Controls.Add(BtnOk);
            Name = "FrmAddEdit";
            Text = "FrmAddEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOk;
        private Label Label1;
        private TextBox TxtBrand;
        private Label Label2;
        private TextBox TxtModel;
        private Label Label3;
        private TextBox TxtSize;
        private Label Label4;
        private TextBox TxtPrice;
        private Button BtnCancel;
    }
}
