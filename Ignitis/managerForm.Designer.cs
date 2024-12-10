namespace Ignitis
{
    partial class managerForm
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
            Utility = new DataGridView();
            ChangePriceButton = new Button();
            changePricePanel = new Panel();
            button1 = new Button();
            SaveNewPriceButton = new Button();
            EditPriceTextBox = new TextBox();
            label1 = new Label();
            changeDiscountButton = new Button();
            changeDiscountPanel = new Panel();
            HideButton2 = new Button();
            saveDiscountButton = new Button();
            discountTextBox = new TextBox();
            label2 = new Label();
            Group = new DataGridView();
            Group_ID = new DataGridViewTextBoxColumn();
            House_number = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Utility).BeginInit();
            changePricePanel.SuspendLayout();
            changeDiscountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Group).BeginInit();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(712, 12);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(76, 30);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += button1_Click;
            // 
            // Utility
            // 
            Utility.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Utility.Location = new Point(12, 22);
            Utility.Name = "Utility";
            Utility.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Utility.Size = new Size(344, 212);
            Utility.TabIndex = 1;
            Utility.CellContentClick += dataGridView1_CellContentClick;
            Utility.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // ChangePriceButton
            // 
            ChangePriceButton.Location = new Point(12, 249);
            ChangePriceButton.Name = "ChangePriceButton";
            ChangePriceButton.Size = new Size(143, 61);
            ChangePriceButton.TabIndex = 2;
            ChangePriceButton.Text = "Change Price of the selected Utility";
            ChangePriceButton.UseVisualStyleBackColor = true;
            ChangePriceButton.Click += ChangePriceButton_Click;
            // 
            // changePricePanel
            // 
            changePricePanel.BackColor = SystemColors.AppWorkspace;
            changePricePanel.Controls.Add(button1);
            changePricePanel.Controls.Add(SaveNewPriceButton);
            changePricePanel.Controls.Add(EditPriceTextBox);
            changePricePanel.Controls.Add(label1);
            changePricePanel.Location = new Point(88, 249);
            changePricePanel.MaximumSize = new Size(200, 100);
            changePricePanel.MinimumSize = new Size(200, 100);
            changePricePanel.Name = "changePricePanel";
            changePricePanel.Size = new Size(200, 100);
            changePricePanel.TabIndex = 3;
            changePricePanel.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 6F);
            button1.Location = new Point(161, 3);
            button1.Name = "button1";
            button1.Size = new Size(36, 30);
            button1.TabIndex = 3;
            button1.Text = "Hide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SaveNewPriceButton
            // 
            SaveNewPriceButton.Location = new Point(54, 68);
            SaveNewPriceButton.Name = "SaveNewPriceButton";
            SaveNewPriceButton.Size = new Size(75, 23);
            SaveNewPriceButton.TabIndex = 2;
            SaveNewPriceButton.Text = "Save";
            SaveNewPriceButton.UseVisualStyleBackColor = true;
            SaveNewPriceButton.Click += SaveNewPriceButton_Click;
            // 
            // EditPriceTextBox
            // 
            EditPriceTextBox.Location = new Point(35, 39);
            EditPriceTextBox.Name = "EditPriceTextBox";
            EditPriceTextBox.Size = new Size(133, 23);
            EditPriceTextBox.TabIndex = 1;
            EditPriceTextBox.TextChanged += EditPriceTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter new price:";
            label1.Click += label1_Click;
            // 
            // changeDiscountButton
            // 
            changeDiscountButton.Location = new Point(362, 254);
            changeDiscountButton.Name = "changeDiscountButton";
            changeDiscountButton.Size = new Size(143, 59);
            changeDiscountButton.TabIndex = 5;
            changeDiscountButton.Text = "Change the Discount value";
            changeDiscountButton.UseVisualStyleBackColor = true;
            changeDiscountButton.Click += changeDiscountButton_Click;
            // 
            // changeDiscountPanel
            // 
            changeDiscountPanel.BackColor = SystemColors.AppWorkspace;
            changeDiscountPanel.Controls.Add(HideButton2);
            changeDiscountPanel.Controls.Add(saveDiscountButton);
            changeDiscountPanel.Controls.Add(discountTextBox);
            changeDiscountPanel.Controls.Add(label2);
            changeDiscountPanel.Location = new Point(444, 249);
            changeDiscountPanel.MaximumSize = new Size(200, 100);
            changeDiscountPanel.MinimumSize = new Size(200, 100);
            changeDiscountPanel.Name = "changeDiscountPanel";
            changeDiscountPanel.Size = new Size(200, 100);
            changeDiscountPanel.TabIndex = 6;
            changeDiscountPanel.Visible = false;
            // 
            // HideButton2
            // 
            HideButton2.Font = new Font("Segoe UI", 6F);
            HideButton2.Location = new Point(161, 3);
            HideButton2.Name = "HideButton2";
            HideButton2.Size = new Size(36, 30);
            HideButton2.TabIndex = 3;
            HideButton2.Text = "Hide";
            HideButton2.UseVisualStyleBackColor = true;
            HideButton2.Click += HideButton2_Click;
            // 
            // saveDiscountButton
            // 
            saveDiscountButton.Location = new Point(54, 68);
            saveDiscountButton.Name = "saveDiscountButton";
            saveDiscountButton.Size = new Size(75, 23);
            saveDiscountButton.TabIndex = 2;
            saveDiscountButton.Text = "Save";
            saveDiscountButton.UseVisualStyleBackColor = true;
            saveDiscountButton.Click += saveDiscountButton_Click;
            // 
            // discountTextBox
            // 
            discountTextBox.Location = new Point(35, 39);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.Size = new Size(133, 23);
            discountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 21);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 0;
            label2.Text = "Enter new Discount:";
            // 
            // Group
            // 
            Group.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Group.Columns.AddRange(new DataGridViewColumn[] { Group_ID, House_number, discount });
            Group.Location = new Point(362, 23);
            Group.Name = "Group";
            Group.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Group.Size = new Size(344, 211);
            Group.TabIndex = 7;
            // 
            // Group_ID
            // 
            Group_ID.DataPropertyName = "group_id";
            Group_ID.HeaderText = "Group ID";
            Group_ID.Name = "Group_ID";
            Group_ID.ReadOnly = true;
            // 
            // House_number
            // 
            House_number.DataPropertyName = "house_number";
            House_number.HeaderText = "House Number";
            House_number.Name = "House_number";
            House_number.ReadOnly = true;
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // managerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(Group);
            Controls.Add(changeDiscountPanel);
            Controls.Add(changeDiscountButton);
            Controls.Add(changePricePanel);
            Controls.Add(ChangePriceButton);
            Controls.Add(Utility);
            Controls.Add(logoutButton);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "managerForm";
            Text = "managerForm";
            Load += managerForm_Load;
            Leave += managerForm_Leave;
            ((System.ComponentModel.ISupportInitialize)Utility).EndInit();
            changePricePanel.ResumeLayout(false);
            changePricePanel.PerformLayout();
            changeDiscountPanel.ResumeLayout(false);
            changeDiscountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Group).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private DataGridView Utility;
        private Button ChangePriceButton;
        private Panel changePricePanel;
        private TextBox EditPriceTextBox;
        private Label label1;
        private Button SaveNewPriceButton;
        private Button button1;
        private Button changeDiscountButton;
        private Panel changeDiscountPanel;
        private Button HideButton2;
        private Button saveDiscountButton;
        private TextBox discountTextBox;
        private Label label2;
        private DataGridView Group;
        private DataGridViewTextBoxColumn Group_ID;
        private DataGridViewTextBoxColumn House_number;
        private DataGridViewTextBoxColumn discount;
    }
}