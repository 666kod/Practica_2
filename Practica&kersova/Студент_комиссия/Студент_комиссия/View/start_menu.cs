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

        private void Redbutton_Click(object sender, EventArgs e) //форма открытия списка
        {
            Form formopen = new FormOpen();
            formopen.Show();
            formopen.Location = this.Location;
            this.Hide();
        }

        private void start_menu_FormClosing(object sender, FormClosingEventArgs e)//выход
        {
            Application.Exit();
        }

       

        private void Sozdatel_Click(object sender, EventArgs e)//форма информации
        {
            Form formraz = new info();
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
