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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            flowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.Controls.Add(btnTraCuu);
            flowPanel.Controls.Add(btnThem);
            flowPanel.Controls.Add(btnCapNhat);
            flowPanel.Controls.Add(btnLuu);
            flowPanel.Controls.Add(btnXoa);
            flowPanel.Controls.Add(btnThoat);
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1401, 43);
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
            btnTraCuu.Size = new Size(105, 32);
            btnTraCuu.TabIndex = 0;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SearchIcon.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 46);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 33);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Từ đầy đủ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(563, 7);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(123, 33);
            comboBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Từ viết tắt";
            // 
            // button1
            // 
            button1.Location = new Point(769, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 39);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.ImageIndex = 0;
            btnThem.Location = new Point(117, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 32);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm từ mới";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ImageAlign = ContentAlignment.MiddleRight;
            btnCapNhat.ImageIndex = 0;
            btnCapNhat.Location = new Point(285, 4);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(157, 32);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ImageAlign = ContentAlignment.MiddleRight;
            btnLuu.ImageIndex = 0;
            btnLuu.Location = new Point(450, 4);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(157, 32);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.ImageIndex = 0;
            btnXoa.Location = new Point(615, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(157, 32);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.ImageIndex = 0;
            btnThoat.Location = new Point(780, 4);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 32);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 740);
            Controls.Add(panel1);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Từ điển chuyên ngành";
            flowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Button btnTraCuu;
        private ImageList imageList1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
    }
}
