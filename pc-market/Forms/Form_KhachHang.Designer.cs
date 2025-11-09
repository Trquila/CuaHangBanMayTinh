namespace pc_market.Forms
{
    partial class Form_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KhachHang));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(71, 220);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(1205, 292);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách:";
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(168, 126);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(479, 22);
            this.txtMakhach.TabIndex = 2;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(168, 170);
            this.txtTenkhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(479, 22);
            this.txtTenkhach.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(796, 126);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(479, 22);
            this.txtDiachi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1317, 111);
            this.label5.TabIndex = 9;
            this.label5.Text = "DANH MỤC KHÁCH HÀNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(796, 170);
            this.mskDienthoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(479, 22);
            this.mskDienthoai.TabIndex = 16;
            this.mskDienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_KeyPress);
            // 
            // btndong
            // 
            this.btndong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndong.BackgroundImage")));
            this.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndong.Location = new System.Drawing.Point(1143, 540);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(133, 48);
            this.btndong.TabIndex = 15;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnboqua.BackgroundImage = global::pc_market.Properties.Resources.skip;
            this.btnboqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnboqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnboqua.Location = new System.Drawing.Point(932, 540);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(133, 48);
            this.btnboqua.TabIndex = 14;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImage = global::pc_market.Properties.Resources.save;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Location = new System.Drawing.Point(713, 540);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(133, 48);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::pc_market.Properties.Resources.delete;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.Location = new System.Drawing.Point(293, 540);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(133, 48);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::pc_market.Properties.Resources.edit;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.Location = new System.Drawing.Point(503, 540);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(133, 48);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.BackgroundImage = global::pc_market.Properties.Resources.add;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Location = new System.Drawing.Point(71, 540);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(133, 48);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1349, 641);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_KhachHang";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục: Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
    }
}