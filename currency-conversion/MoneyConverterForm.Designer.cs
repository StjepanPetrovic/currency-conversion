namespace currency_conversion
{
    partial class MoneyConverterForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbFirstCurrency = new System.Windows.Forms.ComboBox();
            this.cbSecondCurrency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConvertedAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose first currency:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(98, 198);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(98, 243);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(126, 57);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbFirstCurrency
            // 
            this.cbFirstCurrency.FormattingEnabled = true;
            this.cbFirstCurrency.Location = new System.Drawing.Point(98, 64);
            this.cbFirstCurrency.Name = "cbFirstCurrency";
            this.cbFirstCurrency.Size = new System.Drawing.Size(126, 24);
            this.cbFirstCurrency.TabIndex = 3;
            // 
            // cbSecondCurrency
            // 
            this.cbSecondCurrency.FormattingEnabled = true;
            this.cbSecondCurrency.Location = new System.Drawing.Point(98, 128);
            this.cbSecondCurrency.Name = "cbSecondCurrency";
            this.cbSecondCurrency.Size = new System.Drawing.Size(126, 24);
            this.cbSecondCurrency.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose second currency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Converted amount:";
            // 
            // txtConvertedAmount
            // 
            this.txtConvertedAmount.Location = new System.Drawing.Point(98, 343);
            this.txtConvertedAmount.Name = "txtConvertedAmount";
            this.txtConvertedAmount.Size = new System.Drawing.Size(126, 22);
            this.txtConvertedAmount.TabIndex = 7;
            // 
            // MoneyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConvertedAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSecondCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFirstCurrency);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Name = "MoneyConverterForm";
            this.Text = "Money converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbFirstCurrency;
        private System.Windows.Forms.ComboBox cbSecondCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConvertedAmount;
    }
}

