using Microsoft.Data.SqlClient;
using System.Data;
namespace TuDienChuyenNganhCyberSercurity
{
    public partial class frmMain : Form
    {
        public static BindingSource bds_dstu = new BindingSource();
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
            string query = "SELECT * FROM TUDIEN";
            DataTable dt = new DataTable();
            Program.KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
            da.Fill(dt);
            bds_dstu.DataSource = dt;
            cmbTuDayDu.DataSource = bds_dstu;
            cmbTuDayDu.DisplayMember = "TuDayDu";
            cmbTuDayDu.ValueMember = "ID";
            cmbTuDayDu.SelectedIndex = -1;
            cmbTuVietTat.DataSource = bds_dstu;
            cmbTuVietTat.DisplayMember = "TuVietTat";
            cmbTuVietTat.ValueMember = "ID";
            cmbTuVietTat.SelectedIndex = -1;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Program.ComboBoxCoGiaTri(cmbTuDayDu, "TuDayDu", cmbTuDayDu.Text) || !Program.ComboBoxCoGiaTri(cmbTuVietTat, "TuVietTat", cmbTuVietTat.Text))
                {
                    MessageBox.Show("Từ bạn nhập không tồn tại trong từ điển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTuDayDu.SelectedIndex == -1 || cmbTuVietTat.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn từ cần tra cứu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataRowView row = bds_dstu[bds_dstu.Position] as DataRowView;
                if (row["NoiDung"] != DBNull.Value && !string.IsNullOrEmpty(row["NoiDung"].ToString()))
                {
                    txtNoiDung.Rtf = row["NoiDung"].ToString();
                }
                else
                {
                    txtNoiDung.Clear(); // Nếu trống thì xóa trắng ô nhập liệu
                }

                // Kiểm tra và gán cho txtGhiChu
                if (row["GhiChu"] != DBNull.Value && !string.IsNullOrEmpty(row["GhiChu"].ToString()))
                {
                    txtGhiChu.Rtf = row["GhiChu"].ToString();
                }
                else
                {
                    txtGhiChu.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
