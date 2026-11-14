namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(49, 68);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(210, 20);
            this.txtNumber1.TabIndex = 1;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cbOperator.Location = new System.Drawing.Point(115, 104);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(83, 21);
            this.cbOperator.TabIndex = 2;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(49, 141);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(210, 20);
            this.txtNumber2.TabIndex = 3;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(115, 293);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(83, 39);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(49, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 100);
            this.panel1.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 47);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
    }
}

