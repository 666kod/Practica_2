
namespace Студент_комиссия.View
{
    partial class FormCreat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.predmet_1 = new System.Windows.Forms.ComboBox();
            this.predmet_3 = new System.Windows.Forms.ComboBox();
            this.predmet_2 = new System.Windows.Forms.ComboBox();
            this.predmet_4 = new System.Windows.Forms.ComboBox();
            this.predmet_5 = new System.Windows.Forms.ComboBox();
            this.predmet_6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество мест поступления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество абитуриентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(153, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Предметы ЕГЭ для поступления";
            // 
            // predmet_1
            // 
            this.predmet_1.FormattingEnabled = true;
            this.predmet_1.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_1.Location = new System.Drawing.Point(26, 241);
            this.predmet_1.Name = "predmet_1";
            this.predmet_1.Size = new System.Drawing.Size(206, 21);
            this.predmet_1.TabIndex = 15;
            this.predmet_1.Text = "?";
            // 
            // predmet_3
            // 
            this.predmet_3.FormattingEnabled = true;
            this.predmet_3.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_3.Location = new System.Drawing.Point(26, 325);
            this.predmet_3.Name = "predmet_3";
            this.predmet_3.Size = new System.Drawing.Size(206, 21);
            this.predmet_3.TabIndex = 16;
            this.predmet_3.Text = "?";
            // 
            // predmet_2
            // 
            this.predmet_2.FormattingEnabled = true;
            this.predmet_2.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_2.Location = new System.Drawing.Point(26, 283);
            this.predmet_2.Name = "predmet_2";
            this.predmet_2.Size = new System.Drawing.Size(206, 21);
            this.predmet_2.TabIndex = 17;
            this.predmet_2.Text = "?";
            // 
            // predmet_4
            // 
            this.predmet_4.FormattingEnabled = true;
            this.predmet_4.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_4.Location = new System.Drawing.Point(316, 241);
            this.predmet_4.Name = "predmet_4";
            this.predmet_4.Size = new System.Drawing.Size(206, 21);
            this.predmet_4.TabIndex = 18;
            this.predmet_4.Text = "?";
            // 
            // predmet_5
            // 
            this.predmet_5.FormattingEnabled = true;
            this.predmet_5.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_5.Location = new System.Drawing.Point(316, 283);
            this.predmet_5.Name = "predmet_5";
            this.predmet_5.Size = new System.Drawing.Size(206, 21);
            this.predmet_5.TabIndex = 19;
            this.predmet_5.Text = "?";
            // 
            // predmet_6
            // 
            this.predmet_6.FormattingEnabled = true;
            this.predmet_6.Items.AddRange(new object[] {
            "Нет",
            "Русский язык",
            "Математика ",
            "Информатика",
            "Физика",
            "Химия",
            "Литература",
            "Биология",
            "Иностранный язык",
            "География",
            "История",
            "Общество"});
            this.predmet_6.Location = new System.Drawing.Point(316, 325);
            this.predmet_6.Name = "predmet_6";
            this.predmet_6.Size = new System.Drawing.Size(206, 21);
            this.predmet_6.TabIndex = 20;
            this.predmet_6.Text = "?";
            // 
            // FormCreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 422);
            this.Controls.Add(this.predmet_6);
            this.Controls.Add(this.predmet_5);
            this.Controls.Add(this.predmet_4);
            this.Controls.Add(this.predmet_2);
            this.Controls.Add(this.predmet_3);
            this.Controls.Add(this.predmet_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormCreat";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox predmet_1;
        private System.Windows.Forms.ComboBox predmet_3;
        private System.Windows.Forms.ComboBox predmet_2;
        private System.Windows.Forms.ComboBox predmet_4;
        private System.Windows.Forms.ComboBox predmet_5;
        private System.Windows.Forms.ComboBox predmet_6;
    }
}