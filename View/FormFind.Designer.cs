﻿namespace View
{
    partial class FormFind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCertificate = new System.Windows.Forms.CheckBox();
            this.checkBoxPercent = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCloseEvent = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 241);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCertificate);
            this.groupBox1.Controls.Add(this.checkBoxPercent);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип скидки";
            // 
            // checkBoxCertificate
            // 
            this.checkBoxCertificate.AutoSize = true;
            this.checkBoxCertificate.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCertificate.Name = "checkBoxCertificate";
            this.checkBoxCertificate.Size = new System.Drawing.Size(105, 17);
            this.checkBoxCertificate.TabIndex = 3;
            this.checkBoxCertificate.Text = "Сертификатная";
            this.checkBoxCertificate.UseVisualStyleBackColor = true;
            // 
            // checkBoxPercent
            // 
            this.checkBoxPercent.AutoSize = true;
            this.checkBoxPercent.Location = new System.Drawing.Point(6, 42);
            this.checkBoxPercent.Name = "checkBoxPercent";
            this.checkBoxPercent.Size = new System.Drawing.Size(87, 17);
            this.checkBoxPercent.TabIndex = 0;
            this.checkBoxPercent.Text = "Процентная";
            this.checkBoxPercent.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(346, 274);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(109, 23);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Конечная стоимость";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(254, 275);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(62, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // buttonCloseEvent
            // 
            this.buttonCloseEvent.Location = new System.Drawing.Point(346, 307);
            this.buttonCloseEvent.Name = "buttonCloseEvent";
            this.buttonCloseEvent.Size = new System.Drawing.Size(109, 23);
            this.buttonCloseEvent.TabIndex = 12;
            this.buttonCloseEvent.Text = "Закрыть";
            this.buttonCloseEvent.UseVisualStyleBackColor = true;
            this.buttonCloseEvent.Click += new System.EventHandler(this.buttonCloseEvent_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип скидки";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Конечная стоимость";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Размер скидки";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Начальная стоимость";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 342);
            this.Controls.Add(this.buttonCloseEvent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "FormFind";
            this.Text = "FormFind";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCertificate;
        private System.Windows.Forms.CheckBox checkBoxPercent;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonCloseEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}