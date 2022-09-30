
namespace Vigener
{
    partial class Form1
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
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.cryptBox = new System.Windows.Forms.RichTextBox();
            this.decryptBox = new System.Windows.Forms.RichTextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.Enbutton = new System.Windows.Forms.Button();
            this.Debutton = new System.Windows.Forms.Button();
            this.eng = new System.Windows.Forms.RadioButton();
            this.rus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(12, 164);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(197, 247);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // cryptBox
            // 
            this.cryptBox.BackColor = System.Drawing.Color.White;
            this.cryptBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptBox.Location = new System.Drawing.Point(334, 164);
            this.cryptBox.Name = "cryptBox";
            this.cryptBox.Size = new System.Drawing.Size(198, 247);
            this.cryptBox.TabIndex = 1;
            this.cryptBox.Text = "";
            // 
            // decryptBox
            // 
            this.decryptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.decryptBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptBox.Location = new System.Drawing.Point(659, 163);
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.ReadOnly = true;
            this.decryptBox.Size = new System.Drawing.Size(198, 247);
            this.decryptBox.TabIndex = 2;
            this.decryptBox.Text = "";
            // 
            // keyBox
            // 
            this.keyBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyBox.Location = new System.Drawing.Point(215, 177);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(113, 26);
            this.keyBox.TabIndex = 3;
            this.keyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyBox_KeyPress);
            // 
            // Enbutton
            // 
            this.Enbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enbutton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enbutton.Location = new System.Drawing.Point(216, 227);
            this.Enbutton.Name = "Enbutton";
            this.Enbutton.Size = new System.Drawing.Size(112, 28);
            this.Enbutton.TabIndex = 4;
            this.Enbutton.Text = "Зашифровать";
            this.Enbutton.UseVisualStyleBackColor = true;
            this.Enbutton.Click += new System.EventHandler(this.Enbutton_Click);
            // 
            // Debutton
            // 
            this.Debutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Debutton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Debutton.Location = new System.Drawing.Point(536, 228);
            this.Debutton.Name = "Debutton";
            this.Debutton.Size = new System.Drawing.Size(117, 27);
            this.Debutton.TabIndex = 5;
            this.Debutton.Text = "Расшифровать";
            this.Debutton.UseVisualStyleBackColor = true;
            this.Debutton.Click += new System.EventHandler(this.Debutton_Click);
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng.Location = new System.Drawing.Point(29, 86);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(74, 24);
            this.eng.TabIndex = 7;
            this.eng.TabStop = true;
            this.eng.Text = "English";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.eng_CheckedChanged);
            // 
            // rus
            // 
            this.rus.AutoSize = true;
            this.rus.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus.Location = new System.Drawing.Point(29, 55);
            this.rus.Name = "rus";
            this.rus.Size = new System.Drawing.Size(80, 24);
            this.rus.TabIndex = 7;
            this.rus.TabStop = true;
            this.rus.Text = "Русский";
            this.rus.UseVisualStyleBackColor = true;
            this.rus.CheckedChanged += new System.EventHandler(this.rus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите исходный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(367, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Криптограмма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(672, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Расшифрованный текст:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(215, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите ключ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(363, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Шифр Виженера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выберете язык:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(867, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Debutton);
            this.Controls.Add(this.Enbutton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.decryptBox);
            this.Controls.Add(this.cryptBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Шифр Виженера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox cryptBox;
        private System.Windows.Forms.RichTextBox decryptBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button Enbutton;
        private System.Windows.Forms.Button Debutton;
        private System.Windows.Forms.RadioButton eng;
        private System.Windows.Forms.RadioButton rus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

