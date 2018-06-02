namespace task_5_17
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMake1 = new System.Windows.Forms.Button();
            this.textBoxTree1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMake2 = new System.Windows.Forms.Button();
            this.textBoxTree2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonComp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonMake1);
            this.panel1.Controls.Add(this.textBoxTree1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 469);
            this.panel1.TabIndex = 0;
            // 
            // buttonMake1
            // 
            this.buttonMake1.Location = new System.Drawing.Point(222, 19);
            this.buttonMake1.Name = "buttonMake1";
            this.buttonMake1.Size = new System.Drawing.Size(106, 35);
            this.buttonMake1.TabIndex = 2;
            this.buttonMake1.Text = "Построить";
            this.buttonMake1.UseVisualStyleBackColor = true;
            this.buttonMake1.Click += new System.EventHandler(this.buttonMake1_Click);
            // 
            // textBoxTree1
            // 
            this.textBoxTree1.Location = new System.Drawing.Point(19, 60);
            this.textBoxTree1.Multiline = true;
            this.textBoxTree1.Name = "textBoxTree1";
            this.textBoxTree1.Size = new System.Drawing.Size(252, 376);
            this.textBoxTree1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.buttonMake2);
            this.panel2.Controls.Add(this.textBoxTree2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(376, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 469);
            this.panel2.TabIndex = 1;
            // 
            // buttonMake2
            // 
            this.buttonMake2.Location = new System.Drawing.Point(216, 17);
            this.buttonMake2.Name = "buttonMake2";
            this.buttonMake2.Size = new System.Drawing.Size(105, 37);
            this.buttonMake2.TabIndex = 2;
            this.buttonMake2.Text = "Построить";
            this.buttonMake2.UseVisualStyleBackColor = true;
            this.buttonMake2.Click += new System.EventHandler(this.buttonMake2_Click);
            // 
            // textBoxTree2
            // 
            this.textBoxTree2.Location = new System.Drawing.Point(20, 60);
            this.textBoxTree2.Multiline = true;
            this.textBoxTree2.Name = "textBoxTree2";
            this.textBoxTree2.Size = new System.Drawing.Size(261, 379);
            this.textBoxTree2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 22);
            this.textBox2.TabIndex = 0;
            // 
            // buttonComp
            // 
            this.buttonComp.Location = new System.Drawing.Point(263, 487);
            this.buttonComp.Name = "buttonComp";
            this.buttonComp.Size = new System.Drawing.Size(181, 29);
            this.buttonComp.TabIndex = 2;
            this.buttonComp.Text = "Сравнить деревья";
            this.buttonComp.UseVisualStyleBackColor = true;
            this.buttonComp.Click += new System.EventHandler(this.buttonComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 526);
            this.Controls.Add(this.buttonComp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Сравнение двух деревьев";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMake1;
        private System.Windows.Forms.TextBox textBoxTree1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMake2;
        private System.Windows.Forms.TextBox textBoxTree2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonComp;
    }
}

