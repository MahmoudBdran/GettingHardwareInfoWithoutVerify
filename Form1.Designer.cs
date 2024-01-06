namespace gettingHardwareInfo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cpu_tb = new System.Windows.Forms.TextBox();
            this.Motherboard_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hard_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reload_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cpu_ID";
            // 
            // cpu_tb
            // 
            this.cpu_tb.Location = new System.Drawing.Point(229, 62);
            this.cpu_tb.Name = "cpu_tb";
            this.cpu_tb.Size = new System.Drawing.Size(293, 20);
            this.cpu_tb.TabIndex = 3;
            // 
            // Motherboard_tb
            // 
            this.Motherboard_tb.Location = new System.Drawing.Point(229, 120);
            this.Motherboard_tb.Name = "Motherboard_tb";
            this.Motherboard_tb.Size = new System.Drawing.Size(293, 20);
            this.Motherboard_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MotherBoardID";
            // 
            // Hard_tb
            // 
            this.Hard_tb.Location = new System.Drawing.Point(229, 190);
            this.Hard_tb.Name = "Hard_tb";
            this.Hard_tb.Size = new System.Drawing.Size(293, 20);
            this.Hard_tb.TabIndex = 7;
            this.Hard_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HardDiskDriveSerial";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // reload_btn
            // 
            this.reload_btn.Location = new System.Drawing.Point(712, 13);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(75, 23);
            this.reload_btn.TabIndex = 13;
            this.reload_btn.Text = "Reload";
            this.reload_btn.UseVisualStyleBackColor = true;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reload_btn);
            this.Controls.Add(this.Hard_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Motherboard_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpu_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpu_tb;
        private System.Windows.Forms.TextBox Motherboard_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hard_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reload_btn;
    }
}

