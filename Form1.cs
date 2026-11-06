using System;
using System.Data;
using System.Windows.Forms;
using Lab11_CRUD_StoredProcedure.BUS;

namespace Lab12_MasterDetail_Transaction
{
    public partial class Form1 : Form
    {
        private SinhVienBUS svBus = new SinhVienBUS();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMasterData();
        }

        private void LoadMasterData()
        {
            try
            {
                // Tải toàn bộ danh sách sinh viên lên bảng trên (Master)
                dataGridView1.DataSource = svBus.LayDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi click vào một dòng trên bảng Master (dataGridView1)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["MaKhoa"].Value != null)
                {
                    string maKhoa = row.Cells["MaKhoa"].Value.ToString();
                    // Lọc dữ liệu theo khoa và đổ xuống bảng Detail (dataGridView2)
                    dataGridView2.DataSource = svBus.GetByDepartment(maKhoa);
                }
            }
        }

        // Khớp sự kiện CellContentClick tự động gọi từ Designer
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
        }

        // Khớp sự kiện SelectionChanged tự động gọi từ Designer
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells["MaKhoa"].Value != null)
                {
                    string maKhoa = row.Cells["MaKhoa"].Value.ToString();
                    dataGridView2.DataSource = svBus.GetByDepartment(maKhoa);
                }
            }
        }
    }
}