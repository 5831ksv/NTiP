namespace View
{
    partial class PercentForm
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
            this.button1Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(146, 74);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(92, 23);
            this.button1Calculate.TabIndex = 16;
            this.button1Calculate.Text = "Рассчет";
            this.button1Calculate.UseVisualStyleBackColor = true;
            this.button1Calculate.Click += new System.EventHandler(this.button1Calculate_Click);
            this.button1Calculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Размер скидки в %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Стоимость товара";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(142, 18);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(89, 20);
            this.textBoxPrice.TabIndex = 17;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(208, 122);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 18;
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(146, 48);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(36, 20);
            this.textBoxPercent.TabIndex = 19;
            this.textBoxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPercent_KeyPress);
            // 
            // FormPercent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 100);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Name = "FormPercent";
            this.Text = "FormPercent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBoxPercent;
    }
}