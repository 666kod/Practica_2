
namespace Студент_комиссия
{
    partial class start_menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Redbutton = new System.Windows.Forms.Button();
            this.Creat = new System.Windows.Forms.Button();
            this.Sozdatel = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Redbutton
            // 
            this.Redbutton.BackColor = System.Drawing.Color.Transparent;
            this.Redbutton.Location = new System.Drawing.Point(52, 51);
            this.Redbutton.Name = "Redbutton";
            this.Redbutton.Size = new System.Drawing.Size(120, 48);
            this.Redbutton.TabIndex = 1;
            this.Redbutton.Text = "Открыть";
            this.Redbutton.UseVisualStyleBackColor = false;
            this.Redbutton.Click += new System.EventHandler(this.Redbutton_Click);
            // 
            // Creat
            // 
            this.Creat.BackColor = System.Drawing.Color.Transparent;
            this.Creat.Location = new System.Drawing.Point(52, 105);
            this.Creat.Name = "Creat";
            this.Creat.Size = new System.Drawing.Size(120, 48);
            this.Creat.TabIndex = 2;
            this.Creat.Text = "Создать";
            this.Creat.UseVisualStyleBackColor = false;
            this.Creat.Click += new System.EventHandler(this.Creat_Click);
            // 
            // Sozdatel
            // 
            this.Sozdatel.BackColor = System.Drawing.Color.Transparent;
            this.Sozdatel.Location = new System.Drawing.Point(52, 159);
            this.Sozdatel.Name = "Sozdatel";
            this.Sozdatel.Size = new System.Drawing.Size(120, 48);
            this.Sozdatel.TabIndex = 4;
            this.Sozdatel.Text = "О разработчике";
            this.Sozdatel.UseVisualStyleBackColor = false;
            this.Sozdatel.Click += new System.EventHandler(this.Sozdatel_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(52, 213);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 48);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // start_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 313);
            this.Controls.Add(this.Sozdatel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Creat);
            this.Controls.Add(this.Redbutton);
            this.Name = "start_menu";
            this.Text = "Приемная комиссия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.start_menu_FormClosing);
            this.Load += new System.EventHandler(this.start_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Redbutton;
        private System.Windows.Forms.Button Creat;
        private System.Windows.Forms.Button Sozdatel;
        private System.Windows.Forms.Button Exit;
    }
}

