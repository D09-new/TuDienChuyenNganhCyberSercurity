using Microsoft.Data.SqlClient;
using System.Data;
namespace TuDienChuyenNganhCyberSecurity
{
    public partial class frmMain : Form
    {
        public static BindingSource bds_dstudaydu = new BindingSource();
        public static BindingSource bds_dstuviettat = new BindingSource();
        int position = -1;
        bool isAdd = false;
        bool isUpdate = false;
        string tuviettat = "";
        string tudaydu = "";
        public frmMain()
        {
            InitializeComponent();
            cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTuDayDu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTuVietTat.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void frmMain_Load(object sender, EventArgs e)
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
                    bds_dstudaydu.DataSource = dt;
                    bds_dstuviettat.DataSource = dt;
                    cmbTuDayDu.DataSource = bds_dstudaydu;
                    cmbTuDayDu.DisplayMember = "TuDayDu";
                    cmbTuDayDu.ValueMember = "ID";
                    cmbTuDayDu.SelectedIndex = -1;
                    cmbTuVietTat.DataSource = bds_dstuviettat;
                    cmbTuVietTat.DisplayMember = "TuVietTat";
                    cmbTuVietTat.ValueMember = "ID";
                    cmbTuVietTat.SelectedIndex = -1;
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
                if (isUpdate)
                {
                    MessageBox.Show("Đang ở chế độ cập nhật. Vui lòng hoàn tất hoặc hủy bỏ trước khi tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                TraCuu();
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

        private void TraCuu()
        {
            try
            {
                if (!Program.ComboBoxCoGiaTri(cmbTuDayDu, "TuDayDu", cmbTuDayDu.Text) || !Program.ComboBoxCoGiaTri(cmbTuVietTat, "TuVietTat", cmbTuVietTat.Text))
                {
                    MessageBox.Show("Từ bạn nhập không tồn tại trong từ điển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoiDung.Clear();
                    txtGhiChu.Clear();
                    return;
                }
                if (cmbTuDayDu.SelectedIndex == -1 || cmbTuVietTat.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn từ cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoiDung.Clear();
                    txtGhiChu.Clear();
                    return;
                }
                position = cmbTuDayDu.SelectedIndex;
                txtGhiChu.ReadOnly = true;
                txtNoiDung.ReadOnly = true;
                DataRowView row = bds_dstudaydu[cmbTuDayDu.SelectedIndex] as DataRowView;
                GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                    bds_dstudaydu.DataSource = dt;
                    bds_dstuviettat.DataSource = dt;
                    cmbTuDayDu.DataSource = bds_dstudaydu;
                    cmbTuDayDu.DisplayMember = "TuDayDu";
                    cmbTuDayDu.ValueMember = "ID";
                    cmbTuDayDu.SelectedIndex = position;
                    cmbTuVietTat.DataSource = bds_dstuviettat;
                    cmbTuVietTat.DisplayMember = "TuVietTat";
                    cmbTuVietTat.ValueMember = "ID";
                    cmbTuVietTat.SelectedIndex = position;
                    if (position != -1)
                    {
                        DataRowView row = bds_dstudaydu[cmbTuDayDu.SelectedIndex] as DataRowView;
                        GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                        GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
                    }
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
            cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtGhiChu.ReadOnly = true;
            txtNoiDung.ReadOnly = true;
            if (position != -1)
            {
                cmbTuDayDu.SelectedIndex = position;
                cmbTuVietTat.SelectedIndex = position;
                DataRowView row = bds_dstudaydu[cmbTuDayDu.SelectedIndex] as DataRowView;
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
            btnTraCuu.Enabled = btnThem.Enabled = btnCapNhat.Enabled = btnLuu.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
            isAdd = false;
            isUpdate = false;
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
            }
            isAdd = true;
            btnTraCuu.Enabled = btnCapNhat.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            txtGhiChu.ReadOnly = false;
            txtNoiDung.ReadOnly = false;
            cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.None;
            cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.None;
            cmbTuDayDu.SelectedIndex = -1;
            cmbTuVietTat.SelectedIndex = -1;
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
            if (!isUpdate)
            {
                TraCuu();
            }
            isUpdate = true;
            btnTraCuu.Enabled = btnThem.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            tudaydu = cmbTuDayDu.Text.Trim();
            tuviettat = cmbTuVietTat.Text.Trim();
            txtGhiChu.ReadOnly = false;
            txtNoiDung.ReadOnly = false;
            cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.None;
            cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.None;
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
                    using (SqlCommand cmd = new SqlCommand("SP_THEM", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuDayDu", cmbTuDayDu.Text.Trim());
                        cmd.Parameters.AddWithValue("@TuVietTat", cmbTuVietTat.Text.Trim());
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
                        Program.KetNoi();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm từ mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdd = false;
                    Reload();
                    cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtGhiChu.ReadOnly = true;
                    txtNoiDung.ReadOnly = true;
                    btnTraCuu.Enabled = btnCapNhat.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
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
                    if (string.IsNullOrWhiteSpace(cmbTuDayDu.Text) || string.IsNullOrWhiteSpace(cmbTuVietTat.Text))
                    {
                        MessageBox.Show("Ô từ đầy đủ và từ viết tắt không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (tuviettat != cmbTuVietTat.Text.Trim() || tuviettat != cmbTuVietTat.Text.Trim())
                    {
                        using (SqlCommand check = new SqlCommand("SP_KTHIEUCHINH", Program.conn))
                        {
                            check.CommandType = CommandType.StoredProcedure;
                            check.Parameters.AddWithValue("@TuDayDu", cmbTuDayDu.Text.Trim());
                            check.Parameters.AddWithValue("@TuVietTat", cmbTuVietTat.Text.Trim());
                            Program.KetNoi();
                            check.ExecuteNonQuery();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HIEUCHINH", Program.conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataRowView row = bds_dstudaydu[position] as DataRowView;
                        cmd.Parameters.AddWithValue("@ID", row["ID"]);
                        cmd.Parameters.AddWithValue("@TuDayDu", cmbTuDayDu.Text.Trim());
                        cmd.Parameters.AddWithValue("@TuVietTat", cmbTuVietTat.Text.Trim());
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
                        Program.KetNoi();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật từ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isUpdate = false;
                        Reload();
                        cmbTuDayDu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        cmbTuVietTat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtGhiChu.ReadOnly = true;
                        txtNoiDung.ReadOnly = true;
                        btnTraCuu.Enabled = btnThem.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
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
                        DataRowView row = bds_dstudaydu[position] as DataRowView;
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
    }
}
