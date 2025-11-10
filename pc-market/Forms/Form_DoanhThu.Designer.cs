namespace pc_market.Forms
{
    partial class Form_DoanhThu
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DoanhThu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDen = new System.Windows.Forms.MaskedTextBox();
            this.mskTu = new System.Windows.Forms.MaskedTextBox();
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            this.rdbKhoang = new System.Windows.Forms.RadioButton();
            this.rdbNgay = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnxuatfile = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskDen);
            this.groupBox1.Controls.Add(this.mskTu);
            this.groupBox1.Controls.Add(this.mskNgay);
            this.groupBox1.Controls.Add(this.rdbKhoang);
            this.groupBox1.Controls.Add(this.rdbNgay);
            this.groupBox1.Location = new System.Drawing.Point(77, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(771, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ";
            // 
            // mskDen
            // 
            this.mskDen.Location = new System.Drawing.Point(508, 87);
            this.mskDen.Margin = new System.Windows.Forms.Padding(4);
            this.mskDen.Mask = "00/00/0000";
            this.mskDen.Name = "mskDen";
            this.mskDen.Size = new System.Drawing.Size(132, 22);
            this.mskDen.TabIndex = 4;
            this.mskDen.ValidatingType = typeof(System.DateTime);
            this.mskDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // mskTu
            // 
            this.mskTu.Location = new System.Drawing.Point(305, 87);
            this.mskTu.Margin = new System.Windows.Forms.Padding(4);
            this.mskTu.Mask = "00/00/0000";
            this.mskTu.Name = "mskTu";
            this.mskTu.Size = new System.Drawing.Size(132, 22);
            this.mskTu.TabIndex = 3;
            this.mskTu.ValidatingType = typeof(System.DateTime);
            this.mskTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(271, 43);
            this.mskNgay.Margin = new System.Windows.Forms.Padding(4);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(132, 22);
            this.mskNgay.TabIndex = 2;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            this.mskNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // rdbKhoang
            // 
            this.rdbKhoang.AutoSize = true;
            this.rdbKhoang.Location = new System.Drawing.Point(105, 89);
            this.rdbKhoang.Margin = new System.Windows.Forms.Padding(4);
            this.rdbKhoang.Name = "rdbKhoang";
            this.rdbKhoang.Size = new System.Drawing.Size(115, 20);
            this.rdbKhoang.TabIndex = 1;
            this.rdbKhoang.TabStop = true;
            this.rdbKhoang.Text = "Theo Khoảng: ";
            this.rdbKhoang.UseVisualStyleBackColor = true;
            this.rdbKhoang.CheckedChanged += new System.EventHandler(this.rdbKhoang_CheckedChanged);
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.Location = new System.Drawing.Point(105, 44);
            this.rdbNgay.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(99, 20);
            this.rdbNgay.TabIndex = 0;
            this.rdbNgay.TabStop = true;
            this.rdbNgay.Text = "Theo Ngày:";
            this.rdbNgay.UseVisualStyleBackColor = true;
            this.rdbNgay.CheckedChanged += new System.EventHandler(this.rdbNgay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 513);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(77, 274);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1172, 222);
            this.dataGridView.TabIndex = 5;
            // 
            // btnxem
            // 
            this.btnxem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxem.Image = ((System.Drawing.Image)(resources.GetObject("btnxem.Image")));
            this.btnxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxem.Location = new System.Drawing.Point(859, 550);
            this.btnxem.Margin = new System.Windows.Forms.Padding(4);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(100, 49);
            this.btnxem.TabIndex = 6;
            this.btnxem.Text = "Hiển thị";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.Image = ((System.Drawing.Image)(resources.GetObject("btnxuatfile.Image")));
            this.btnxuatfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuatfile.Location = new System.Drawing.Point(987, 550);
            this.btnxuatfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(135, 49);
            this.btnxuatfile.TabIndex = 7;
            this.btnxuatfile.Text = "Xuất file Excel";
            this.btnxuatfile.UseVisualStyleBackColor = true;
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(1149, 550);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 49);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(200, 510);
            this.txtdoanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.ReadOnly = true;
            this.txtdoanhthu.Size = new System.Drawing.Size(243, 22);
            this.txtdoanhthu.TabIndex = 10;
            // 
            // Form_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 652);
            this.Controls.Add(this.txtdoanhthu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxuatfile);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo: Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.FormDoanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDen;
        private System.Windows.Forms.MaskedTextBox mskTu;
        private System.Windows.Forms.MaskedTextBox mskNgay;
        private System.Windows.Forms.RadioButton rdbKhoang;
        private System.Windows.Forms.RadioButton rdbNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnxuatfile;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtdoanhthu;
    }
}