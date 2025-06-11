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
        private TableLayoutPanel layout;

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
            this.layout = new TableLayoutPanel();
            this.SuspendLayout();

            // layout
            this.layout.ColumnCount = 2;
            this.layout.RowCount = 3;
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            this.layout.Dock = DockStyle.Fill;
            this.layout.Padding = new Padding(20);

            // txtUser
            this.txtUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtUser.Margin = new Padding(3, 3, 20, 3);

            // txtPwd
            this.txtPwd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtPwd.Margin = new Padding(3, 3, 20, 3);
            this.txtPwd.PasswordChar = '*';

            // btnOk
            this.btnOk.Text = "登录";
            this.btnOk.Anchor = AnchorStyles.Right;
            this.btnOk.Click += new EventHandler(this.btnOk_Click);

            // btnCancel
            this.btnCancel.Text = "取消";
            this.btnCancel.Anchor = AnchorStyles.Left;
            this.btnCancel.Click += (s, e) => this.Close();

            // assemble layout
            this.layout.Controls.Add(new Label { Text = "用户", AutoSize = true, Anchor = AnchorStyles.Right }, 0, 0);
            this.layout.Controls.Add(this.txtUser, 1, 0);
            this.layout.Controls.Add(new Label { Text = "密码", AutoSize = true, Anchor = AnchorStyles.Right }, 0, 1);
            this.layout.Controls.Add(this.txtPwd, 1, 1);
            this.layout.Controls.Add(this.btnOk, 0, 2);
            this.layout.Controls.Add(this.btnCancel, 1, 2);

            // FrmLogin
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new Size(300, 160);
            this.Controls.Add(this.layout);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.MinimumSize = new Size(300, 160);
            this.AcceptButton = this.btnOk;
            this.CancelButton = this.btnCancel;
            this.ResumeLayout(false);
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
