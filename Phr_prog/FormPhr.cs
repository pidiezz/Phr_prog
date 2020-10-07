using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phr_prog
{
    public partial class FormPhr : Form
    {
        public FormPhr()
        {
            InitializeComponent();
            if (FormAutorization.users.type == "пользователь") textBoxName.Enabled = false;
            comboBoxPhorm.Enabled = false; textBoxDosage.Enabled = false; textBoxProz.Enabled = false; textBoxTime.Enabled = false;
            buttonAdd.Enabled = false; buttonDel.Enabled = false; buttonEdit.Enabled = false; labelDose.Enabled = false; labelProz.Enabled = false;
            labelTime.Enabled = false; labelPhorm.Enabled = false; labelName.Enabled = false; labelPhone.Enabled = false;
           ShowDrugs();
        }


        void ShowDrugs()
        {
            listViewDrugs.Items.Clear();
            foreach (Drugs drugs in Program.phrDb.Drugs)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    drugs.id.ToString(), drugs.Name, drugs.Phorm, drugs.Dosage, drugs.Proz, drugs.Time
                }); ;
                item.Tag = drugs;
                listViewDrugs.Items.Add(item);

            }
            listViewDrugs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }




        private void listViewDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrugs.SelectedItems.Count == 1)
            {
                Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                textBoxName.Text = drugs.Name;
                comboBoxPhorm.Text = drugs.Phorm;
                textBoxDosage.Text = drugs.Dosage;
                textBoxProz.Text = drugs.Proz;
                textBoxTime.Text = drugs.Time;
            }
            else
            {
                textBoxName.Text = "";
                comboBoxPhorm.Text = "";
                textBoxDosage.Text = "";
                textBoxProz.Text = " ";
                textBoxTime.Text = " ";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Drugs drugs = new Drugs();
            drugs.Name = textBoxName.Text;
            drugs.Phorm = comboBoxPhorm.Text;
            drugs.Dosage = textBoxDosage.Text;
            drugs.Proz = textBoxProz.Text;
            drugs.Time = textBoxTime.Text;
            Program.phrDb.Drugs.Add(drugs);
            Program.phrDb.SaveChanges();
            ShowDrugs();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDrugs.SelectedItems.Count == 1)
            {
                Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                drugs.Name = textBoxName.Text;
                drugs.Phorm = comboBoxPhorm.Text;
                drugs.Dosage = textBoxDosage.Text;
                drugs.Proz = textBoxProz.Text;
                drugs.Time = textBoxTime.Text;

                Program.phrDb.SaveChanges();
                ShowDrugs();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDrugs.SelectedItems.Count == 1)
                {
                    Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                    Program.phrDb.Drugs.Remove(drugs);
                    Program.phrDb.SaveChanges();
                    ShowDrugs();
                }
                textBoxName.Text = "";
                comboBoxPhorm.Text = "";
                textBoxDosage.Text = "";
                textBoxProz.Text = " ";
                textBoxTime.Text = " ";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
    }
}
