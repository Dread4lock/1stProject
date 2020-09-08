namespace Nauka_2._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оСебеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employees2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naukaTestDBDataSet = new Nauka_2._0.NaukaTestDBDataSet();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Adresstbx = new System.Windows.Forms.TextBox();
            this.Unittbx = new System.Windows.Forms.TextBox();
            this.Abouttbx = new System.Windows.Forms.TextBox();
            this.Nametbx = new System.Windows.Forms.TextBox();
            this.Surnametbx = new System.Windows.Forms.TextBox();
            this.Secnametbx = new System.Windows.Forms.TextBox();
            this.Datetbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.employees2TableAdapter = new Nauka_2._0.NaukaTestDBDataSetTableAdapters.Employees2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naukaTestDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.отделDataGridViewTextBoxColumn,
            this.оСебеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employees2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // отделDataGridViewTextBoxColumn
            // 
            this.отделDataGridViewTextBoxColumn.DataPropertyName = "Отдел";
            this.отделDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.отделDataGridViewTextBoxColumn.Name = "отделDataGridViewTextBoxColumn";
            // 
            // оСебеDataGridViewTextBoxColumn
            // 
            this.оСебеDataGridViewTextBoxColumn.DataPropertyName = "О себе";
            this.оСебеDataGridViewTextBoxColumn.HeaderText = "О себе";
            this.оСебеDataGridViewTextBoxColumn.Name = "оСебеDataGridViewTextBoxColumn";
            // 
            // employees2BindingSource
            // 
            this.employees2BindingSource.DataMember = "Employees2";
            this.employees2BindingSource.DataSource = this.naukaTestDBDataSet;
            // 
            // naukaTestDBDataSet
            // 
            this.naukaTestDBDataSet.DataSetName = "NaukaTestDBDataSet";
            this.naukaTestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(567, 359);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(486, 359);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 23);
            this.Insertbtn.TabIndex = 1;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(405, 359);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 1;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Adresstbx
            // 
            this.Adresstbx.Location = new System.Drawing.Point(515, 288);
            this.Adresstbx.Name = "Adresstbx";
            this.Adresstbx.Size = new System.Drawing.Size(273, 20);
            this.Adresstbx.TabIndex = 2;
            // 
            // Unittbx
            // 
            this.Unittbx.Location = new System.Drawing.Point(515, 314);
            this.Unittbx.Name = "Unittbx";
            this.Unittbx.Size = new System.Drawing.Size(273, 20);
            this.Unittbx.TabIndex = 2;
            // 
            // Abouttbx
            // 
            this.Abouttbx.Location = new System.Drawing.Point(85, 357);
            this.Abouttbx.Multiline = true;
            this.Abouttbx.Name = "Abouttbx";
            this.Abouttbx.Size = new System.Drawing.Size(268, 63);
            this.Abouttbx.TabIndex = 2;
            // 
            // Nametbx
            // 
            this.Nametbx.Location = new System.Drawing.Point(114, 262);
            this.Nametbx.Name = "Nametbx";
            this.Nametbx.Size = new System.Drawing.Size(239, 20);
            this.Nametbx.TabIndex = 2;
            // 
            // Surnametbx
            // 
            this.Surnametbx.Location = new System.Drawing.Point(114, 288);
            this.Surnametbx.Name = "Surnametbx";
            this.Surnametbx.Size = new System.Drawing.Size(239, 20);
            this.Surnametbx.TabIndex = 2;
            // 
            // Secnametbx
            // 
            this.Secnametbx.Location = new System.Drawing.Point(114, 314);
            this.Secnametbx.Name = "Secnametbx";
            this.Secnametbx.Size = new System.Drawing.Size(239, 20);
            this.Secnametbx.TabIndex = 2;
            // 
            // Datetbx
            // 
            this.Datetbx.Location = new System.Drawing.Point(515, 262);
            this.Datetbx.Name = "Datetbx";
            this.Datetbx.Size = new System.Drawing.Size(273, 20);
            this.Datetbx.TabIndex = 2;
            this.Datetbx.Click += new System.EventHandler(this.Datetbx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата Рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Отдел";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "О себе";
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(654, 415);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(140, 23);
            this.Clearbtn.TabIndex = 1;
            this.Clearbtn.Text = "Clear all boxes";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // employees2TableAdapter
            // 
            this.employees2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datetbx);
            this.Controls.Add(this.Secnametbx);
            this.Controls.Add(this.Abouttbx);
            this.Controls.Add(this.Surnametbx);
            this.Controls.Add(this.Unittbx);
            this.Controls.Add(this.Nametbx);
            this.Controls.Add(this.Adresstbx);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naukaTestDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TextBox Adresstbx;
        private System.Windows.Forms.TextBox Unittbx;
        private System.Windows.Forms.TextBox Abouttbx;
        private System.Windows.Forms.TextBox Nametbx;
        private System.Windows.Forms.TextBox Surnametbx;
        private System.Windows.Forms.TextBox Secnametbx;
        private System.Windows.Forms.TextBox Datetbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clearbtn;
        private NaukaTestDBDataSet naukaTestDBDataSet;
        private System.Windows.Forms.BindingSource employees2BindingSource;
        private NaukaTestDBDataSetTableAdapters.Employees2TableAdapter employees2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оСебеDataGridViewTextBoxColumn;
    }
}

