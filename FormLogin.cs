using System;
using System.Windows.Forms;

namespace webtest
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 打开主窗体（Form1），以模态方式显示，登录窗口关闭后应用退出
            this.Hide();
            using (var main = new Form1())
            {
                main.ShowDialog();
            }
            this.Close();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            // 访客登录逻辑（当前为模拟）
            MessageBox.Show("访客登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            using (var main = new Form1())
            {
                main.ShowDialog();
            }
            this.Close();
        }
    }
}
