namespace Lab_merge
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
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(450, 49);
            this.chart1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Text = "екраопрпр";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Controls.SetChildIndex(this.radioButton1, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton11, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton2, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton10, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton3, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton9, 0);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            // 
            // listBox2
            // 
            this.listBox2.ItemHeight = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(8, 88);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(74, 20);
            this.radioButton9.TabIndex = 10;
            this.radioButton9.TabStop = true;
            this.radioButton9.Tag = "3";
            this.radioButton9.Text = "random";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(11, 60);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(54, 20);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Tag = "2";
            this.radioButton10.Text = "N...1";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(11, 32);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(54, 20);
            this.radioButton11.TabIndex = 8;
            this.radioButton11.TabStop = true;
            this.radioButton11.Tag = "1";
            this.radioButton11.Text = "1...N";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 764);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioButton9;
        public System.Windows.Forms.RadioButton radioButton10;
        public System.Windows.Forms.RadioButton radioButton11;
    }
}

