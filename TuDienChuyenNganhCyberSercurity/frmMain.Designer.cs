namespace TuDienChuyenNganhCyberSercurity
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
            flowPanel = new FlowLayoutPanel();
            btnTraCuu = new Button();
            imageList1 = new ImageList(components);
            btnThem = new Button();
            btnCapNhat = new Button();
            btnLuu = new Button();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cmbTuVietTat = new ComboBox();
            cmbTuDayDu = new ComboBox();
            splitContainer1 = new SplitContainer();
            txtNoiDung = new RichTextBox();
            panel2 = new Panel();
            label3 = new Label();
            txtGhiChu = new RichTextBox();
            panel3 = new Panel();
            label4 = new Label();
            flowPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
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
            flowPanel.Controls.Add(btnThoat);
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1401, 44);
            flowPanel.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ImageAlign = ContentAlignment.MiddleRight;
            btnTraCuu.ImageIndex = 0;
            btnTraCuu.ImageList = imageList1;
            btnTraCuu.Location = new Point(4, 4);
            btnTraCuu.Margin = new Padding(4);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(109, 32);
            btnTraCuu.TabIndex = 1;
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
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.ImageIndex = 1;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(121, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(149, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm từ mới";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ImageAlign = ContentAlignment.MiddleRight;
            btnCapNhat.ImageIndex = 2;
            btnCapNhat.ImageList = imageList1;
            btnCapNhat.Location = new Point(278, 4);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 32);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ImageAlign = ContentAlignment.MiddleRight;
            btnLuu.ImageIndex = 3;
            btnLuu.ImageList = imageList1;
            btnLuu.Location = new Point(406, 4);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(84, 32);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.ImageAlign = ContentAlignment.MiddleRight;
            btnTaiLai.ImageIndex = 6;
            btnTaiLai.ImageList = imageList1;
            btnTaiLai.Location = new Point(498, 4);
            btnTaiLai.Margin = new Padding(4);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(97, 32);
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.ImageIndex = 4;
            btnXoa.ImageList = imageList1;
            btnXoa.Location = new Point(603, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 32);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.ImageIndex = 5;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(692, 4);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 32);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbTuVietTat);
            panel1.Controls.Add(cmbTuDayDu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 42);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 10);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Từ viết tắt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 10);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Từ đầy đủ";
            // 
            // cmbTuVietTat
            // 
            cmbTuVietTat.FormattingEnabled = true;
            cmbTuVietTat.Location = new Point(563, 6);
            cmbTuVietTat.Name = "cmbTuVietTat";
            cmbTuVietTat.Size = new Size(123, 33);
            cmbTuVietTat.TabIndex = 0;
            // 
            // cmbTuDayDu
            // 
            cmbTuDayDu.FormattingEnabled = true;
            cmbTuDayDu.Location = new Point(108, 6);
            cmbTuDayDu.Name = "cmbTuDayDu";
            cmbTuDayDu.Size = new Size(320, 33);
            cmbTuDayDu.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 86);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtNoiDung);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtGhiChu);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1401, 654);
            splitContainer1.SplitterDistance = 861;
            splitContainer1.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Dock = DockStyle.Fill;
            txtNoiDung.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiDung.Location = new Point(0, 40);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(861, 614);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 40);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(376, 7);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 0;
            label3.Text = "NỘI DUNG";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Dock = DockStyle.Fill;
            txtGhiChu.Location = new Point(0, 40);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(536, 614);
            txtGhiChu.TabIndex = 1;
            txtGhiChu.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 40);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(224, 7);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 0;
            label4.Text = "GHI CHÚ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 740);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Từ điển chuyên ngành";
            Load += frmMain_Load;
            flowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private ImageList imageList1;
        private Panel panel1;
        private Label label2;
        private Label label1;
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
    }
}
