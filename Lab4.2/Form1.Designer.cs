namespace Lab4._2
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
            this.nUD_1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Vivod = new System.Windows.Forms.Button();
            this.pB_1 = new System.Windows.Forms.ProgressBar();
            this.tB_2 = new System.Windows.Forms.TrackBar();
            this.TB_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_2)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD_1
            // 
            this.nUD_1.Location = new System.Drawing.Point(13, 13);
            this.nUD_1.Name = "nUD_1";
            this.nUD_1.Size = new System.Drawing.Size(120, 20);
            this.nUD_1.TabIndex = 0;
            this.nUD_1.ValueChanged += new System.EventHandler(this.nUD_1_ValueChanged);
            // 
            // btn_Vivod
            // 
            this.btn_Vivod.Location = new System.Drawing.Point(139, 12);
            this.btn_Vivod.Name = "btn_Vivod";
            this.btn_Vivod.Size = new System.Drawing.Size(100, 23);
            this.btn_Vivod.TabIndex = 1;
            this.btn_Vivod.Text = "Вывод";
            this.btn_Vivod.UseVisualStyleBackColor = true;
            this.btn_Vivod.Click += new System.EventHandler(this.btn_Vivod_Click);
            // 
            // pB_1
            // 
            this.pB_1.Location = new System.Drawing.Point(139, 41);
            this.pB_1.Name = "pB_1";
            this.pB_1.Size = new System.Drawing.Size(100, 23);
            this.pB_1.TabIndex = 2;
            // 
            // tB_2
            // 
            this.tB_2.Location = new System.Drawing.Point(13, 70);
            this.tB_2.Maximum = 100;
            this.tB_2.Name = "tB_2";
            this.tB_2.Size = new System.Drawing.Size(226, 45);
            this.tB_2.TabIndex = 3;
            this.tB_2.Scroll += new System.EventHandler(this.tB_2_Scroll);
            // 
            // TB_1
            // 
            this.TB_1.Location = new System.Drawing.Point(13, 44);
            this.TB_1.Name = "TB_1";
            this.TB_1.Size = new System.Drawing.Size(120, 20);
            this.TB_1.TabIndex = 4;
            this.TB_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_1);
            this.Controls.Add(this.tB_2);
            this.Controls.Add(this.pB_1);
            this.Controls.Add(this.btn_Vivod);
            this.Controls.Add(this.nUD_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_1;
        private System.Windows.Forms.Button btn_Vivod;
        private System.Windows.Forms.ProgressBar pB_1;
        private System.Windows.Forms.TrackBar tB_2;
        private System.Windows.Forms.TextBox TB_1;
    }
}

