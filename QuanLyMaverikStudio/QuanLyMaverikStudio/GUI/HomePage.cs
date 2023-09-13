﻿using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using QuanLyMaverikStudio.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio
{
    public partial class HomePage : Form
    {
        private DataTable user;
        public HomePage(DataTable user)
        {
            InitializeComponent();
            this.user = user;

            lbDate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lbTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            // Khởi tạo và cấu hình Timer
            Timer timer1 = new Timer();
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += new EventHandler(timer1_Tick);

            // Bắt đầu Timer trong hàm khởi tạo Form
            timer1.Start();

            LoadInfo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Hiển thị thời gian lên Label (ví dụ: label1)
            lbTimer.Text = currentTime.ToString("HH:mm:ss");
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login flogin = new Login();
            this.Hide();
            flogin.ShowDialog();
            this.Close();
        }

        public void LoadInfo()
        {
            lbNameStaff.Text = "Tên: " + user.Rows[0]["Tên người dùng"];

            lbPermission.Text = "Quyền: " + user.Rows[0]["Tên quyền"];

            string dateNow = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
            bool check = TimeKeepingDAO.Instance.CheckDiemDanh((int)user.Rows[0]["id"], dateNow);

            if(check == true)
            {
                lbStatusDiemDanh.Text = "Trạng thái: Đã điểm danh";
            }
            else
            {
                lbStatusDiemDanh.Text = "Trạng thái: Chưa điểm danh";
            }
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            string dateNow = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
            bool check = TimeKeepingDAO.Instance.CheckDiemDanh((int)user.Rows[0]["id"], dateNow);

            if(check == true)
            {
                MessageBox.Show("Bạn đã điểm danh hôm nay rồi");
            }
            else
            {
                string dateNowFull = DateTime.Now.ToString();
                bool diemDanh = TimeKeepingDAO.Instance.DiemDanh((int)user.Rows[0]["id"], dateNowFull);

                if(diemDanh == true)
                {
                    MessageBox.Show("Bạn đã điểm danh thành công");

                    lbStatusDiemDanh.Text = "Trạng thái: Đã điểm danh";
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                }
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword fAccountInfo = new ChangePassword(this.user);

            fAccountInfo.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList fUsersList = new UsersList();

            fUsersList.ShowDialog();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertUsers fInsertUsers = new InsertUsers();
            fInsertUsers.ShowDialog();
        }

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrashUsers fTrashUsers = new TrashUsers();

            fTrashUsers.ShowDialog();
        }
    }
}