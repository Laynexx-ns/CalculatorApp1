namespace CalculatorApp1
{
    partial class bttminus
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
            this.bttsum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getnum1 = new System.Windows.Forms.Label();
            this.getnum2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.Label();
            this.resinf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttsum
            // 
            this.bttsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttsum.Location = new System.Drawing.Point(16, 51);
            this.bttsum.Name = "bttsum";
            this.bttsum.Size = new System.Drawing.Size(100, 100);
            this.bttsum.TabIndex = 0;
            this.bttsum.Text = "+";
            this.bttsum.UseVisualStyleBackColor = true;
            this.bttsum.Click += new System.EventHandler(this.bttsum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Результат";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // getnum1
            // 
            this.getnum1.AutoSize = true;
            this.getnum1.Location = new System.Drawing.Point(39, 35);
            this.getnum1.Name = "getnum1";
            this.getnum1.Size = new System.Drawing.Size(77, 13);
            this.getnum1.TabIndex = 3;
            this.getnum1.Text = "Первое число";
            // 
            // getnum2
            // 
            this.getnum2.AutoSize = true;
            this.getnum2.Location = new System.Drawing.Point(225, 35);
            this.getnum2.Name = "getnum2";
            this.getnum2.Size = new System.Drawing.Size(75, 13);
            this.getnum2.TabIndex = 4;
            this.getnum2.Text = "Второе число";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(188, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 26);
            this.textBox2.TabIndex = 6;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(184, 130);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(24, 24);
            this.res.TabIndex = 7;
            this.res.Text = "X";
            // 
            // resinf
            // 
            this.resinf.AutoSize = true;
            this.resinf.Location = new System.Drawing.Point(214, 138);
            this.resinf.Name = "resinf";
            this.resinf.Size = new System.Drawing.Size(43, 13);
            this.resinf.TabIndex = 8;
            this.resinf.Text = "1+1 = 2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(125, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(188, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttminus
            // 
            this.ClientSize = new System.Drawing.Size(349, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resinf);
            this.Controls.Add(this.res);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getnum2);
            this.Controls.Add(this.getnum1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttsum);
            this.Name = "bttminus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Label label4;
        
        private System.Windows.Forms.Button bttsum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label getnum1;
        private System.Windows.Forms.Label getnum2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label resinf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

