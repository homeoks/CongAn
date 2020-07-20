using CongAn.Entity;
using CongAn.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wf6c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void LoadGrid()
        {

            dataGridView1.Columns.Add("STT", "STT");
        dataGridView1.Columns.Add("LoaiDt", "LoaiDt");
        dataGridView1.Columns.Add("HoVaTen", "HoVaTen");
        dataGridView1.Columns.Add("NamSinh", "NamSinh");
        dataGridView1.Columns.Add("NoiSinh", "NoiSinh");
        dataGridView1.Columns.Add("QueQuan", "QueQuan");
        dataGridView1.Columns.Add("NoiDktt", "NoiDktt");
        dataGridView1.Columns.Add("NoiOHienTai", "NoiOHienTai");
        dataGridView1.Columns.Add("TrinhDoHocVan", "TrinhDoHocVan");
        dataGridView1.Columns.Add("NgheNghiep", "NgheNghiep");
        dataGridView1.Columns.Add("VoChong", "VoChong");
        dataGridView1.Columns.Add("Cha", "Cha");
        dataGridView1.Columns.Add("Me", "Me");
        dataGridView1.Columns.Add("Con", "Con");
        dataGridView1.Columns.Add("AnhChiEm", "AnhChiEm");
        dataGridView1.Columns.Add("TienAn", "TienAn");
        dataGridView1.Columns.Add("MoiQHXH", "MoiQHXH");
        dataGridView1.Columns.Add("HinhAnhDt", "HinhAnhDt");
        dataGridView1.Columns.Add("Cmnd", "Cmnd");
        dataGridView1.Columns.Add("NgayCap", "NgayCap");
        dataGridView1.Columns.Add("SoHoKhau", "SoHoKhau");
        dataGridView1.Columns.Add("DacDiemNhanDang", "DacDiemNhanDang");
        dataGridView1.Columns.Add("GhiChu", "GhiChu");

            var data = UserRepository.GetList();
            foreach(var user in data)
            {
                dataGridView1.Rows.Add(
                    user.STT,
                    user.LoaiDt,
                    user.HoVaTen,
                    user.NamSinhText,
                    user.NoiSinh,
                    user.QueQuan,
                    user.NoiDktt,
                    user.NoiOHienTai,
                    user.TrinhDoHocVan,
                    user.NgheNghiep,
                    user.VoChong,
                    user.Cha,
                    user.Me,
                    user.Con,
                    user.AnhChiEm,
                    user.TienAn,
                    user.MoiQHXH,
                    user.HinhAnhDt,
                    user.Cmnd,
                    user.NgayCap,
                    user.SoHoKhau,
                    user.DacDiemNhanDang,
                    user.GhiChu
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRepository.AddNew(new User
            {
                LoaiDt = "Tắ",
                HoVaTen = "ă",
                NamSinhText = "ấ",
                NoiSinh = "Ấ",
                QueQuan = "Test",
                NoiDktt = "Test",
                NoiOHienTai = "Test",
                TrinhDoHocVan = "Test",
                NgheNghiep = "Test",
                VoChong = "Test",
                Cha = "Test",
                Me = "Test",
                Con = "Test",
                AnhChiEm = "Test",
                TienAn = "Test",
                MoiQHXH = "Test",
                HinhAnhDt = "Test",
                Cmnd = "Test",
                NgayCap = "Test",
                SoHoKhau = "Test",
                DacDiemNhanDang = "Test",
                GhiChu = "Test",
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
