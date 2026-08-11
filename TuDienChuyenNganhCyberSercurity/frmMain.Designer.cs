namespace TuDienChuyenNganhCyberSecurity
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            flowPanel = new FlowLayoutPanel();
            btnTraCuu = new Button();
            imageList1 = new ImageList(components);
            btnThem = new Button();
            btnCapNhat = new Button();
            btnLuu = new Button();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnPhucHoi = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            cmbLinhVuc1 = new ComboBox();
            lbLinhVuc = new Label();
            txtTuDayDu = new TextBox();
            txtTuVietTat = new TextBox();
            lbTuVietTat = new Label();
            lbTuDayDu = new Label();
            cmbTuVietTat = new ComboBox();
            cmbTuDayDu = new ComboBox();
            label5 = new Label();
            cmbLinhVuc = new ComboBox();
            splitContainer1 = new SplitContainer();
            dgvDSTU = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TUVIETTAT = new DataGridViewTextBoxColumn();
            TUDAYDU = new DataGridViewTextBoxColumn();
            NOIDUNG = new DataGridViewTextBoxColumn();
            GHICHU = new DataGridViewTextBoxColumn();
            LINHVUC = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label3 = new Label();
            panelLoc = new Panel();
            btnLoc = new Button();
            panel5 = new Panel();
            txtGhiChu = new RichTextBox();
            panel4 = new Panel();
            label6 = new Label();
            txtNoiDung = new RichTextBox();
            panel3 = new Panel();
            label4 = new Label();
            flowPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTU).BeginInit();
            panel2.SuspendLayout();
            panelLoc.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoSize = true;
            flowPanel.BackColor = SystemColors.ActiveCaption;
            flowPanel.BorderStyle = BorderStyle.Fixed3D;
            flowPanel.Controls.Add(btnTraCuu);
            flowPanel.Controls.Add(btnThem);
            flowPanel.Controls.Add(btnCapNhat);
            flowPanel.Controls.Add(btnLuu);
            flowPanel.Controls.Add(btnTaiLai);
            flowPanel.Controls.Add(btnXoa);
            flowPanel.Controls.Add(btnPhucHoi);
            flowPanel.Controls.Add(btnThoat);
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1523, 47);
            flowPanel.TabIndex = 100;
            // 
            // btnTraCuu
            // 
            btnTraCuu.AutoSize = true;
            btnTraCuu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTraCuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ImageAlign = ContentAlignment.MiddleRight;
            btnTraCuu.ImageIndex = 0;
            btnTraCuu.ImageList = imageList1;
            btnTraCuu.Location = new Point(4, 4);
            btnTraCuu.Margin = new Padding(4);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(102, 35);
            btnTraCuu.TabIndex = 20;
            btnTraCuu.TabStop = false;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SearchIcon.png");
            imageList1.Images.SetKeyName(1, "Add.png");
            imageList1.Images.SetKeyName(2, "Edit.png");
            imageList1.Images.SetKeyName(3, "Save.png");
            imageList1.Images.SetKeyName(4, "Delete.png");
            imageList1.Images.SetKeyName(5, "Exit.png");
            imageList1.Images.SetKeyName(6, "Reload.png");
            imageList1.Images.SetKeyName(7, "Rollback.png");
            imageList1.Images.SetKeyName(8, "Filter1.png");
            imageList1.Images.SetKeyName(9, "filter.png");
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.ImageIndex = 1;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(114, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(149, 32);
            btnThem.TabIndex = 21;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm từ mới";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ImageAlign = ContentAlignment.MiddleRight;
            btnCapNhat.ImageIndex = 2;
            btnCapNhat.ImageList = imageList1;
            btnCapNhat.Location = new Point(271, 4);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 32);
            btnCapNhat.TabIndex = 22;
            btnCapNhat.TabStop = false;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ImageAlign = ContentAlignment.MiddleRight;
            btnLuu.ImageIndex = 3;
            btnLuu.ImageList = imageList1;
            btnLuu.Location = new Point(399, 4);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(84, 32);
            btnLuu.TabIndex = 23;
            btnLuu.TabStop = false;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.ImageAlign = ContentAlignment.MiddleRight;
            btnTaiLai.ImageIndex = 6;
            btnTaiLai.ImageList = imageList1;
            btnTaiLai.Location = new Point(491, 4);
            btnTaiLai.Margin = new Padding(4);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(97, 32);
            btnTaiLai.TabIndex = 24;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.ImageIndex = 4;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(596, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 32);
            btnXoa.TabIndex = 25;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnPhucHoi
            // 
            btnPhucHoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhucHoi.ImageAlign = ContentAlignment.MiddleRight;
            btnPhucHoi.ImageIndex = 7;
            btnPhucHoi.ImageList = imageList1;
            btnPhucHoi.Location = new Point(685, 4);
            btnPhucHoi.Margin = new Padding(4);
            btnPhucHoi.Name = "btnPhucHoi";
            btnPhucHoi.Size = new Size(113, 32);
            btnPhucHoi.TabIndex = 26;
            btnPhucHoi.TabStop = false;
            btnPhucHoi.Text = "Phục hồi";
            btnPhucHoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhucHoi.UseVisualStyleBackColor = true;
            btnPhucHoi.Click += btnPhucHoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.ImageIndex = 5;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(806, 4);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 32);
            btnThoat.TabIndex = 27;
            btnThoat.TabStop = false;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cmbLinhVuc1);
            panel1.Controls.Add(lbLinhVuc);
            panel1.Controls.Add(txtTuDayDu);
            panel1.Controls.Add(txtTuVietTat);
            panel1.Controls.Add(lbTuVietTat);
            panel1.Controls.Add(lbTuDayDu);
            panel1.Controls.Add(cmbTuVietTat);
            panel1.Controls.Add(cmbTuDayDu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 43);
            panel1.TabIndex = 100;
            // 
            // cmbLinhVuc1
            // 
            cmbLinhVuc1.BackColor = Color.PaleTurquoise;
            cmbLinhVuc1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLinhVuc1.FormattingEnabled = true;
            cmbLinhVuc1.Location = new Point(1249, 3);
            cmbLinhVuc1.Name = "cmbLinhVuc1";
            cmbLinhVuc1.Size = new Size(247, 28);
            cmbLinhVuc1.TabIndex = 3;
            cmbLinhVuc1.Visible = false;
            // 
            // lbLinhVuc
            // 
            lbLinhVuc.AutoSize = true;
            lbLinhVuc.Location = new Point(1159, 6);
            lbLinhVuc.Name = "lbLinhVuc";
            lbLinhVuc.Size = new Size(84, 25);
            lbLinhVuc.TabIndex = 101;
            lbLinhVuc.Text = "Lĩnh vực";
            lbLinhVuc.Visible = false;
            // 
            // txtTuDayDu
            // 
            txtTuDayDu.BackColor = Color.PaleTurquoise;
            txtTuDayDu.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuDayDu.ForeColor = Color.Black;
            txtTuDayDu.Location = new Point(547, 4);
            txtTuDayDu.Name = "txtTuDayDu";
            txtTuDayDu.Size = new Size(579, 29);
            txtTuDayDu.TabIndex = 2;
            txtTuDayDu.Visible = false;
            // 
            // txtTuVietTat
            // 
            txtTuVietTat.BackColor = Color.PaleTurquoise;
            txtTuVietTat.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuVietTat.ForeColor = Color.Black;
            txtTuVietTat.Location = new Point(110, 4);
            txtTuVietTat.Name = "txtTuVietTat";
            txtTuVietTat.Size = new Size(304, 29);
            txtTuVietTat.TabIndex = 1;
            txtTuVietTat.Visible = false;
            // 
            // lbTuVietTat
            // 
            lbTuVietTat.AutoSize = true;
            lbTuVietTat.Location = new Point(6, 6);
            lbTuVietTat.Name = "lbTuVietTat";
            lbTuVietTat.Size = new Size(101, 25);
            lbTuVietTat.TabIndex = 100;
            lbTuVietTat.Text = "Từ viết tắt";
            // 
            // lbTuDayDu
            // 
            lbTuDayDu.AutoSize = true;
            lbTuDayDu.Location = new Point(443, 6);
            lbTuDayDu.Name = "lbTuDayDu";
            lbTuDayDu.Size = new Size(98, 25);
            lbTuDayDu.TabIndex = 100;
            lbTuDayDu.Text = "Từ đầy đủ";
            // 
            // cmbTuVietTat
            // 
            cmbTuVietTat.FormattingEnabled = true;
            cmbTuVietTat.Location = new Point(110, 3);
            cmbTuVietTat.Name = "cmbTuVietTat";
            cmbTuVietTat.Size = new Size(304, 33);
            cmbTuVietTat.TabIndex = 1;
            cmbTuVietTat.SelectionChangeCommitted += cmbTuVietTat_SelectionChangeCommitted;
            cmbTuVietTat.Leave += cmbTuVietTat_Leave;
            // 
            // cmbTuDayDu
            // 
            cmbTuDayDu.FormattingEnabled = true;
            cmbTuDayDu.Location = new Point(547, 3);
            cmbTuDayDu.Name = "cmbTuDayDu";
            cmbTuDayDu.Size = new Size(579, 33);
            cmbTuDayDu.TabIndex = 2;
            cmbTuDayDu.SelectionChangeCommitted += cmbTuDayDu_SelectionChangeCommitted;
            cmbTuDayDu.Leave += cmbTuDayDu_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 102;
            label5.Text = "Lĩnh vực";
            // 
            // cmbLinhVuc
            // 
            cmbLinhVuc.FormattingEnabled = true;
            cmbLinhVuc.Location = new Point(96, 3);
            cmbLinhVuc.Name = "cmbLinhVuc";
            cmbLinhVuc.Size = new Size(277, 33);
            cmbLinhVuc.TabIndex = 20;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 90);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDSTU);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panelLoc);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(txtNoiDung);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1523, 650);
            splitContainer1.SplitterDistance = 612;
            splitContainer1.TabIndex = 100;
            splitContainer1.TabStop = false;
            // 
            // dgvDSTU
            // 
            dgvDSTU.AllowUserToAddRows = false;
            dgvDSTU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTU.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDSTU.BorderStyle = BorderStyle.Fixed3D;
            dgvDSTU.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSTU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSTU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTU.Columns.AddRange(new DataGridViewColumn[] { ID, TUVIETTAT, TUDAYDU, NOIDUNG, GHICHU, LINHVUC });
            dgvDSTU.Dock = DockStyle.Fill;
            dgvDSTU.EnableHeadersVisualStyles = false;
            dgvDSTU.Location = new Point(0, 84);
            dgvDSTU.Name = "dgvDSTU";
            dgvDSTU.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDSTU.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDSTU.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvDSTU.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDSTU.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSTU.Size = new Size(612, 566);
            dgvDSTU.TabIndex = 101;
            dgvDSTU.SelectionChanged += dgvDSTU_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 96.25668F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // TUVIETTAT
            // 
            TUVIETTAT.DataPropertyName = "TUVIETTAT";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            TUVIETTAT.DefaultCellStyle = dataGridViewCellStyle2;
            TUVIETTAT.FillWeight = 50F;
            TUVIETTAT.HeaderText = "Từ viết tắt";
            TUVIETTAT.MinimumWidth = 6;
            TUVIETTAT.Name = "TUVIETTAT";
            TUVIETTAT.ReadOnly = true;
            // 
            // TUDAYDU
            // 
            TUDAYDU.DataPropertyName = "TUDAYDU";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            TUDAYDU.DefaultCellStyle = dataGridViewCellStyle3;
            TUDAYDU.FillWeight = 125F;
            TUDAYDU.HeaderText = "Từ đầy đủ";
            TUDAYDU.MinimumWidth = 6;
            TUDAYDU.Name = "TUDAYDU";
            TUDAYDU.ReadOnly = true;
            // 
            // NOIDUNG
            // 
            NOIDUNG.DataPropertyName = "NOIDUNG";
            NOIDUNG.HeaderText = "Nội dung";
            NOIDUNG.MinimumWidth = 6;
            NOIDUNG.Name = "NOIDUNG";
            NOIDUNG.ReadOnly = true;
            NOIDUNG.Visible = false;
            // 
            // GHICHU
            // 
            GHICHU.DataPropertyName = "GHICHU";
            GHICHU.HeaderText = "Ghi chú";
            GHICHU.MinimumWidth = 6;
            GHICHU.Name = "GHICHU";
            GHICHU.ReadOnly = true;
            GHICHU.Visible = false;
            // 
            // LINHVUC
            // 
            LINHVUC.DataPropertyName = "LINHVUC";
            LINHVUC.DefaultCellStyle = dataGridViewCellStyle3;
            LINHVUC.FillWeight = 60F;
            LINHVUC.HeaderText = "Lĩnh vực";
            LINHVUC.MinimumWidth = 6;
            LINHVUC.Name = "LINHVUC";
            LINHVUC.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 40);
            panel2.TabIndex = 100;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(226, 7);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 0;
            label3.Text = "DANH SÁCH TỪ";
            // 
            // panelLoc
            // 
            panelLoc.BackColor = SystemColors.Highlight;
            panelLoc.BorderStyle = BorderStyle.Fixed3D;
            panelLoc.Controls.Add(cmbLinhVuc);
            panelLoc.Controls.Add(label5);
            panelLoc.Controls.Add(btnLoc);
            panelLoc.Dock = DockStyle.Top;
            panelLoc.Location = new Point(0, 0);
            panelLoc.Name = "panelLoc";
            panelLoc.Size = new Size(612, 44);
            panelLoc.TabIndex = 102;
            // 
            // btnLoc
            // 
            btnLoc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.ImageAlign = ContentAlignment.MiddleRight;
            btnLoc.ImageIndex = 9;
            btnLoc.ImageList = imageList1;
            btnLoc.Location = new Point(391, 3);
            btnLoc.Margin = new Padding(4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(84, 32);
            btnLoc.TabIndex = 28;
            btnLoc.TabStop = false;
            btnLoc.Text = "Lọc";
            btnLoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtGhiChu);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 413);
            panel5.Name = "panel5";
            panel5.Size = new Size(907, 237);
            panel5.TabIndex = 102;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = SystemColors.GradientInactiveCaption;
            txtGhiChu.Dock = DockStyle.Fill;
            txtGhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(0, 0);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(907, 237);
            txtGhiChu.TabIndex = 5;
            txtGhiChu.Text = "";
            txtGhiChu.KeyDown += txtGhiChu_KeyDown;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 369);
            panel4.Name = "panel4";
            panel4.Size = new Size(907, 44);
            panel4.TabIndex = 101;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(407, 7);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 1;
            label6.Text = "GHI CHÚ";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = SystemColors.GradientInactiveCaption;
            txtNoiDung.Dock = DockStyle.Top;
            txtNoiDung.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDung.Location = new Point(0, 40);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(907, 329);
            txtNoiDung.TabIndex = 4;
            txtNoiDung.Text = "";
            txtNoiDung.KeyDown += txtNoiDung_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(907, 40);
            panel3.TabIndex = 100;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(407, 5);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 0;
            label4.Text = "NỘI DUNG";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 740);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Từ điển chuyên ngành Cyber Security";
            Load += frmMain_Load;
            flowPanel.ResumeLayout(false);
            flowPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSTU).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelLoc.ResumeLayout(false);
            panelLoc.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private ImageList imageList1;
        private Panel panel1;
        private Label lbTuVietTat;
        private Label lbTuDayDu;
        private ComboBox cmbTuVietTat;
        private ComboBox cmbTuDayDu;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTraCuu;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private RichTextBox txtNoiDung;
        private RichTextBox txtGhiChu;
        private Button btnTaiLai;
        private Button btnPhucHoi;
        private Label label5;
        private ComboBox cmbLinhVuc;
        private Panel panel4;
        private Label label6;
        private DataGridView dgvDSTU;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TUVIETTAT;
        private DataGridViewTextBoxColumn TUDAYDU;
        private DataGridViewTextBoxColumn NOIDUNG;
        private DataGridViewTextBoxColumn GHICHU;
        private DataGridViewTextBoxColumn LINHVUC;
        private Panel panel5;
        private Panel panelLoc;
        private Button btnLoc;
        private TextBox txtTuDayDu;
        private TextBox txtTuVietTat;
        private Label lbLinhVuc;
        private ComboBox cmbLinhVuc1;
    }
}
