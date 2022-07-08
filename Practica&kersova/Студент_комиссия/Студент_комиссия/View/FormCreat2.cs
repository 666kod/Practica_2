using System;
using System.IO;
using System.Windows.Forms;
using Студент_комиссия.Model;

namespace Студент_комиссия.View
{
    public partial class FormCreat2 : Form
    {
        private int i = 0;
        private int index=0;
        private string[] np;
        private Listcommissions A;
        public FormCreat2()
        {
            InitializeComponent();
        }
        public FormCreat2(string a, int b, int c,string[] name_predmet)
        {
            A = new Listcommissions(a, b,c);
            InitializeComponent();
            this.Text = $"1 поступающий из {c}";
            index = name_predmet.Length;
            np = name_predmet;
            for(int y=0;y<name_predmet.Length;y++)
            {
                switch (y)
                {
                    case 0: pred_1.Text = name_predmet[y]; break;
                    case 1: pred_2.Text = name_predmet[y]; break;
                    case 2: pred_3.Text = name_predmet[y]; break;
                    case 3: pred_4.Text = name_predmet[y]; break;
                    case 4: pred_5.Text = name_predmet[y]; break;
                    case 5: pred_6.Text = name_predmet[y]; break;
                    default: break;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)//отмена
        {
            Form formcreat = new FormCreat();
            formcreat.Show();
            formcreat.Location = this.Location;
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)//добавить в список
        {
            try
            {
                int[]bp = new int[index];
                for(int y = 0; y < index; y++)
                {
                    switch (y)
                    {
                        case 0: bp[y] = (int)numericUpDown1.Value; break;
                        case 1: bp[y] = (int)numericUpDown2.Value; break;
                        case 2: bp[y] = (int)numericUpDown3.Value; break;
                        case 3: bp[y] = (int)numericUpDown4.Value; break;
                        case 4: bp[y] = (int)numericUpDown5.Value; break;
                        case 5: bp[y] = (int)numericUpDown6.Value; break;
                        default: break;
                    }
                }
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
                numericUpDown5.Value = 0;
                numericUpDown6.Value = 0;
                if (i < A.kolin())
                {

                    A[i] = new Incoming(xsurname.Text,xname.Text,xpatronymic.Text,comboBox1.Text, xdatadn.Value,np, bp);
                        this.Text = $"{i + 1} поступающий из {A.kolin()}";
                    i++;
                }
                else
                {
                    DialogResult res;
                    res = MessageBox.Show("Список закончен", "Список закончен");
                }
                xsurname.Clear();
                xname.Clear();
                xpatronymic.Clear();
                comboBox1.Text ="";
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                numericUpDown4.Value = 0;
                numericUpDown5.Value = 0;
                numericUpDown6.Value = 0;
            }
            catch
            {
                DialogResult res;
                res = MessageBox.Show("Проверьте поля на ошибки", "Сбой данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)//сохранить как
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                string txt = A.show();
                txt += A.showok();
                txt += A.showhet();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txt);
                }
            }
            catch
            {
                DialogResult res;
                res = MessageBox.Show("Заполните список до конца", "Сбой данных");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Form form1 = new start_menu();
                form1.Show();
                form1.Location = this.Location;
                this.Hide();
            
            

        }
        private void FormCreat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы действительно хотите выйти из программы?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) e.Cancel = true;
        }

        private void button5_Click(object sender, EventArgs e)//просмотр
        {
            string txt = A.show();
            txt += A.showok();
            txt += A.showhet();
            Form form1 = new FormOpen2(txt); 
            form1.Show();
            form1.Location = this.Location;
            
        }
    }
}
