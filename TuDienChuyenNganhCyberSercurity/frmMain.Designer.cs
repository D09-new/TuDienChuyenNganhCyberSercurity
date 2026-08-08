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
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.Controls.Add(btnTraCuu);
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(4, 4, 4, 4);
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
            btnTraCuu.Margin = new Padding(4, 4, 4, 4);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 740);
            Controls.Add(flowPanel);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMain";
            Text = "Từ điển chuyên ngành";
            flowPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Button btnTraCuu;
        private ImageList imageList1;
    }
}
