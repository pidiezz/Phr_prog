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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonAut_Click(object sender, EventArgs e)
        {
            Form formAutorization = new FormAutorization();
            formAutorization.Show();
            this.Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Login = textBoxLogin.Text;
            users.Password = textBoxPassword.Text;
            users.Type = comboBoxType.Text;
            Program.phrDb.Users.Add(users);
            Program.phrDb.SaveChanges();
            Form formAutorization = new FormAutorization();
            formAutorization.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
