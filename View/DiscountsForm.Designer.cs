namespace View
{
    partial class DiscountsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView.Location = new System.Drawing.Point(136, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(244, 193);
            this.DataGridView.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonAddObject);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скидка";
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(3, 19);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(109, 30);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(3, 55);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(109, 28);
            this.ButtonDelete.TabIndex = 9;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(12, 177);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(112, 28);
            this.ButtonLoad.TabIndex = 11;
            this.ButtonLoad.Text = "Загрузить";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 143);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(112, 28);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(12, 109);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(112, 28);
            this.ButtonFind.TabIndex = 12;
            this.ButtonFind.Text = "Поиск";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип скидки";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Конечная стоимость";
            this.Column2.Name = "Column2";
            // 
            // FormDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 216);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonFind);
            this.Name = "FormDiscounts";
            this.Text = "FormDiscounts";
            this.Activated += new System.EventHandler(this.FormDiscounts_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

