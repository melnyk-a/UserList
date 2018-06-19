namespace UserList.Views
{
    partial class AuthenticationView
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameValidator = new UserList.Views.InputValidator();
            this.passwordValidator = new UserList.Views.InputValidator();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(90, 77);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(106, 28);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(213, 77);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(106, 28);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // usernameValidator
            // 
            this.usernameValidator.Input = "";
            this.usernameValidator.IsValid = false;
            this.usernameValidator.Location = new System.Drawing.Point(12, 12);
            this.usernameValidator.Name = "usernameValidator";
            this.usernameValidator.Size = new System.Drawing.Size(394, 30);
            this.usernameValidator.TabIndex = 7;
            this.usernameValidator.Title = "Username:";
            // 
            // passwordValidator
            // 
            this.passwordValidator.Input = "";
            this.passwordValidator.IsPassword = true;
            this.passwordValidator.IsValid = false;
            this.passwordValidator.Location = new System.Drawing.Point(12, 42);
            this.passwordValidator.Name = "passwordValidator";
            this.passwordValidator.Size = new System.Drawing.Size(394, 30);
            this.passwordValidator.TabIndex = 9;
            this.passwordValidator.Title = "Password:";
            // 
            // AuthenticationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 116);
            this.Controls.Add(this.passwordValidator);
            this.Controls.Add(this.usernameValidator);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthenticationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private InputValidator usernameValidator;
        private InputValidator passwordValidator;
    }
}