namespace AutoEngineDevStorage
{
    partial class NewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PictureChangeBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Productpicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Productpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Home Automation",
            "Laboratory",
            "Industrial"});
            this.comboBoxCategory.Location = new System.Drawing.Point(323, 242);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(182, 21);
            this.comboBoxCategory.TabIndex = 6;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textName.Location = new System.Drawing.Point(323, 44);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(182, 20);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country:";
            // 
            // textCountry
            // 
            this.textCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textCountry.Location = new System.Drawing.Point(323, 83);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(182, 20);
            this.textCountry.TabIndex = 2;
            this.textCountry.TextChanged += new System.EventHandler(this.textCountry_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand:";
            // 
            // textBrand
            // 
            this.textBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textBrand.Location = new System.Drawing.Point(323, 123);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(182, 20);
            this.textBrand.TabIndex = 3;
            this.textBrand.TextChanged += new System.EventHandler(this.textBrand_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textPrice.Location = new System.Drawing.Point(323, 164);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(182, 20);
            this.textPrice.TabIndex = 4;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount:";
            // 
            // textAmount
            // 
            this.textAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textAmount.Location = new System.Drawing.Point(323, 203);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(182, 20);
            this.textAmount.TabIndex = 5;
            this.textAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.SaveBtn.Location = new System.Drawing.Point(386, 282);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 44);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(37, 285);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 2;
            this.DescriptionLbl.Text = "Description:";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            this.textDescription.Location = new System.Drawing.Point(106, 282);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(216, 144);
            this.textDescription.TabIndex = 7;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Category:";
            // 
            // PictureChangeBtn
            // 
            this.PictureChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.PictureChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PictureChangeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.PictureChangeBtn.Location = new System.Drawing.Point(50, 225);
            this.PictureChangeBtn.Name = "PictureChangeBtn";
            this.PictureChangeBtn.Size = new System.Drawing.Size(137, 44);
            this.PictureChangeBtn.TabIndex = 8;
            this.PictureChangeBtn.Text = "Browse Image";
            this.PictureChangeBtn.UseVisualStyleBackColor = false;
            this.PictureChangeBtn.Click += new System.EventHandler(this.PictureChangeBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.CancelBtn.Location = new System.Drawing.Point(386, 342);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(109, 44);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Productpicture
            // 
            this.Productpicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.Productpicture.Image = global::AutoEngineDevStorage.Properties.Resources.camera_icon;
            this.Productpicture.Location = new System.Drawing.Point(26, 47);
            this.Productpicture.Name = "Productpicture";
            this.Productpicture.Size = new System.Drawing.Size(183, 172);
            this.Productpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Productpicture.TabIndex = 1;
            this.Productpicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category:";
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(538, 438);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PictureChangeBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productpicture);
            this.Controls.Add(this.comboBoxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.Productpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox Productpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button PictureChangeBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label6;
    }
}