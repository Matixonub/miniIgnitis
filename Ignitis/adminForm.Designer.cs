namespace Ignitis
{
    partial class adminForm
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
            UserTableMainButton = new Button();
            GroupTableMainButton = new Button();
            UtilityTableMainButton = new Button();
            UtilitiesTableMainButton = new Button();
            MainBox = new GroupBox();
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            AddButton = new Button();
            MainBox.SuspendLayout();
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
            // UserTableMainButton
            // 
            UserTableMainButton.Location = new Point(30, 253);
            UserTableMainButton.Name = "UserTableMainButton";
            UserTableMainButton.Size = new Size(152, 79);
            UserTableMainButton.TabIndex = 2;
            UserTableMainButton.Text = "Edit Users";
            UserTableMainButton.UseVisualStyleBackColor = true;
            UserTableMainButton.Click += UserTableMainButton_Click;
            // 
            // GroupTableMainButton
            // 
            GroupTableMainButton.Location = new Point(220, 253);
            GroupTableMainButton.Name = "GroupTableMainButton";
            GroupTableMainButton.Size = new Size(152, 79);
            GroupTableMainButton.TabIndex = 3;
            GroupTableMainButton.Text = "Edit Groups";
            GroupTableMainButton.UseVisualStyleBackColor = true;
            GroupTableMainButton.Click += GroupTableMainButton_Click;
            // 
            // UtilityTableMainButton
            // 
            UtilityTableMainButton.Location = new Point(413, 253);
            UtilityTableMainButton.Name = "UtilityTableMainButton";
            UtilityTableMainButton.Size = new Size(152, 79);
            UtilityTableMainButton.TabIndex = 4;
            UtilityTableMainButton.Text = "Edit Utility";
            UtilityTableMainButton.UseVisualStyleBackColor = true;
            UtilityTableMainButton.Click += UtilityTableMainButton_Click;
            // 
            // UtilitiesTableMainButton
            // 
            UtilitiesTableMainButton.Location = new Point(609, 253);
            UtilitiesTableMainButton.Name = "UtilitiesTableMainButton";
            UtilitiesTableMainButton.Size = new Size(152, 79);
            UtilitiesTableMainButton.TabIndex = 5;
            UtilitiesTableMainButton.Text = "Edit Utilities";
            UtilitiesTableMainButton.UseVisualStyleBackColor = true;
            UtilitiesTableMainButton.Click += UtilitiesTableMainButton_Click;
            // 
            // MainBox
            // 
            MainBox.Controls.Add(dataGridView1);
            MainBox.Controls.Add(DeleteButton);
            MainBox.Controls.Add(AddButton);
            MainBox.Location = new Point(30, 60);
            MainBox.Name = "MainBox";
            MainBox.Size = new Size(731, 174);
            MainBox.TabIndex = 6;
            MainBox.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(573, 163);
            dataGridView1.TabIndex = 3;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(579, 63);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(132, 35);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete Selected";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(579, 22);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(132, 35);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add New";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(MainBox);
            Controls.Add(UtilitiesTableMainButton);
            Controls.Add(UtilityTableMainButton);
            Controls.Add(GroupTableMainButton);
            Controls.Add(UserTableMainButton);
            Controls.Add(logoutButton);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "adminForm";
            Text = "adminForm";
            MainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Button UserTableMainButton;
        private Button GroupTableMainButton;
        private Button UtilityTableMainButton;
        private Button UtilitiesTableMainButton;
        private GroupBox MainBox;
        private Button DeleteButton;
        private Button AddButton;
        private DataGridView dataGridView1;
    }
}