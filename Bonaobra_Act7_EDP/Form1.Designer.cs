namespace Bonaobra_Act7_EDP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.btnLoadCustomers = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadEmployees = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(664, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.Location = new System.Drawing.Point(156, 361);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(109, 23);
            this.btnLoadProducts.TabIndex = 1;
            this.btnLoadProducts.Text = "Load Products";
            this.btnLoadProducts.UseVisualStyleBackColor = true;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // btnLoadCustomers
            // 
            this.btnLoadCustomers.Location = new System.Drawing.Point(271, 361);
            this.btnLoadCustomers.Name = "btnLoadCustomers";
            this.btnLoadCustomers.Size = new System.Drawing.Size(109, 23);
            this.btnLoadCustomers.TabIndex = 2;
            this.btnLoadCustomers.Text = "Load Customers";
            this.btnLoadCustomers.UseVisualStyleBackColor = true;
            this.btnLoadCustomers.Click += new System.EventHandler(this.btnLoadCustomers_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(156, 390);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 23);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnLoadEmployees
            // 
            this.btnLoadEmployees.Location = new System.Drawing.Point(386, 361);
            this.btnLoadEmployees.Name = "btnLoadEmployees";
            this.btnLoadEmployees.Size = new System.Drawing.Size(109, 23);
            this.btnLoadEmployees.TabIndex = 6;
            this.btnLoadEmployees.Text = "Load Employees";
            this.btnLoadEmployees.UseVisualStyleBackColor = true;
            this.btnLoadEmployees.Click += new System.EventHandler(this.btnLoadEmployees_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(272, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(326, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 24);
            this.button7.TabIndex = 10;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(387, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 22);
            this.button8.TabIndex = 11;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(436, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(688, 448);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLoadEmployees);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnLoadCustomers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadProducts);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.Button btnLoadCustomers;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadEmployees;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

