namespace task_3_17
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОчередьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxQu = new System.Windows.Forms.TextBox();
            this.textBoxNewQu = new System.Windows.Forms.TextBox();
            this.условиеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьОчередьToolStripMenuItem,
            this.добавитьЭлементToolStripMenuItem,
            this.условиеЗадачиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // создатьОчередьToolStripMenuItem
            // 
            this.создатьОчередьToolStripMenuItem.Name = "создатьОчередьToolStripMenuItem";
            this.создатьОчередьToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.создатьОчередьToolStripMenuItem.Text = "Создать очередь";
            this.создатьОчередьToolStripMenuItem.Click += new System.EventHandler(this.создатьОчередьToolStripMenuItem_Click);
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            this.добавитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 168);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(323, 211);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(120, 22);
            this.textBoxIn.TabIndex = 2;
            // 
            // textBoxQu
            // 
            this.textBoxQu.Location = new System.Drawing.Point(19, 265);
            this.textBoxQu.Name = "textBoxQu";
            this.textBoxQu.Size = new System.Drawing.Size(423, 22);
            this.textBoxQu.TabIndex = 3;
            // 
            // textBoxNewQu
            // 
            this.textBoxNewQu.Location = new System.Drawing.Point(18, 309);
            this.textBoxNewQu.Name = "textBoxNewQu";
            this.textBoxNewQu.Size = new System.Drawing.Size(423, 22);
            this.textBoxNewQu.TabIndex = 4;
            // 
            // условиеЗадачиToolStripMenuItem
            // 
            this.условиеЗадачиToolStripMenuItem.Name = "условиеЗадачиToolStripMenuItem";
            this.условиеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.условиеЗадачиToolStripMenuItem.Text = "Условие задачи";
            this.условиеЗадачиToolStripMenuItem.Click += new System.EventHandler(this.условиеЗадачиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.textBoxNewQu);
            this.Controls.Add(this.textBoxQu);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Добавление элемента в конец очереди";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОчередьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxQu;
        private System.Windows.Forms.TextBox textBoxNewQu;
        private System.Windows.Forms.ToolStripMenuItem условиеЗадачиToolStripMenuItem;
    }
}

