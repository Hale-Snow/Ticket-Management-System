using LeshanTicketSystem.BLL;
using LeshanTicketSystem.Model;
using MaterialSkin3.Controls;
namespace LeshanTicketSystem.UI
{

    public partial class LoginForm : MaterialForm
    {
        private AdminBLL adminBLL = new AdminBLL();
        public LoginForm()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
            string uid = boxid.Text.Trim();
            string password = boxpasswd.Text.Trim();
            if (adminBLL.Login(uid, password, out Admin admin))
            {
                MessageBox.Show($"欢迎，管理员 {admin.Uid}", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Session.CurrentAdmin = admin; // 保存当前管理员信息
                // 登录成功后，打开主界面并隐藏当前的 LoginForm
                MainForm main = new MainForm();
                main.Show();  // 打开主界面
                this.Hide();  // 隐藏当前的 LoginForm
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
