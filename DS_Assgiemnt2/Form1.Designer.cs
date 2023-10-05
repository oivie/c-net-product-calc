namespace DS_Assgiemnt2
{
    partial class Form1
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
            this.lbProductCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNoProducts = new System.Windows.Forms.TextBox();
            this.lbNoProducts = new System.Windows.Forms.Label();
            this.txtAvgProductPrice = new System.Windows.Forms.TextBox();
            this.lbAvgProductPrice = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Location = new System.Drawing.Point(61, 66);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(143, 25);
            this.lbProductCode.TabIndex = 0;
            this.lbProductCode.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(230, 66);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(193, 31);
            this.txtProductCode.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(230, 129);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(193, 31);
            this.txtProductName.TabIndex = 4;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(61, 129);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(148, 25);
            this.lbProductName.TabIndex = 3;
            this.lbProductName.Text = "Product Name";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(230, 196);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(193, 31);
            this.txtProductPrice.TabIndex = 6;
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(61, 196);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(141, 25);
            this.lbProductPrice.TabIndex = 5;
            this.lbProductPrice.Text = "Product Price";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(66, 389);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(170, 51);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(253, 389);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 51);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(442, 389);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(170, 51);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(892, 156);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtNoProducts
            // 
            this.txtNoProducts.Location = new System.Drawing.Point(668, 300);
            this.txtNoProducts.Name = "txtNoProducts";
            this.txtNoProducts.ReadOnly = true;
            this.txtNoProducts.Size = new System.Drawing.Size(193, 31);
            this.txtNoProducts.TabIndex = 13;
            // 
            // lbNoProducts
            // 
            this.lbNoProducts.AutoSize = true;
            this.lbNoProducts.Location = new System.Drawing.Point(499, 300);
            this.lbNoProducts.Name = "lbNoProducts";
            this.lbNoProducts.Size = new System.Drawing.Size(154, 25);
            this.lbNoProducts.TabIndex = 12;
            this.lbNoProducts.Text = "No of Products";
            // 
            // txtAvgProductPrice
            // 
            this.txtAvgProductPrice.Location = new System.Drawing.Point(1107, 306);
            this.txtAvgProductPrice.Name = "txtAvgProductPrice";
            this.txtAvgProductPrice.ReadOnly = true;
            this.txtAvgProductPrice.Size = new System.Drawing.Size(193, 31);
            this.txtAvgProductPrice.TabIndex = 15;
            // 
            // lbAvgProductPrice
            // 
            this.lbAvgProductPrice.AutoSize = true;
            this.lbAvgProductPrice.Location = new System.Drawing.Point(911, 309);
            this.lbAvgProductPrice.Name = "lbAvgProductPrice";
            this.lbAvgProductPrice.Size = new System.Drawing.Size(190, 25);
            this.lbAvgProductPrice.TabIndex = 14;
            this.lbAvgProductPrice.Text = "Avg. Product Price";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 51);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 564);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAvgProductPrice);
            this.Controls.Add(this.lbAvgProductPrice);
            this.Controls.Add(this.txtNoProducts);
            this.Controls.Add(this.lbNoProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProductCode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNoProducts;
        private System.Windows.Forms.Label lbNoProducts;
        private System.Windows.Forms.TextBox txtAvgProductPrice;
        private System.Windows.Forms.Label lbAvgProductPrice;
        private System.Windows.Forms.Button btnExit;
    }
}

