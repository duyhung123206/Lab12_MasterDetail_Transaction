namespace Lab12_MasterDetail_Transaction
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo đầy đủ các biến điều khiển để khớp hoàn toàn với InitializeComponent()
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemTransaction = new System.Windows.Forms.Button();
            this.btnTestRollback = new System.Windows.Forms.Button();
            this.btnChuyenKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoaAnToa = new System.Windows.Forms.Button();
            this.btnCapNhatDiem = new System.Windows.Forms.Button();
            this.btnKiemSoatXungDot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(87, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(601, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi tiết sinh viên theo khoa";
            // 
            // btnThemTransaction
            // 
            this.btnThemTransaction.Location = new System.Drawing.Point(190, 465);
            this.btnThemTransaction.Name = "btnThemTransaction";
            this.btnThemTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnThemTransaction.TabIndex = 3;
            this.btnThemTransaction.Text = "Thêm";
            this.btnThemTransaction.UseVisualStyleBackColor = true;
            this.btnThemTransaction.Click += new System.EventHandler(this.btnThemTransaction_Click);
            // 
            // btnTestRollback
            // 
            this.btnTestRollback.Location = new System.Drawing.Point(395, 465);
            this.btnTestRollback.Name = "btnTestRollback";
            this.btnTestRollback.Size = new System.Drawing.Size(114, 23);
            this.btnTestRollback.TabIndex = 4;
            this.btnTestRollback.Text = "Test Rollback";
            this.btnTestRollback.UseVisualStyleBackColor = true;
            this.btnTestRollback.Click += new System.EventHandler(this.btnTestRollback_Click);
            // 
            // btnChuyenKhoa
            // 
            this.btnChuyenKhoa.Location = new System.Drawing.Point(190, 541);
            this.btnChuyenKhoa.Name = "btnChuyenKhoa";
            this.btnChuyenKhoa.Size = new System.Drawing.Size(117, 23);
            this.btnChuyenKhoa.TabIndex = 5;
            this.btnChuyenKhoa.Text = "Chuyển Khoa";
            this.btnChuyenKhoa.UseVisualStyleBackColor = true;
            this.btnChuyenKhoa.Click += new System.EventHandler(this.btnChuyenKhoa_Click);
            // 
            // btnXoaKhoaAnToa
            // 
            this.btnXoaKhoaAnToa.Location = new System.Drawing.Point(395, 541);
            this.btnXoaKhoaAnToa.Name = "btnXoaKhoaAnToa";
            this.btnXoaKhoaAnToa.Size = new System.Drawing.Size(147, 23);
            this.btnXoaKhoaAnToa.TabIndex = 6;
            this.btnXoaKhoaAnToa.Text = "Xóa Khoa An Toàn";
            this.btnXoaKhoaAnToa.UseVisualStyleBackColor = true;
            this.btnXoaKhoaAnToa.Click += new System.EventHandler(this.btnXoaKhoaAnToan_Click);
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.Location = new System.Drawing.Point(587, 465);
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.Size = new System.Drawing.Size(133, 23);
            this.btnCapNhatDiem.TabIndex = 7;
            this.btnCapNhatDiem.Text = "Cập Nhật Điểm";
            this.btnCapNhatDiem.UseVisualStyleBackColor = true;
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // btnKiemSoatXungDot
            // 
            this.btnKiemSoatXungDot.Location = new System.Drawing.Point(587, 541);
            this.btnKiemSoatXungDot.Name = "btnKiemSoatXungDot";
            this.btnKiemSoatXungDot.Size = new System.Drawing.Size(146, 23);
            this.btnKiemSoatXungDot.TabIndex = 8;
            this.btnKiemSoatXungDot.Text = "Kiểm Soát Xung Đột";
            this.btnKiemSoatXungDot.UseVisualStyleBackColor = true;
            this.btnKiemSoatXungDot.Click += new System.EventHandler(this.btnKiemSoatXungDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 608);
            this.Controls.Add(this.btnKiemSoatXungDot);
            this.Controls.Add(this.btnCapNhatDiem);
            this.Controls.Add(this.btnXoaKhoaAnToa);
            this.Controls.Add(this.btnChuyenKhoa);
            this.Controls.Add(this.btnTestRollback);
            this.Controls.Add(this.btnThemTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1 - Master Detail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemTransaction;
        private System.Windows.Forms.Button btnTestRollback;
        private System.Windows.Forms.Button btnChuyenKhoa;
        private System.Windows.Forms.Button btnXoaKhoaAnToa;
        private System.Windows.Forms.Button btnCapNhatDiem;
        private System.Windows.Forms.Button btnKiemSoatXungDot;
    }
}