using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            if (comboMajor.SelectedIndex <= 0)
            {
                lblError.Text = "请选择专业。";
                return;
            }

            var studentId = txtStudentId.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(studentId, "^\\d{8,12}$"))
            {
                lblError.Text = "请输入 8-12 位数字学号。";
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                lblError.Text = "密码长度至少 6 位。";
                return;
            }

            // TODO: 调用后端验证。当前为模拟成功。
            this.Hide();
            MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            // 访客登录逻辑（当前为模拟）
            this.Hide();
            MessageBox.Show("访客登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
