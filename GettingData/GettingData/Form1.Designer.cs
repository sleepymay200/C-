﻿namespace строки
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.second = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "вхождения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(12, 44);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(276, 29);
            this.first.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(12, 79);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(223, 29);
            this.second.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 143);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(223, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Извлечение";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "торговая марка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "повтор";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Метод String.Format";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Пустота";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = " Переворачиваем строку при помощи C#";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 346);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = " Замена длинного пути многоточием";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 375);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 40);
            this.button9.TabIndex = 12;
            this.button9.Text = "  Соединение строк при помощи StringBuilder";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(241, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Получение текущей даты";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(565, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 498);
            this.listBox1.TabIndex = 14;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(241, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(223, 36);
            this.button11.TabIndex = 15;
            this.button11.Text = "Вывод даты и времени в разных форматах";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(241, 185);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(223, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Добавление 7 дней к текущей дате";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(241, 214);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(223, 23);
            this.button13.TabIndex = 17;
            this.button13.Text = "Собственный метод DateDiff";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(241, 243);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(223, 23);
            this.button14.TabIndex = 18;
            this.button14.Text = "Проверка на високосный год";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(241, 272);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(223, 39);
            this.button15.TabIndex = 19;
            this.button15.Text = "Преобразование числа в шестнадцатеричное значение";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(241, 317);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(223, 39);
            this.button16.TabIndex = 20;
            this.button16.Text = "Перевод числа в двоичную систему счисления";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(241, 362);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(223, 53);
            this.button17.TabIndex = 21;
            this.button17.Text = "Перевод числа в различные системы счисления";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 529);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

