using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Lab11_CRUD_StoredProcedure.BUS;
using Lab11_CRUD_StoredProcedure.DTO;

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
                dataGridView1.DataSource = svBus.LayDanhSach();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    LoadDetailData(dataGridView1.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDetailData(DataGridViewRow row)
        {
            if (row != null && row.Cells["MaSV"].Value != null)
            {
                string maSV = row.Cells["MaSV"].Value.ToString();
                dataGridView2.DataSource = svBus.GetDangKyByMaSV(maSV);

                if (label1 != null)
                {
                    label1.Text = $"Danh sách học phần của sinh viên: {row.Cells["HoTen"].Value}";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) LoadDetailData(dataGridView1.Rows[e.RowIndex]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) LoadDetailData(dataGridView1.Rows[e.RowIndex]);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                LoadDetailData(dataGridView1.CurrentRow);
            }
        }

        private void btnThemTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = svBus.ThemSinhVienVaDangKy("24001298", "Nguyễn Văn A", "10/05/2004", true, new List<string> { "HP01", "HP02" });
                if (kq)
                {
                    MessageBox.Show("Thêm sinh viên và học phần thành công qua Transaction!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMasterData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnTestRollback_Click(object sender, EventArgs e)
        {
            try
            {
                svBus.TestRollbackTransaction("24001299", "Test Rollback", new List<string> { "HP01", "ERR_HP" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giao dịch thất bại và đã hoàn tác (Rollback)!\n" + ex.Message, "Kiểm chứng Rollback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadMasterData();
            }
        }

        private void btnChuyenKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string maSV = dataGridView1.CurrentRow.Cells["MaSV"].Value.ToString();
                    svBus.ChuyenKhoaSinhVien(maSV, "CNTT", "ATTT");
                    MessageBox.Show("Chuyển khoa thành công qua Transaction!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMasterData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnXoaKhoaAnToan_Click(object sender, EventArgs e)
        {
            try
            {
                svBus.XoaKhoaAnToan("CNTT");
                MessageBox.Show("Xóa khoa an toàn thành công (Không có dữ liệu mồ côi)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMasterData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<DangKyDTO> dsCapNhat = new List<DangKyDTO>
                {
                    new DangKyDTO { MaSV = "24001296", MaHP = "HP01", Diem = 8.5m },
                    new DangKyDTO { MaSV = "24001296", MaHP = "HP02", Diem = 11.0m } // Lỗi kích hoạt Rollback
                };
                svBus.CapNhatDiemHangLoat(dsCapNhat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giao dịch cập nhật điểm thất bại và đã hoàn tác (Rollback)!\n" + ex.Message, "Kiểm chứng Rollback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadMasterData();
            }
        }

        private void btnKiemSoatXungDot_Click(object sender, EventArgs e)
        {
            try
            {
                DangKyDTO dtoTest = new DangKyDTO { MaSV = "24001296", MaHP = "HP01", Diem = 9.0m, RowVersion = new byte[] { 1, 2, 3, 4 } };
                svBus.KiemSoatXungDotCapNhat(dtoTest);
                MessageBox.Show("Cập nhật thành công, không có xung đột!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phát hiện xung đột cập nhật:\n" + ex.Message, "Lỗi đồng thời", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}