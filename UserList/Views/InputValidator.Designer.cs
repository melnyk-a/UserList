namespace UserList.Views
{
    partial class InputValidator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.validationToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(161, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(194, 22);
            this.textBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(13, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 23);
            this.label.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::UserList.Properties.Resources.Incorrect;
            this.pictureBox.Location = new System.Drawing.Point(361, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(25, 22);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // validationToolTip
            // 
            this.validationToolTip.AutomaticDelay = 0;
            this.validationToolTip.AutoPopDelay = 5000;
            this.validationToolTip.InitialDelay = 0;
            this.validationToolTip.ReshowDelay = 0;
            this.validationToolTip.ToolTipTitle = "Validation Error";
            // 
            // InputValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Name = "InputValidator";
            this.Size = new System.Drawing.Size(394, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolTip validationToolTip;
    }
}
