using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phr_prog
{
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAutorization : Form
    {

        public static User users = new User();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == " " && textBoxPassword.Text == " ")
            {
                MessageBox.Show("введите данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bool key = false;
                foreach (Users user in Program.phrDb.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("проверьте данные", "пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = " ";
                    textBoxPassword.Text = " ";
                }
                else
                { 
                    FormPhr phr = new FormPhr();
                    phr.Show();
                    this.Hide();
                }

            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
             Form formReg = new FormReg();
             formReg.Show();
             this.Hide();
        }
    }
}
