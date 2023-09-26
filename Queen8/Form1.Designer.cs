namespace Queen8
{
    partial class Queen8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cellCheckTxt = new System.Windows.Forms.Label();
            this.cleaning = new System.Windows.Forms.Button();
            this.Auto = new System.Windows.Forms.Button();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.numQueenTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Peru;
            this.groupBox1.Controls.Add(this.cellCheckTxt);
            this.groupBox1.Controls.Add(this.cleaning);
            this.groupBox1.Controls.Add(this.Auto);
            this.groupBox1.Controls.Add(this.checkBoxAuto);
            this.groupBox1.Controls.Add(this.numQueenTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(320, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queen8";
            // 
            // cellCheckTxt
            // 
            this.cellCheckTxt.AutoSize = true;
            this.cellCheckTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cellCheckTxt.Location = new System.Drawing.Point(118, 81);
            this.cellCheckTxt.Name = "cellCheckTxt";
            this.cellCheckTxt.Size = new System.Drawing.Size(45, 20);
            this.cellCheckTxt.TabIndex = 6;
            this.cellCheckTxt.Text = "_ | _";
            // 
            // cleaning
            // 
            this.cleaning.BackColor = System.Drawing.Color.SandyBrown;
            this.cleaning.Enabled = false;
            this.cleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleaning.ForeColor = System.Drawing.Color.Red;
            this.cleaning.Location = new System.Drawing.Point(72, 156);
            this.cleaning.Name = "cleaning";
            this.cleaning.Size = new System.Drawing.Size(97, 44);
            this.cleaning.TabIndex = 4;
            this.cleaning.Text = "Очистить";
            this.cleaning.UseVisualStyleBackColor = false;
            this.cleaning.Click += new System.EventHandler(this.button3_Click);
            // 
            // Auto
            // 
            this.Auto.BackColor = System.Drawing.Color.SandyBrown;
            this.Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Auto.Location = new System.Drawing.Point(122, 206);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(100, 70);
            this.Auto.TabIndex = 3;
            this.Auto.Text = "Авто";
            this.Auto.UseVisualStyleBackColor = false;
            this.Auto.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(15, 113);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(208, 28);
            this.checkBoxAuto.TabIndex = 2;
            this.checkBoxAuto.Text = "Авто расстановка";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numQueenTxt
            // 
            this.numQueenTxt.AutoSize = true;
            this.numQueenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numQueenTxt.Location = new System.Drawing.Point(118, 41);
            this.numQueenTxt.Name = "numQueenTxt";
            this.numQueenTxt.Size = new System.Drawing.Size(79, 20);
            this.numQueenTxt.TabIndex = 1;
            this.numQueenTxt.Text = "1 ферзь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Итог:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ставим:";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.SandyBrown;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Lime;
            this.Start.Location = new System.Drawing.Point(15, 206);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(101, 70);
            this.Start.TabIndex = 0;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Queen8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Queen8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queen8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label numQueenTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer autoTimer;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.Button Auto;
        private System.Windows.Forms.Button cleaning;
        private System.Windows.Forms.Label cellCheckTxt;
        private System.Windows.Forms.Label label3;
    }
}

