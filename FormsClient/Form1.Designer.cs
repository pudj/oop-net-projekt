namespace FormsClient
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
            this.ResultBox = new System.Windows.Forms.ComboBox();
            this.Naziv_Fifa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.Location = new System.Drawing.Point(59, 12);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(121, 21);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.SelectedIndexChanged += new System.EventHandler(this.ResultBox_SelectedIndexChanged);
            // 
            // Naziv_Fifa
            // 
            this.Naziv_Fifa.AutoSize = true;
            this.Naziv_Fifa.Location = new System.Drawing.Point(17, 16);
            this.Naziv_Fifa.Name = "Naziv_Fifa";
            this.Naziv_Fifa.Size = new System.Drawing.Size(34, 13);
            this.Naziv_Fifa.TabIndex = 1;
            this.Naziv_Fifa.Text = "Naziv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Naziv_Fifa);
            this.Controls.Add(this.ResultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ResultBox;
        private System.Windows.Forms.Label Naziv_Fifa;
    }
}

