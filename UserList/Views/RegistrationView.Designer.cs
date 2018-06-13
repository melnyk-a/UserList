namespace UserList.Views
{
    partial class RegistrationView
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.validationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.usernameValidator = new UserList.Views.InputValidator();
            this.passwordValidator = new UserList.Views.InputValidator();
            this.confirmPasswordValidator = new UserList.Views.InputValidator();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(210, 122);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 26);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(86, 122);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(106, 26);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // usernameValidator
            // 
            this.usernameValidator.Input = "";
            this.usernameValidator.IsValid = false;
            this.usernameValidator.Location = new System.Drawing.Point(13, 13);
            this.usernameValidator.Name = "usernameValidator";
            this.usernameValidator.Size = new System.Drawing.Size(394, 30);
            this.usernameValidator.TabIndex = 15;
            this.usernameValidator.Title = "Username:";
            // 
            // passwordValidator
            // 
            this.passwordValidator.Input = "";
            this.passwordValidator.IsValid = false;
            this.passwordValidator.Location = new System.Drawing.Point(13, 50);
            this.passwordValidator.Name = "passwordValidator";
            this.passwordValidator.Size = new System.Drawing.Size(394, 30);
            this.passwordValidator.TabIndex = 16;
            this.passwordValidator.Title = "Password:";
            // 
            // confirmPasswordValidator
            // 
            this.confirmPasswordValidator.Input = "";
            this.confirmPasswordValidator.IsValid = false;
            this.confirmPasswordValidator.Location = new System.Drawing.Point(13, 87);
            this.confirmPasswordValidator.Name = "confirmPasswordValidator";
            this.confirmPasswordValidator.Size = new System.Drawing.Size(394, 30);
            this.confirmPasswordValidator.TabIndex = 17;
            this.confirmPasswordValidator.Title = "Confirm password:";
            // 
            // RegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(425, 159);
            this.Controls.Add(this.confirmPasswordValidator);
            this.Controls.Add(this.passwordValidator);
            this.Controls.Add(this.usernameValidator);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegistrationView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ToolTip validationToolTip;
        private InputValidator usernameValidator;
        private InputValidator passwordValidator;
        private InputValidator confirmPasswordValidator;
    }
}