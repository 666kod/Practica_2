using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Студент_комиссия.View;

namespace Студент_комиссия
{
    public partial class start_menu : Form
    {
        public start_menu()
        {
            InitializeComponent();
        }

        private void start_menu_Load(object sender, EventArgs e)
        {

        }

        private void Creat_Click(object sender, EventArgs e) //форма создания списка
        {
            Form formcreat = new FormCreat();
            formcreat.Show();
            formcreat.Location = this.Location;
            this.Hide();
        }

        private void Redbutton_Click(object sender, EventArgs e) // редоктирования
        {
            Form formopen = new FormOpen();
            formopen.Show();
            formopen.Location = this.Location;
            this.Hide();
        }

        private void start_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите выйти из программы?","Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void Help_Click(object sender, EventArgs e)// помощь пользователю
        {
            Form formhelp = new FormHelp();
            formhelp.Show();
            formhelp.Location = this.Location;
            this.Hide();
        }

        private void Sozdatel_Click(object sender, EventArgs e)// о себе
        {
            Form formraz = new FormRazrab();
            formraz.Show();
            formraz.Location = this.Location;
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
