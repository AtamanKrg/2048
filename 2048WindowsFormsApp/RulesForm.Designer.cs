namespace _2048WindowsFormsApp
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.rulesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.rulesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesTextBox.Location = new System.Drawing.Point(12, 12);
            this.rulesTextBox.Multiline = true;
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ReadOnly = true;
            this.rulesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rulesTextBox.Size = new System.Drawing.Size(556, 545);
            this.rulesTextBox.TabIndex = 0;
            this.rulesTextBox.Text = resources.GetString("rulesTextBox.Text");
            this.rulesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(580, 581);
            this.Controls.Add(this.rulesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RulesForm";
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rulesTextBox;
    }
}