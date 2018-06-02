using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Даны четыре файла целых чисел разного размера с именами NameA, NameB, NameC и NameD. 
 * Создать новый файл с именем NameE, в котором чередовались бы элементы исходных файлов 
 * с одним и тем же номером (как в задании 16). 
 * "Лишние" элементы более длинных файлов в результирующий файл не записывать. 
 */
namespace task_1_2_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassFile fl = new ClassFile();
            fl.create_4_Files();
            string s = fl.file_4_toString();

            fl.makeMerge();

            s+= fl.FileToString("NameE");
            textBox1.Text = s;
            textBox1.Visible = true;

        }
    }
}
