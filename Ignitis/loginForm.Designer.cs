namespace Ignitis
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            clearUsernameButton = new Button();
            clearPasswordButton = new Button();
            showPasswordButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Location = new Point(304, 260);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(163, 51);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += enterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 143);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(259, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 23);
            txtUsername.TabIndex = 2;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(259, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 188);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // clearUsernameButton
            // 
            clearUsernameButton.Location = new Point(551, 140);
            clearUsernameButton.Name = "clearUsernameButton";
            clearUsernameButton.Size = new Size(75, 23);
            clearUsernameButton.TabIndex = 5;
            clearUsernameButton.Text = "Clear";
            clearUsernameButton.UseVisualStyleBackColor = true;
            clearUsernameButton.Click += clearUsernameButton_Click;
            // 
            // clearPasswordButton
            // 
            clearPasswordButton.Location = new Point(551, 185);
            clearPasswordButton.Name = "clearPasswordButton";
            clearPasswordButton.Size = new Size(75, 23);
            clearPasswordButton.TabIndex = 6;
            clearPasswordButton.Text = "Clear";
            clearPasswordButton.UseVisualStyleBackColor = true;
            clearPasswordButton.Click += clearPasswordButton_Click;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Location = new Point(259, 214);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(107, 23);
            showPasswordButton.TabIndex = 7;
            showPasswordButton.Text = "Show password";
            showPasswordButton.UseVisualStyleBackColor = true;
            showPasswordButton.Click += button1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(showPasswordButton);
            Controls.Add(clearPasswordButton);
            Controls.Add(clearUsernameButton);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(loginButton);
            MaximumSize = new Size(800, 400);
            MinimumSize = new Size(800, 400);
            Name = "loginForm";
            Text = "Prisijungimas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button clearUsernameButton;
        private Button clearPasswordButton;
        private Button showPasswordButton;
    }
}
