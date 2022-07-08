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
    public partial class FormCreat : Form
    {
        public FormCreat()
        {
            InitializeComponent();
        }

        private void FormCreat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите выйти из программы?","Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formstart_menu = new start_menu();
            formstart_menu.Show();
            formstart_menu.Location = this.Location;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//проверка данных и переход
        {      
            try
            {
                string[] dann=new string[6];
                dann[0] = predmet_1.Text;
                dann[1] = predmet_2.Text;
                dann[2] = predmet_3.Text;
                dann[3] = predmet_4.Text;
                dann[4] = predmet_5.Text;
                dann[5] = predmet_6.Text;
                int k = 0;
                for(int i=0;i<dann.Length;i++)
                {
                    bool chek = false;
                    if ((dann[i] != "?") & (dann[i] != "Нет"))
                    {
                        chek = true;
                        for (int j = 0; (chek) & (j < i); j++)
                        {
                            if (dann[j] == dann[i]) chek = false;
                        }

                        if (chek)
                        {
                            k++;
                        }
                    }
                

                }
                string[] otp = new string[k];
                k = 0;
  
                for(int i = 0; i < dann.Length; i++)
                {
                    bool chek = false;
                    if ((dann[i] != "?") & (dann[i] != "Нет"))
                    {
                        chek = true;
                        for (int j=0; (chek) & (j < i); j++)
                        { 
                            if (dann[j] == dann[i]) chek = false;
                        }

                        if (chek)
                        {
                            otp[k] = dann[i];
                            k++;
                        }
                    }
                }
                
              
                Form formcreat2 = new FormCreat2(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text),otp);
                formcreat2.Show();
                formcreat2.Location = this.Location;
                this.Hide();
            }
            catch
            {
                DialogResult res;
                res = MessageBox.Show("Проверьте поля на ошибки", "Сбой данных");
            }
        }
    }
}
