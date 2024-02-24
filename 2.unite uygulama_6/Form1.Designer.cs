namespace _2.unite_uygulama_6
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
            this.cbLambaAcık = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKONtrol = new System.Windows.Forms.Button();
            this.lbKontrol = new System.Windows.Forms.ListBox();
            this.cbkombiAcık = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLambaAcık
            // 
            this.cbLambaAcık.AutoSize = true;
            this.cbLambaAcık.Location = new System.Drawing.Point(23, 19);
            this.cbLambaAcık.Name = "cbLambaAcık";
            this.cbLambaAcık.Size = new System.Drawing.Size(77, 17);
            this.cbLambaAcık.TabIndex = 0;
            this.cbLambaAcık.Text = "lamba açık";
            this.cbLambaAcık.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkombiAcık);
            this.groupBox1.Controls.Add(this.cbLambaAcık);
            this.groupBox1.Location = new System.Drawing.Point(91, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnKONtrol
            // 
            this.btnKONtrol.Location = new System.Drawing.Point(91, 147);
            this.btnKONtrol.Name = "btnKONtrol";
            this.btnKONtrol.Size = new System.Drawing.Size(161, 67);
            this.btnKONtrol.TabIndex = 2;
            this.btnKONtrol.Text = "kontrol";
            this.btnKONtrol.UseVisualStyleBackColor = true;
            this.btnKONtrol.Click += new System.EventHandler(this.btnKONtrol_Click);
            // 
            // lbKontrol
            // 
            this.lbKontrol.FormattingEnabled = true;
            this.lbKontrol.Location = new System.Drawing.Point(352, 17);
            this.lbKontrol.Name = "lbKontrol";
            this.lbKontrol.Size = new System.Drawing.Size(120, 212);
            this.lbKontrol.TabIndex = 3;
            // 
            // cbkombiAcık
            // 
            this.cbkombiAcık.AutoSize = true;
            this.cbkombiAcık.Location = new System.Drawing.Point(23, 42);
            this.cbkombiAcık.Name = "cbkombiAcık";
            this.cbkombiAcık.Size = new System.Drawing.Size(77, 17);
            this.cbkombiAcık.TabIndex = 1;
            this.cbkombiAcık.Text = "kombi açık";
            this.cbkombiAcık.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKontrol);
            this.Controls.Add(this.btnKONtrol);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLambaAcık;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbkombiAcık;
        private System.Windows.Forms.Button btnKONtrol;
        private System.Windows.Forms.ListBox lbKontrol;
    }
}

