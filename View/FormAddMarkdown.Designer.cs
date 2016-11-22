namespace View
{
    partial class FormAddMarkdown
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
            this.buttonCloseTabPerc = new System.Windows.Forms.Button();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPercentCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.buttonCloseTabDisc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiscountMarkdown = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxPriceDiscount = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPercent.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPercent);
            this.tabControl.Controls.Add(this.tabDiscount);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(251, 119);
            this.tabControl.TabIndex = 28;
            // 
            // tabPercent
            // 
            this.tabPercent.Controls.Add(this.buttonCloseTabPerc);
            this.tabPercent.Controls.Add(this.textBoxPercent);
            this.tabPercent.Controls.Add(this.textBoxPrice);
            this.tabPercent.Controls.Add(this.label1);
            this.tabPercent.Controls.Add(this.buttonPercentCalculate);
            this.tabPercent.Controls.Add(this.label2);
            this.tabPercent.Location = new System.Drawing.Point(4, 22);
            this.tabPercent.Name = "tabPercent";
            this.tabPercent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPercent.Size = new System.Drawing.Size(243, 93);
            this.tabPercent.TabIndex = 0;
            this.tabPercent.Text = "Процентная";
            this.tabPercent.UseVisualStyleBackColor = true;
            // 
            // buttonCloseTabPerc
            // 
            this.buttonCloseTabPerc.Location = new System.Drawing.Point(142, 63);
            this.buttonCloseTabPerc.Name = "buttonCloseTabPerc";
            this.buttonCloseTabPerc.Size = new System.Drawing.Size(89, 23);
            this.buttonCloseTabPerc.TabIndex = 34;
            this.buttonCloseTabPerc.Text = "Закрыть";
            this.buttonCloseTabPerc.UseVisualStyleBackColor = true;
            this.buttonCloseTabPerc.Click += new System.EventHandler(this.buttonCloseEvent_Click);
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(195, 34);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(36, 20);
            this.textBoxPercent.TabIndex = 33;
            this.textBoxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValidation_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(142, 10);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(89, 20);
            this.textBoxPrice.TabIndex = 32;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValidation_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Стоимость товара";
            // 
            // buttonPercentCalculate
            // 
            this.buttonPercentCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercentCalculate.Location = new System.Drawing.Point(47, 63);
            this.buttonPercentCalculate.Name = "buttonPercentCalculate";
            this.buttonPercentCalculate.Size = new System.Drawing.Size(89, 23);
            this.buttonPercentCalculate.TabIndex = 31;
            this.buttonPercentCalculate.Text = "Рассчет";
            this.buttonPercentCalculate.UseVisualStyleBackColor = true;
            this.buttonPercentCalculate.Click += new System.EventHandler(this.buttonPercentCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Размер скидки (в процентах)";
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.buttonCloseTabDisc);
            this.tabDiscount.Controls.Add(this.label7);
            this.tabDiscount.Controls.Add(this.label6);
            this.tabDiscount.Controls.Add(this.textBoxDiscountMarkdown);
            this.tabDiscount.Controls.Add(this.buttonCalculate);
            this.tabDiscount.Controls.Add(this.textBoxPriceDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(4, 22);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(243, 93);
            this.tabDiscount.TabIndex = 1;
            this.tabDiscount.Text = "Сертификатная";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonCloseTabDisc
            // 
            this.buttonCloseTabDisc.Location = new System.Drawing.Point(142, 63);
            this.buttonCloseTabDisc.Name = "buttonCloseTabDisc";
            this.buttonCloseTabDisc.Size = new System.Drawing.Size(89, 23);
            this.buttonCloseTabDisc.TabIndex = 35;
            this.buttonCloseTabDisc.Text = "Закрыть";
            this.buttonCloseTabDisc.UseVisualStyleBackColor = true;
            this.buttonCloseTabDisc.Click += new System.EventHandler(this.buttonCloseEvent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Стоимость товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Размер скидки";
            // 
            // textBoxDiscountMarkdown
            // 
            this.textBoxDiscountMarkdown.Location = new System.Drawing.Point(142, 34);
            this.textBoxDiscountMarkdown.Name = "textBoxDiscountMarkdown";
            this.textBoxDiscountMarkdown.Size = new System.Drawing.Size(89, 20);
            this.textBoxDiscountMarkdown.TabIndex = 27;
            this.textBoxDiscountMarkdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValidation_KeyPress);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(47, 63);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 23);
            this.buttonCalculate.TabIndex = 25;
            this.buttonCalculate.Text = "Рассчет";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonDiscountCalculate_Click);
            // 
            // textBoxPriceDiscount
            // 
            this.textBoxPriceDiscount.Location = new System.Drawing.Point(142, 10);
            this.textBoxPriceDiscount.Name = "textBoxPriceDiscount";
            this.textBoxPriceDiscount.Size = new System.Drawing.Size(89, 20);
            this.textBoxPriceDiscount.TabIndex = 26;
            this.textBoxPriceDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValidation_KeyPress);
            // 
            // FormAddMarkdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 138);
            this.Controls.Add(this.tabControl);
            this.Name = "FormAddMarkdown";
            this.Text = "Добавление скидки";
            this.tabControl.ResumeLayout(false);
            this.tabPercent.ResumeLayout(false);
            this.tabPercent.PerformLayout();
            this.tabDiscount.ResumeLayout(false);
            this.tabDiscount.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonPercentCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseTabPerc;
        private System.Windows.Forms.Button buttonCloseTabDisc;
    }
}