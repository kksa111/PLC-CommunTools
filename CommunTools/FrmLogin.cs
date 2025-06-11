using System;
using System.Drawing;
using System.Windows.Forms;
using Com_CSSkin;
using CommunTools.Common;

namespace CommunTools
{
    /// <summary>
    /// 登录界面
    /// </summary>
    public class FrmLogin : CSSkinMain
    {
        private TextBox txtUser;
        private TextBox txtPwd;
        private Button btnOk;
        private Button btnCancel;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUser = new TextBox();
            this.txtPwd = new TextBox();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new Point(80, 25);
            this.txtUser.Size = new Size(150, 21);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new Point(80, 60);
            this.txtPwd.Size = new Size(150, 21);
            this.txtPwd.PasswordChar = '*';
            // 
            // btnOk
            // 
            this.btnOk.Location = new Point(40, 100);
            this.btnOk.Size = new Size(75, 23);
            this.btnOk.Text = "登录";
            this.btnOk.Click += new EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(140, 100);
            this.btnCancel.Size = new Size(75, 23);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += (s, e) => this.Close();
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(260, 150);
            this.Controls.Add(new Label { Text = "用户", Location = new Point(30, 28), AutoSize = true });
            this.Controls.Add(this.txtUser);
            this.Controls.Add(new Label { Text = "密码", Location = new Point(30, 63), AutoSize = true });
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (UserSession.Login(txtUser.Text.Trim(), txtPwd.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
    }
}
