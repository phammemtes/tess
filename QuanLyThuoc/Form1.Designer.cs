namespace QuanLyThuoc
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
            this.bttk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datensx = new System.Windows.Forms.DateTimePicker();
            this.datahsd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(199, 245);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(75, 23);
            this.bttk.TabIndex = 0;
            this.bttk.Text = "Tìm Kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(844, 314);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 3;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(844, 362);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 4;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(844, 417);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(779, 117);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(256, 22);
            this.txtsoluong.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(260, 95);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(258, 22);
            this.txtten.TabIndex = 9;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(260, 49);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(258, 22);
            this.txtma.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên Thuốc";
            // 
            // datensx
            // 
            this.datensx.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.datensx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datensx.Location = new System.Drawing.Point(260, 141);
            this.datensx.Name = "datensx";
            this.datensx.Size = new System.Drawing.Size(200, 22);
            this.datensx.TabIndex = 16;
            // 
            // datahsd
            // 
            this.datahsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datahsd.Location = new System.Drawing.Point(260, 183);
            this.datahsd.Name = "datahsd";
            this.datahsd.Size = new System.Drawing.Size(200, 22);
            this.datahsd.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.datahsd);
            this.Controls.Add(this.datensx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datensx;
        private System.Windows.Forms.DateTimePicker datahsd;
    }
}

