namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.chalgaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hipHopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Магазин за музика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Време";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chalgaToolStripMenuItem,
            this.hipHopToolStripMenuItem,
            this.rokToolStripMenuItem,
            this.jazToolStripMenuItem,
            this.technoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // chalgaToolStripMenuItem
            // 
            this.chalgaToolStripMenuItem.Name = "chalgaToolStripMenuItem";
            this.chalgaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.chalgaToolStripMenuItem.Text = "Чалга";
            // 
            // hipHopToolStripMenuItem
            // 
            this.hipHopToolStripMenuItem.Name = "hipHopToolStripMenuItem";
            this.hipHopToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hipHopToolStripMenuItem.Text = "Хип Хоп";
            // 
            // rokToolStripMenuItem
            // 
            this.rokToolStripMenuItem.Name = "rokToolStripMenuItem";
            this.rokToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.rokToolStripMenuItem.Text = "Рок";
            // 
            // jazToolStripMenuItem
            // 
            this.jazToolStripMenuItem.Name = "jazToolStripMenuItem";
            this.jazToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.jazToolStripMenuItem.Text = "Джаз";
            // 
            // technoToolStripMenuItem
            // 
            this.technoToolStripMenuItem.Name = "technoToolStripMenuItem";
            this.technoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.technoToolStripMenuItem.Text = "Техно";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem chalgaToolStripMenuItem;
        private ToolStripMenuItem hipHopToolStripMenuItem;
        private ToolStripMenuItem rokToolStripMenuItem;
        private ToolStripMenuItem jazToolStripMenuItem;
        private ToolStripMenuItem technoToolStripMenuItem;
    }
}