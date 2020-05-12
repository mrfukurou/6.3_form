namespace WindowsFormsApp15
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
            this.Nn = new System.Windows.Forms.TextBox();
            this.Mm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nn
            // 
            this.Nn.Location = new System.Drawing.Point(230, 14);
            this.Nn.Name = "Nn";
            this.Nn.Size = new System.Drawing.Size(143, 22);
            this.Nn.TabIndex = 0;
            // 
            // Mm
            // 
            this.Mm.Location = new System.Drawing.Point(230, 42);
            this.Mm.Name = "Mm";
            this.Mm.Size = new System.Drawing.Size(143, 22);
            this.Mm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество столбцов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Определить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mas
            // 
            this.mas.Location = new System.Drawing.Point(19, 70);
            this.mas.Multiline = true;
            this.mas.Name = "mas";
            this.mas.ReadOnly = true;
            this.mas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mas.Size = new System.Drawing.Size(476, 166);
            this.mas.TabIndex = 5;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(19, 242);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(354, 52);
            this.rez.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mm);
            this.Controls.Add(this.Nn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nn;
        private System.Windows.Forms.TextBox Mm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mas;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button2;
    }
}

