using Microsoft.Data.SqlClient;
using System.Data;
namespace TuDienChuyenNganhCyberSecurity
{
    public partial class frmMain : Form
    {
        public static BindingSource bds_dstudaydu = new BindingSource();
        public static BindingSource bds_dstuviettat = new BindingSource();
        int position = -1;
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
                position = cmbTuDayDu.SelectedIndex;
                if (!Program.ComboBoxCoGiaTri(cmbTuDayDu, "TuDayDu", cmbTuDayDu.Text) || !Program.ComboBoxCoGiaTri(cmbTuVietTat, "TuVietTat", cmbTuVietTat.Text))
                {
                    MessageBox.Show("Từ bạn nhập không tồn tại trong từ điển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTuDayDu.SelectedIndex == -1 || cmbTuVietTat.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn từ cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRowView row = bds_dstudaydu[cmbTuDayDu.SelectedIndex] as DataRowView;
                GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);

                GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnThem_Click(object sender, EventArgs e)
        {

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

        private void btnTaiLai_Click(object sender, EventArgs e)
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
                    if(position != -1)
                    {
                        DataRowView row = bds_dstudaydu[cmbTuDayDu.SelectedIndex] as DataRowView;
                        GanNoiDungRichTextBox(txtNoiDung, row["NoiDung"]);
                        GanNoiDungRichTextBox(txtGhiChu, row["GhiChu"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
