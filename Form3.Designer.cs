namespace AutoEngineDevStorage
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(24, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 294;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.Enabled = false;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(373, 86);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 31);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.RemoveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveBtn.Location = new System.Drawing.Point(373, 129);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(100, 31);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // TotalBtn
            // 
            this.TotalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.TotalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TotalBtn.Enabled = false;
            this.TotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalBtn.Location = new System.Drawing.Point(373, 166);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(100, 31);
            this.TotalBtn.TabIndex = 4;
            this.TotalBtn.Text = "TOTAL";
            this.TotalBtn.UseVisualStyleBackColor = false;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.BuyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyBtn.Enabled = false;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyBtn.Location = new System.Drawing.Point(373, 203);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(100, 31);
            this.BuyBtn.TabIndex = 4;
            this.BuyBtn.Text = "BUY";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(373, 240);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 31);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Back to Menu";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.textNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.textNumber.Location = new System.Drawing.Point(533, 92);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(43, 20);
            this.textNumber.TabIndex = 5;
            this.textNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textNumber_MouseClick);
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.ViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewBtn.Enabled = false;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(373, 49);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(100, 31);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "VIEW";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.SearchLabel.Location = new System.Drawing.Point(21, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(55, 13);
            this.SearchLabel.TabIndex = 7;
            this.SearchLabel.Text = "Search: ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Home Automation",
            "Laboratory ",
            "Industrial"});
            this.comboBox1.Location = new System.Drawing.Point(345, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(216)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.textBox1.Location = new System.Drawing.Point(83, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(479, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(36, 284);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 20);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostLabel.Location = new System.Drawing.Point(102, 284);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(0, 20);
            this.CostLabel.TabIndex = 10;
            this.CostLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(65)))), ((int)(((byte)(63)))));
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(31, 24);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(234, 235);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            // 
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Location = new System.Drawing.Point(28, 8);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(39, 13);
            this.Cart.TabIndex = 6;
            this.Cart.Text = "CART:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(160)))), ((int)(((byte)(157)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Cart);
            this.panel1.Controls.Add(this.CostLabel);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Location = new System.Drawing.Point(582, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 323);
            this.panel1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.TotalBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label Cart;
        private System.Windows.Forms.Panel panel1;
    }
}