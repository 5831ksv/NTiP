namespace View
{
    partial class FormCertificate
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPercent = new System.Windows.Forms.TabPage();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiscountMarkdown = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxPriceDiscount = new System.Windows.Forms.TextBox();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPercent);
            this.tabControl.Controls.Add(this.tabDiscount);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(398, 289);
            this.tabControl.TabIndex = 28;
            // 
            // tabPercent
            // 
            this.tabPercent.Location = new System.Drawing.Point(4, 22);
            this.tabPercent.Name = "tabPercent";
            this.tabPercent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPercent.Size = new System.Drawing.Size(390, 263);
            this.tabPercent.TabIndex = 0;
            this.tabPercent.Text = "Процентная";
            this.tabPercent.UseVisualStyleBackColor = true;
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.label7);
            this.tabDiscount.Controls.Add(this.label6);
            this.tabDiscount.Controls.Add(this.textBoxDiscountMarkdown);
            this.tabDiscount.Controls.Add(this.buttonCalculate);
            this.tabDiscount.Controls.Add(this.textBoxPriceDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(4, 22);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(390, 263);
            this.tabDiscount.TabIndex = 1;
            this.tabDiscount.Text = "Сертификатная";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Стоимость товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Размер скидки";
            // 
            // textBoxDiscountMarkdown
            // 
            this.textBoxDiscountMarkdown.Location = new System.Drawing.Point(161, 49);
            this.textBoxDiscountMarkdown.Name = "textBoxDiscountMarkdown";
            this.textBoxDiscountMarkdown.Size = new System.Drawing.Size(89, 20);
            this.textBoxDiscountMarkdown.TabIndex = 27;
            this.textBoxDiscountMarkdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscountMarkdown_KeyPress);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(27, 75);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(223, 23);
            this.buttonCalculate.TabIndex = 25;
            this.buttonCalculate.Text = "Рассчитать конечную стоимость";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxPriceDiscount
            // 
            this.textBoxPriceDiscount.Location = new System.Drawing.Point(161, 23);
            this.textBoxPriceDiscount.Name = "textBoxPriceDiscount";
            this.textBoxPriceDiscount.Size = new System.Drawing.Size(89, 20);
            this.textBoxPriceDiscount.TabIndex = 26;
            this.textBoxPriceDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceDiscount_KeyPress);
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(585, 135);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(36, 20);
            this.textBoxPercent.TabIndex = 33;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(585, 105);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(89, 20);
            this.textBoxPrice.TabIndex = 32;
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(454, 161);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(223, 23);
            this.button1Calculate.TabIndex = 31;
            this.button1Calculate.Text = "Рассчитать конечную стоимость";
            this.button1Calculate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(451, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Размер скидки в %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(451, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Стоимость товара";
            // 
            // FormCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 313);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "FormCertificate";
            this.Text = "Новая запись скидки";
            this.tabControl.ResumeLayout(false);
            this.tabDiscount.ResumeLayout(false);
            this.tabDiscount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPercent;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxDiscountMarkdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPriceDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}