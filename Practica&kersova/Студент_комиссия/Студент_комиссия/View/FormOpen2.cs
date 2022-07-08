using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Студент_комиссия.Model;

namespace Студент_комиссия.View
{
    public partial class FormOpen2 : Form
    {
        public FormOpen2()
        {
            InitializeComponent();
        }
        public FormOpen2(string txt)
        {
            InitializeComponent();
            richTextBox1.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form form1 = new start_menu();
            form1.Show();
            form1.Location = this.Location;
            this.Hide();

        }
    }
}
