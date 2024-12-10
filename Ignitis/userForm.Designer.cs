namespace Ignitis
{
    partial class userForm
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
            logoutButton = new Button();
            dataGridView1 = new DataGridView();
            calculatediscount = new Button();
            CostWithDiscount = new TextBox();
            button1 = new Button();
            Your_Group_Number = new DataGridViewTextBoxColumn();
            house_number = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            utility_name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(671, 12);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(101, 33);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Your_Group_Number, house_number, discount, utility_name, price });
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(760, 174);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // calculatediscount
            // 
            calculatediscount.Location = new Point(12, 245);
            calculatediscount.Name = "calculatediscount";
            calculatediscount.Size = new Size(168, 35);
            calculatediscount.TabIndex = 3;
            calculatediscount.Text = "Calculate cost with discount";
            calculatediscount.UseVisualStyleBackColor = true;
            calculatediscount.Click += calculatediscount_Click;
            // 
            // CostWithDiscount
            // 
            CostWithDiscount.AcceptsTab = true;
            CostWithDiscount.Enabled = false;
            CostWithDiscount.Location = new Point(12, 286);
            CostWithDiscount.Name = "CostWithDiscount";
            CostWithDiscount.Size = new Size(168, 23);
            CostWithDiscount.TabIndex = 4;
            CostWithDiscount.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(604, 245);
            button1.Name = "button1";
            button1.Size = new Size(168, 35);
            button1.TabIndex = 5;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            // 
            // Your_Group_Number
            // 
            Your_Group_Number.DataPropertyName = "group_id";
            Your_Group_Number.HeaderText = "Your Group Number";
            Your_Group_Number.Name = "Your_Group_Number";
            Your_Group_Number.ReadOnly = true;
            Your_Group_Number.Width = 135;
            // 
            // house_number
            // 
            house_number.DataPropertyName = "house_number";
            house_number.HeaderText = "Your House Number";
            house_number.Name = "house_number";
            house_number.ReadOnly = true;
            house_number.Width = 135;
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            discount.Width = 135;
            // 
            // utility_name
            // 
            utility_name.DataPropertyName = "name";
            utility_name.HeaderText = "Utility Name";
            utility_name.Name = "utility_name";
            utility_name.ReadOnly = true;
            utility_name.Width = 200;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 110;
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(button1);
            Controls.Add(CostWithDiscount);
            Controls.Add(calculatediscount);
            Controls.Add(dataGridView1);
            Controls.Add(logoutButton);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "userForm";
            Text = "userForm";
            Load += userForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private DataGridView dataGridView1;
        private Button calculatediscount;
        private TextBox CostWithDiscount;
        private Button button1;
        private DataGridViewTextBoxColumn Your_Group_Number;
        private DataGridViewTextBoxColumn house_number;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn utility_name;
        private DataGridViewTextBoxColumn price;
    }
}