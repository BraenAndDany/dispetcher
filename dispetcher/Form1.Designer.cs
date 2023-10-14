namespace dispetcher
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.lblRAMBytes = new MetroFramework.Controls.MetroLabel();
            this.pRAMBytes = new System.Diagnostics.PerformanceCounter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboDisk = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(49, 60);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(596, 23);
            this.metroProgressBarCPU.TabIndex = 1;
            this.metroProgressBarCPU.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(52, 105);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(593, 23);
            this.metroProgressBarRAM.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "RAM:";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(651, 105);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 19);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0%";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(651, 60);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(27, 19);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "0%";
            // 
            // lblRAMBytes
            // 
            this.lblRAMBytes.AutoSize = true;
            this.lblRAMBytes.Location = new System.Drawing.Point(727, 105);
            this.lblRAMBytes.Name = "lblRAMBytes";
            this.lblRAMBytes.Size = new System.Drawing.Size(28, 19);
            this.lblRAMBytes.TabIndex = 6;
            this.lblRAMBytes.Text = "0/0";
            this.lblRAMBytes.Click += new System.EventHandler(this.lblRAMBytes_Click);
            // 
            // pRAMBytes
            // 
            this.pRAMBytes.CategoryName = "Memory";
            this.pRAMBytes.CounterName = "Committed Bytes";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboDisk
            // 
            this.cboDisk.AutoSize = true;
            this.cboDisk.Location = new System.Drawing.Point(5, 161);
            this.cboDisk.Name = "cboDisk";
            this.cboDisk.Size = new System.Drawing.Size(53, 19);
            this.cboDisk.TabIndex = 7;
            this.cboDisk.Text = "Disc C:\\";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "C:\\";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboDisk);
            this.Controls.Add(this.lblRAMBytes);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "la";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMBytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lblRAMBytes;
        private System.Diagnostics.PerformanceCounter pRAMBytes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel cboDisk;
        private System.Windows.Forms.TextBox textBox1;
    }
}

