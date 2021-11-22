namespace CRM_Form
{
    partial class Form1
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
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.btnDetay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployee
            // 
            this.lstEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 20;
            this.lstEmployee.Location = new System.Drawing.Point(15, 15);
            this.lstEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(366, 484);
            this.lstEmployee.TabIndex = 0;
            this.lstEmployee.SelectedIndexChanged += new System.EventHandler(this.lstEmployee_SelectedIndexChanged);
            // 
            // btnDetay
            // 
            this.btnDetay.Location = new System.Drawing.Point(389, 15);
            this.btnDetay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(148, 72);
            this.btnDetay.TabIndex = 1;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 521);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.lstEmployee);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.Button btnDetay;
    }
}
