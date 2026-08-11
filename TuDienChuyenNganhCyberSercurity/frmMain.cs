using Microsoft.Data.SqlClient;
using System.Data;
namespace TuDienChuyenNganhCyberSecurity
{
    public partial class frmMain : Form
    {
        public static BindingSource bds_dstu = new BindingSource();
        public static BindingSource bds_dslinhvuc = new BindingSource();
        public static BindingSource bds_dslinhvuc1 = new BindingSource();
        int position = -1;
        bool isAdd = false;
        bool isUpdate = false;
        bool isLoading = false;
        bool isSearching = false;
        string linhvuc = "Tất cả";
        string tuviettat = "";
        string tudaydu = "";
        public frmMain()
        {
            InitializeComponent();
            cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTuDayDu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTuVietTat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLinhVuc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLinhVuc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLinhVuc1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLinhVuc1.AutoCompleteSource = AutoCompleteSource.ListItems;
            lbTuDayDu.Visible = cmbTuDayDu.Visible = lbTuVietTat.Visible = cmbTuVietTat.Visible = false;
            txtNoiDung.ReadOnly = txtGhiChu.ReadOnly = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;
                Program.KetNoi();
                using (SqlCommand cmd = new SqlCommand("SP_XEM", Program.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    bds_dstu.DataSource = dt;
                    cmbTuDayDu.DataSource = bds_dstu;
                    cmbTuDayDu.DisplayMember = "TuDayDu";
                    cmbTuDayDu.ValueMember = "ID";
                    cmbTuDayDu.SelectedIndex = 0;
                    cmbTuVietTat.DataSource = bds_dstu;
                    cmbTuVietTat.DisplayMember = "TuVietTat";
                    cmbTuVietTat.ValueMember = "ID";
                    cmbTuVietTat.SelectedIndex = 0;
                    dgvDSTU.DataSource = bds_dstu;
                    isLoading = false;
                }
                using (SqlCommand cmd1 = new SqlCommand("SP_XEMLINHVUC", Program.conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    da.Fill(dt1);
                    bds_dslinhvuc1.DataSource = dt1;
                    cmbLinhVuc1.DataSource = bds_dslinhvuc1;
                    cmbLinhVuc1.DisplayMember = "LINHVUC";
                    cmbLinhVuc1.ValueMember = "LINHVUC";
                    cmbLinhVuc1.SelectedIndex = 0;
                    DataRow dr = dt.NewRow();
                    dr["LINHVUC"] = "Tất cả";
                    dt.Rows.InsertAt(dr, 0);
                    bds_dslinhvuc.DataSource = dt;
                    cmbLinhVuc.DataSource = bds_dslinhvuc;
                    cmbLinhVuc.DisplayMember = "LINHVUC";
                    cmbLinhVuc.ValueMember = "LINHVUC";
                    cmbLinhVuc.SelectedIndex = 0;
                }
                if (bds_dstu.Count > 0)
                {
                    DataRowView row = bds_dstu[0] as DataRowView;
                    GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                    GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
                    cmbLinhVuc1.SelectedValue = row["LinhVuc"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd)
                {
                    MessageBox.Show("Đang ở chế độ thêm. Vui lòng hoàn tất hoặc hủy bỏ trước khi tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isSearching)
                {
                    position = cmbTuDayDu.SelectedIndex;
                    btnTraCuu.Text = "Tra cứu";
                    lbTuDayDu.Visible = cmbTuDayDu.Visible = lbTuVietTat.Visible = cmbTuVietTat.Visible = false;
                    btnThem.Enabled = btnLuu.Enabled = btnXoa.Enabled = dgvDSTU.Enabled = true;
                    isSearching = false;
                }
                else
                {
                    position = cmbTuDayDu.SelectedIndex;
                    isSearching = true;
                    btnTraCuu.Text = "Kết thúc tra cứu";
                    lbTuDayDu.Visible = cmbTuDayDu.Visible = lbTuVietTat.Visible = cmbTuVietTat.Visible = true;
                    btnThem.Enabled = btnLuu.Enabled = btnXoa.Enabled = dgvDSTU.Enabled = false;
                }

            }
            catch (Exception)
            {

            }
        }

        private void GanNoiDungRichTextBox(
           RichTextBox richTextBox,
           object giaTri)
        {
            if (giaTri == null ||
                giaTri == DBNull.Value ||
                string.IsNullOrWhiteSpace(giaTri.ToString()))
            {
                richTextBox.Clear();
                return;
            }

            string noiDung = giaTri.ToString();

            try
            {
                /*
                 * Nếu dữ liệu là chuỗi RTF hợp lệ,
                 * giữ nguyên định dạng.
                 */
                richTextBox.Rtf = noiDung;
            }
            catch (ArgumentException)
            {
                /*
                 * Nếu dữ liệu chỉ là văn bản thường,
                 * hiển thị bằng thuộc tính Text.
                 */
                richTextBox.Text = noiDung;
            }
        }

        //private void TraCuu()
        //{
        //    try
        //    {
        //        if (!Program.ComboBoxCoGiaTri(cmbTuDayDu, "TuDayDu", cmbTuDayDu.Text) || !Program.ComboBoxCoGiaTri(cmbTuVietTat, "TuVietTat", cmbTuVietTat.Text))
        //        {
        //            MessageBox.Show("Từ bạn nhập không tồn tại trong từ điển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtNoiDung.Clear();
        //            txtGhiChu.Clear();
        //            return;
        //        }
        //        if (cmbTuDayDu.SelectedIndex == -1 || cmbTuVietTat.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Vui lòng chọn từ cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtNoiDung.Clear();
        //            txtGhiChu.Clear();
        //            return;
        //        }
        //        txtGhiChu.ReadOnly = true;
        //        txtNoiDung.ReadOnly = true;
        //        DataRowView row = bds_dstu[cmbTuDayDu.SelectedIndex] as DataRowView;
        //        GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
        //        GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void cmbTuDayDu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbTuVietTat.SelectedIndex = cmbTuDayDu.SelectedIndex;
        }

        private void cmbTuVietTat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbTuDayDu.SelectedIndex = cmbTuVietTat.SelectedIndex;
        }

        private void cmbTuDayDu_Leave(object sender, EventArgs e)
        {
            int index = cmbTuDayDu.FindStringExact(cmbTuDayDu.Text.Trim());
            if (index != -1)
            {
                cmbTuDayDu.SelectedIndex = index;
                cmbTuVietTat.SelectedIndex = index;
            }
            else
            {
                cmbTuDayDu.SelectedIndex = -1;
                cmbTuVietTat.SelectedIndex = -1;
            }
        }

        private void cmbTuVietTat_Leave(object sender, EventArgs e)
        {
            int index = cmbTuVietTat.FindStringExact(cmbTuVietTat.Text.Trim());
            if (index != -1)
            {
                cmbTuDayDu.SelectedIndex = index;
                cmbTuVietTat.SelectedIndex = index;
            }
            else
            {
                cmbTuDayDu.SelectedIndex = -1;
                cmbTuVietTat.SelectedIndex = -1;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        private void Reload()
        {
            try
            {
                Program.KetNoi();
                using (SqlCommand cmd = new SqlCommand("SP_XEM", Program.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    bds_dstu.DataSource = dt;
                    cmbTuDayDu.DataSource = bds_dstu;
                    cmbTuDayDu.DisplayMember = "TuDayDu";
                    cmbTuDayDu.ValueMember = "ID";
                    cmbTuDayDu.SelectedIndex = position;
                    cmbTuVietTat.DataSource = bds_dstu;
                    cmbTuVietTat.DisplayMember = "TuVietTat";
                    cmbTuVietTat.ValueMember = "ID";
                    cmbTuVietTat.SelectedIndex = position;
                    if (position != -1)
                    {
                        DataRowView row = bds_dstu[position] as DataRowView;
                        GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                        GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
                    }

                }
                using (SqlCommand cmd1 = new SqlCommand("SP_XEMLINHVUC", Program.conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt1);
                    da.Fill(dt2);
                    bds_dslinhvuc1.DataSource = dt2;
                    cmbLinhVuc1.DataSource = bds_dslinhvuc1;
                    cmbLinhVuc1.DisplayMember = "LINHVUC";
                    cmbLinhVuc1.ValueMember = "LINHVUC";
                    if (position != -1)
                    {
                        DataRowView row = bds_dstu[position] as DataRowView;
                        cmbLinhVuc1.SelectedValue = row["LinhVuc"];
                    }
                    else
                    {
                        cmbLinhVuc1.SelectedValue = -1;
                    }
                    DataRow dr = dt1.NewRow();
                    dr["LINHVUC"] = "Tất cả";
                    dt1.Rows.InsertAt(dr, 0);
                    bds_dslinhvuc.DataSource = dt1;
                    cmbLinhVuc.DataSource = bds_dslinhvuc;
                    cmbLinhVuc.DisplayMember = "LINHVUC";
                    cmbLinhVuc.ValueMember = "LINHVUC";
                    cmbLinhVuc.SelectedValue = linhvuc;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception)
            {

            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            txtGhiChu.ReadOnly = true;
            txtNoiDung.ReadOnly = true;
            panelLoc.Visible = true;
            txtNoiDung.BackColor = txtGhiChu.BackColor = SystemColors.GradientInactiveCaption;
            lbLinhVuc.Visible = cmbLinhVuc1.Visible = lbTuDayDu.Visible = txtTuDayDu.Visible = lbTuVietTat.Visible = txtTuVietTat.Visible = false;
            if (position != -1)
            {
                cmbTuDayDu.SelectedIndex = position;
                cmbTuVietTat.SelectedIndex = position;
                DataRowView row = bds_dstu[cmbTuDayDu.SelectedIndex] as DataRowView;
                GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
            }
            else
            {
                cmbTuDayDu.SelectedIndex = position;
                cmbTuVietTat.SelectedIndex = position;
                txtNoiDung.Clear();
                txtGhiChu.Clear();
            }
            dgvDSTU.Enabled = btnTraCuu.Enabled = btnThem.Enabled = btnCapNhat.Enabled = btnLuu.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
            if (isSearching)
            {
                lbTuDayDu.Visible = cmbTuDayDu.Visible = lbTuVietTat.Visible = cmbTuVietTat.Visible = false;
                btnTraCuu.Text = "Tra cứu";
            }
            isAdd = false;
            isUpdate = false;
            isSearching = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                MessageBox.Show("Đang ở chế độ cập nhật. Vui lòng hoàn tất hoặc hủy bỏ trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isAdd)
            {
                position = cmbTuDayDu.SelectedIndex;
                txtNoiDung.Clear();
                txtGhiChu.Clear();
                cmbTuVietTat.Focus();
                cmbLinhVuc1.SelectedIndex = -1;
                txtTuDayDu.Clear();
                txtTuVietTat.Clear();
            }
            isAdd = true;
            panelLoc.Visible = dgvDSTU.Enabled = btnTraCuu.Enabled = btnCapNhat.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            txtGhiChu.ReadOnly = false;
            txtNoiDung.ReadOnly = false;
            lbLinhVuc.Visible = cmbLinhVuc1.Visible = lbTuDayDu.Visible = txtTuDayDu.Visible = lbTuVietTat.Visible = txtTuVietTat.Visible = true;
            txtNoiDung.BackColor = txtGhiChu.BackColor = Color.PaleTurquoise;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                MessageBox.Show("Đang ở chế độ thêm. Vui lòng hoàn tất hoặc hủy bỏ trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTuVietTat.SelectedIndex == -1 || cmbTuDayDu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn từ cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isSearching)
            {
                btnLuu.Enabled = true;
                cmbTuDayDu.Visible = cmbTuVietTat.Visible = false;
            }
            DataRowView row = bds_dstu[bds_dstu.Position] as DataRowView;
            tudaydu = txtTuDayDu.Text = row["TUDAYDU"].ToString().Trim();
            tuviettat = txtTuVietTat.Text = row["TUVIETTAT"].ToString().Trim();
            cmbLinhVuc1.SelectedValue = row["LINHVUC"];
            isUpdate = true;
            panelLoc.Visible = dgvDSTU.Enabled = btnTraCuu.Enabled = btnThem.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            txtGhiChu.ReadOnly = false;
            txtNoiDung.ReadOnly = false;
            lbLinhVuc.Visible = cmbLinhVuc1.Visible = lbTuDayDu.Visible = txtTuDayDu.Visible = lbTuVietTat.Visible = txtTuVietTat.Visible = true;
            txtNoiDung.BackColor = txtGhiChu.BackColor = Color.PaleTurquoise;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(cmbTuDayDu.Text) || string.IsNullOrWhiteSpace(cmbTuVietTat.Text))
                    {
                        MessageBox.Show("Ô từ đầy đủ và từ viết tắt không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(cmbLinhVuc1.Text))
                    {
                        MessageBox.Show("Ô lĩnh vực không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_THEM", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuDayDu", txtTuDayDu.Text.Trim());
                        cmd.Parameters.AddWithValue("@TuVietTat", txtTuVietTat.Text.Trim());
                        if (Program.KiemTraCoDinhDang(txtNoiDung))
                        {
                            cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Rtf);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text.Trim());
                        }
                        if (Program.KiemTraCoDinhDang(txtGhiChu))
                        {
                            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Rtf);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                        }
                        cmd.Parameters.AddWithValue("@LinhVuc", cmbLinhVuc1.Text.Trim());
                        Program.KetNoi();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm từ mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    Reload();
                    txtGhiChu.ReadOnly = true;
                    txtNoiDung.ReadOnly = true;
                    panelLoc.Visible = dgvDSTU.Enabled = btnTraCuu.Enabled = btnCapNhat.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                    txtNoiDung.BackColor = txtGhiChu.BackColor = SystemColors.GradientInactiveCaption;
                    lbLinhVuc.Visible = cmbLinhVuc1.Visible = lbTuDayDu.Visible = txtTuDayDu.Visible = lbTuVietTat.Visible = txtTuVietTat.Visible = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isUpdate)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtTuDayDu.Text) || string.IsNullOrWhiteSpace(txtTuVietTat.Text))
                    {
                        MessageBox.Show("Ô từ đầy đủ và từ viết tắt không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(cmbLinhVuc1.Text))
                    {
                        MessageBox.Show("Ô lĩnh vực không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (tuviettat != txtTuVietTat.Text.Trim() || tudaydu != txtTuDayDu.Text.Trim())
                    {
                        using (SqlCommand check = new SqlCommand("SP_KTHIEUCHINH", Program.conn))
                        {
                            check.CommandType = CommandType.StoredProcedure;
                            check.Parameters.AddWithValue("@TuDayDu", txtTuDayDu.Text.Trim());
                            check.Parameters.AddWithValue("@TuVietTat", txtTuVietTat.Text.Trim());
                            Program.KetNoi();
                            check.ExecuteNonQuery();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HIEUCHINH", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataRowView row = bds_dstu[bds_dstu.Position] as DataRowView;
                        cmd.Parameters.AddWithValue("@ID", row["ID"]);
                        cmd.Parameters.AddWithValue("@TuDayDu", txtTuDayDu.Text.Trim());
                        cmd.Parameters.AddWithValue("@TuVietTat", txtTuVietTat.Text.Trim());
                        if (Program.KiemTraCoDinhDang(txtNoiDung))
                        {
                            cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Rtf);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text.Trim());
                        }
                        if (Program.KiemTraCoDinhDang(txtGhiChu))
                        {
                            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Rtf);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                        }
                        cmd.Parameters.AddWithValue("@LinhVuc", cmbLinhVuc1.Text.Trim());
                        Program.KetNoi();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật từ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = false;
                        Reload();
                        txtGhiChu.ReadOnly = true;
                        txtNoiDung.ReadOnly = true;
                        panelLoc.Visible = dgvDSTU.Enabled = btnTraCuu.Enabled = btnThem.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                        txtNoiDung.BackColor = txtGhiChu.BackColor = SystemColors.GradientInactiveCaption;
                        lbLinhVuc.Visible = cmbLinhVuc1.Visible  = lbTuDayDu.Visible = txtTuDayDu.Visible = lbTuVietTat.Visible = txtTuVietTat.Visible = false;
                        if (isSearching)
                        {
                            btnLuu.Enabled = false;
                            lbTuDayDu.Visible = lbTuVietTat.Visible = cmbTuDayDu.Visible = cmbTuVietTat.Visible = true;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                MessageBox.Show("Đang ở chế độ thêm. Vui lòng hoàn tất hoặc hủy bỏ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isUpdate)
            {
                MessageBox.Show("Đang ở chế độ cập nhật. Vui lòng hoàn tất hoặc hủy bỏ trước khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbTuDayDu.Text) || string.IsNullOrWhiteSpace(cmbTuVietTat.Text))
            {
                MessageBox.Show("Vui lòng chọn từ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa từ này không? Hành động này không thể hoàn tác!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    position = cmbTuDayDu.SelectedIndex;
                    using (SqlCommand cmd = new SqlCommand("SP_XOA", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataRowView row = bds_dstu[position] as DataRowView;
                        cmd.Parameters.AddWithValue("@ID", row["ID"]);
                        Program.KetNoi();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa từ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // Chặn lệnh paste mặc định

                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();

                    // Đã cập nhật: Cấu hình font Times New Roman, Size 12, FontStyle.Regular cho đoạn sắp dán
                    txtNoiDung.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);

                    // Chèn đoạn text vào
                    txtNoiDung.SelectedText = clipboardText;
                }
            }
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // Chặn lệnh paste mặc định

                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();

                    // Đã cập nhật: Cấu hình font Times New Roman, Size 12, FontStyle.Regular cho đoạn sắp dán
                    txtGhiChu.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);

                    // Chèn đoạn text vào
                    txtGhiChu.SelectedText = clipboardText;
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cmbLinhVuc.SelectedIndex != -1 && Program.ComboBoxCoGiaTri(cmbLinhVuc, "LINHVUC", cmbLinhVuc.Text.Trim()))
            {
                linhvuc = cmbLinhVuc.Text.Trim();
                if (cmbLinhVuc.SelectedValue.ToString() == "Tất cả")
                {
                    bds_dstu.RemoveFilter();
                }
                else
                {
                    bds_dstu.Filter = $"LinhVuc = '{cmbLinhVuc.SelectedValue}'";
                }
            }
        }

        private void dgvDSTU_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (bds_dstu.Count > 0)
            {
                DataRowView row = bds_dstu[bds_dstu.Position] as DataRowView;
                GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
            }
        }
    }
}
