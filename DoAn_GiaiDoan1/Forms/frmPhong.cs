using DoAn_GiaiDoan1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_GiaiDoan1.Forms
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        QLQKDbContext context = new QLQKDbContext();
        bool xulyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenPhong.Enabled = giaTri;
            cboLoaiPhong.Enabled = giaTri;
            txtTrangThai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);

           
            cboLoaiPhong.DataSource = context.LoaiPhong.ToList();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "ID";

            var ds = context.Phong
                .Include(p => p.LoaiPhong)
                .Select(p => new
                {
                    p.ID,
                    p.TenPhong,
                    p.TrangThai,
                    p.LoaiPhongID,
                    LoaiPhong = p.LoaiPhong.TenLoaiPhong,
                    SucChua = p.LoaiPhong.SucChua,
                    GiaGio = p.LoaiPhong.GiaGio
                })
                .ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = ds;

            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", bs, "TenPhong", false, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", bs, "TrangThai", false, DataSourceUpdateMode.Never);

            cboLoaiPhong.DataBindings.Clear();
            cboLoaiPhong.DataBindings.Add("SelectedValue", bs, "LoaiPhongID", false, DataSourceUpdateMode.Never);

            


            dataGridView1.DataSource = bs;
            dataGridView1.Columns["LoaiPhongID"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);

            txtTenPhong.Clear();
            txtTrangThai.Clear();
            cboLoaiPhong.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) || string.IsNullOrWhiteSpace(cboLoaiPhong.Text) || string.IsNullOrWhiteSpace(txtTrangThai.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                if (xulyThem)
                {
                    Phong p = new Phong();
                    p.TenPhong = txtTenPhong.Text;
                    p.TrangThai = txtTrangThai.Text;
                    p.LoaiPhongID = (int)cboLoaiPhong.SelectedValue;
                    context.Phong.Add(p);
                    context.SaveChanges();
                }
                else
                {
                    Phong p = context.Phong.Find(id);
                    if (p != null)
                    {
                        p.TenPhong = txtTenPhong.Text;
                        p.TrangThai = txtTrangThai.Text;
                        p.LoaiPhongID = (int)cboLoaiPhong.SelectedValue;
                        context.Phong.Add(p);
                        context.SaveChanges();
                    }
                }
                frmPhong_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phòng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                Phong p = context.Phong.Find(id);
                if (p != null)
                {
                    context.Phong.Remove(p);
                }
                context.SaveChanges();
                frmPhong_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

