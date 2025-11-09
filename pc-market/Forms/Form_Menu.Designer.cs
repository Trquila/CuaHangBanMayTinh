namespace pc_market.Forms
{
    partial class Form_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timkiemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerHoaDon = new System.Windows.Forms.Timer(this.components);
            this.hoadonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.baocaoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.linhkienContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.themContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.timerTimKiem = new System.Windows.Forms.Timer(this.components);
            this.timerBaoCao = new System.Windows.Forms.Timer(this.components);
            this.timerLinhKien = new System.Windows.Forms.Timer(this.components);
            this.timerThem = new System.Windows.Forms.Timer(this.components);
            this.danhmucContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.timerDanhMuc = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.timkiemContainer.SuspendLayout();
            this.hoadonContainer.SuspendLayout();
            this.baocaoContainer.SuspendLayout();
            this.linhkienContainer.SuspendLayout();
            this.themContainer.SuspendLayout();
            this.danhmucContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hóa đơn nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hóa đơn bán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timkiemContainer
            // 
            this.timkiemContainer.Controls.Add(this.button1);
            this.timkiemContainer.Controls.Add(this.button2);
            this.timkiemContainer.Controls.Add(this.button3);
            this.timkiemContainer.Location = new System.Drawing.Point(0, 120);
            this.timkiemContainer.Margin = new System.Windows.Forms.Padding(0);
            this.timkiemContainer.Name = "timkiemContainer";
            this.timkiemContainer.Size = new System.Drawing.Size(180, 30);
            this.timkiemContainer.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerHoaDon
            // 
            this.timerHoaDon.Interval = 10;
            this.timerHoaDon.Tick += new System.EventHandler(this.timerHoaDon_Tick_1);
            // 
            // hoadonContainer
            // 
            this.hoadonContainer.Controls.Add(this.button4);
            this.hoadonContainer.Controls.Add(this.button5);
            this.hoadonContainer.Controls.Add(this.button6);
            this.hoadonContainer.Location = new System.Drawing.Point(0, 90);
            this.hoadonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.hoadonContainer.Name = "hoadonContainer";
            this.hoadonContainer.Size = new System.Drawing.Size(180, 30);
            this.hoadonContainer.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "Hóa đơn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "Hóa đơn nhập hàng";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 60);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 30);
            this.button6.TabIndex = 2;
            this.button6.Text = "Hóa đơn bán hàng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // baocaoContainer
            // 
            this.baocaoContainer.Controls.Add(this.button7);
            this.baocaoContainer.Controls.Add(this.button8);
            this.baocaoContainer.Controls.Add(this.button9);
            this.baocaoContainer.Controls.Add(this.button10);
            this.baocaoContainer.Location = new System.Drawing.Point(0, 60);
            this.baocaoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.baocaoContainer.Name = "baocaoContainer";
            this.baocaoContainer.Size = new System.Drawing.Size(180, 30);
            this.baocaoContainer.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 30);
            this.button7.TabIndex = 0;
            this.button7.Text = "Báo cáo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 30);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "Báo cáo nhập hàng";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 60);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "Báo cáo bán hàng";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 90);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(180, 30);
            this.button10.TabIndex = 3;
            this.button10.Text = "Báo cáo doanh thu";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // linhkienContainer
            // 
            this.linhkienContainer.Controls.Add(this.button11);
            this.linhkienContainer.Controls.Add(this.button12);
            this.linhkienContainer.Controls.Add(this.button13);
            this.linhkienContainer.Controls.Add(this.button14);
            this.linhkienContainer.Controls.Add(this.button15);
            this.linhkienContainer.Controls.Add(this.button19);
            this.linhkienContainer.Location = new System.Drawing.Point(0, 30);
            this.linhkienContainer.Margin = new System.Windows.Forms.Padding(0);
            this.linhkienContainer.Name = "linhkienContainer";
            this.linhkienContainer.Size = new System.Drawing.Size(180, 30);
            this.linhkienContainer.TabIndex = 6;
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(180, 30);
            this.button11.TabIndex = 0;
            this.button11.Text = "         Linh kiện máy tính";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 30);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(180, 30);
            this.button12.TabIndex = 1;
            this.button12.Text = "Mainboard";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 60);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(180, 30);
            this.button13.TabIndex = 2;
            this.button13.Text = "CPU";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(0, 90);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(180, 30);
            this.button14.TabIndex = 3;
            this.button14.Text = "RAM";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button15.Location = new System.Drawing.Point(0, 120);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(180, 30);
            this.button15.TabIndex = 4;
            this.button15.Text = "Card đồ họa (GPU)";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(0, 150);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(180, 30);
            this.button19.TabIndex = 7;
            this.button19.Text = "Ổ cứng";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // themContainer
            // 
            this.themContainer.Controls.Add(this.button16);
            this.themContainer.Controls.Add(this.button17);
            this.themContainer.Controls.Add(this.button18);
            this.themContainer.Location = new System.Drawing.Point(0, 150);
            this.themContainer.Margin = new System.Windows.Forms.Padding(0);
            this.themContainer.Name = "themContainer";
            this.themContainer.Size = new System.Drawing.Size(180, 30);
            this.themContainer.TabIndex = 5;
            // 
            // button16
            // 
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(180, 30);
            this.button16.TabIndex = 0;
            this.button16.Text = "Thêm";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(0, 30);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(180, 30);
            this.button17.TabIndex = 1;
            this.button17.Text = "Chi tiết màn hình";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(0, 60);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(180, 30);
            this.button18.TabIndex = 2;
            this.button18.Text = "Hãng sản xuất";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // timerTimKiem
            // 
            this.timerTimKiem.Interval = 10;
            this.timerTimKiem.Tick += new System.EventHandler(this.timerTimKiem_Tick);
            // 
            // timerBaoCao
            // 
            this.timerBaoCao.Interval = 10;
            this.timerBaoCao.Tick += new System.EventHandler(this.timerBaoCao_Tick);
            // 
            // timerLinhKien
            // 
            this.timerLinhKien.Interval = 10;
            this.timerLinhKien.Tick += new System.EventHandler(this.timerLinhKien_Tick);
            // 
            // timerThem
            // 
            this.timerThem.Interval = 10;
            this.timerThem.Tick += new System.EventHandler(this.timerThem_Tick);
            // 
            // danhmucContainer
            // 
            this.danhmucContainer.Controls.Add(this.button20);
            this.danhmucContainer.Controls.Add(this.button22);
            this.danhmucContainer.Controls.Add(this.button23);
            this.danhmucContainer.Controls.Add(this.button25);
            this.danhmucContainer.Controls.Add(this.button26);
            this.danhmucContainer.Location = new System.Drawing.Point(0, 0);
            this.danhmucContainer.Margin = new System.Windows.Forms.Padding(0);
            this.danhmucContainer.Name = "danhmucContainer";
            this.danhmucContainer.Size = new System.Drawing.Size(180, 30);
            this.danhmucContainer.TabIndex = 8;
            // 
            // button20
            // 
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(180, 30);
            this.button20.TabIndex = 0;
            this.button20.Text = "Danh mục";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, 30);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(180, 30);
            this.button22.TabIndex = 2;
            this.button22.Text = "Máy tính";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(0, 60);
            this.button23.Margin = new System.Windows.Forms.Padding(0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(180, 30);
            this.button23.TabIndex = 3;
            this.button23.Text = "Nhân viên";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(0, 90);
            this.button25.Margin = new System.Windows.Forms.Padding(0);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(180, 30);
            this.button25.TabIndex = 7;
            this.button25.Text = "Khách hàng";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(0, 120);
            this.button26.Margin = new System.Windows.Forms.Padding(0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(180, 30);
            this.button26.TabIndex = 8;
            this.button26.Text = "Nhà cung cấp";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // timerDanhMuc
            // 
            this.timerDanhMuc.Interval = 10;
            this.timerDanhMuc.Tick += new System.EventHandler(this.timerDanhMuc_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 43);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cửa hàng máy tính";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1036, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "PC Market ||";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.danhmucContainer);
            this.sidebar.Controls.Add(this.linhkienContainer);
            this.sidebar.Controls.Add(this.baocaoContainer);
            this.sidebar.Controls.Add(this.hoadonContainer);
            this.sidebar.Controls.Add(this.timkiemContainer);
            this.sidebar.Controls.Add(this.themContainer);
            this.sidebar.Controls.Add(this.button21);
            this.sidebar.Controls.Add(this.button24);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 43);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(45, 560);
            this.sidebar.TabIndex = 10;
            // 
            // button21
            // 
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button21.Location = new System.Drawing.Point(0, 180);
            this.button21.Margin = new System.Windows.Forms.Padding(0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(180, 30);
            this.button21.TabIndex = 11;
            this.button21.Text = "Về chúng tôi";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button24
            // 
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24.Location = new System.Drawing.Point(0, 210);
            this.button24.Margin = new System.Windows.Forms.Padding(0);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(180, 30);
            this.button24.TabIndex = 12;
            this.button24.Text = "Thoát";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 5;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 603);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.timkiemContainer.ResumeLayout(false);
            this.hoadonContainer.ResumeLayout(false);
            this.baocaoContainer.ResumeLayout(false);
            this.linhkienContainer.ResumeLayout(false);
            this.themContainer.ResumeLayout(false);
            this.danhmucContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel timkiemContainer;
        private System.Windows.Forms.Timer timerHoaDon;
        private System.Windows.Forms.FlowLayoutPanel hoadonContainer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel baocaoContainer;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.FlowLayoutPanel linhkienContainer;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.FlowLayoutPanel themContainer;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Timer timerTimKiem;
        private System.Windows.Forms.Timer timerBaoCao;
        private System.Windows.Forms.Timer timerLinhKien;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Timer timerThem;
        private System.Windows.Forms.FlowLayoutPanel danhmucContainer;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Timer timerDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Timer timerSidebar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label2;
    }
}