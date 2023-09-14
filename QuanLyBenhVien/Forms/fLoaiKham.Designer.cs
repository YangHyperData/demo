﻿namespace QuanLyBenhVien.Forms
{
    partial class fLoaiKham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDichVuId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cTinhTrangId = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 848);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cTen,
            this.cGhiChu,
            this.cDichVuId,
            this.cTinhTrangId,
            this.cTrangThai});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1396, 848);
            this.dgv.TabIndex = 0;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            // 
            // cTen
            // 
            this.cTen.DataPropertyName = "TenLoaiKham";
            this.cTen.HeaderText = "Tên Loại Khám";
            this.cTen.Name = "cTen";
            // 
            // cGhiChu
            // 
            this.cGhiChu.DataPropertyName = "GhiChu";
            this.cGhiChu.HeaderText = "Ghi Chú";
            this.cGhiChu.Name = "cGhiChu";
            // 
            // cDichVuId
            // 
            this.cDichVuId.DataPropertyName = "DichVuId";
            this.cDichVuId.HeaderText = "Dịch Vụ";
            this.cDichVuId.Name = "cDichVuId";
            this.cDichVuId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDichVuId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cTinhTrangId
            // 
            this.cTinhTrangId.DataPropertyName = "TinhTrangId";
            this.cTinhTrangId.FalseValue = "0";
            this.cTinhTrangId.HeaderText = "Tình Trạng";
            this.cTinhTrangId.Name = "cTinhTrangId";
            this.cTinhTrangId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTinhTrangId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cTinhTrangId.TrueValue = "1";
            // 
            // cTrangThai
            // 
            this.cTrangThai.DataPropertyName = "TrangThaiId";
            this.cTrangThai.HeaderText = "Trạng Thái";
            this.cTrangThai.Name = "cTrangThai";
            // 
            // fLoaiKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 848);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fLoaiKham";
            this.Text = "DM Loại Khám";
            this.Load += new System.EventHandler(this.fLoaiKham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewComboBoxColumn cDichVuId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cTinhTrangId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangThai;
    }
}