using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_obj = new OpenFileDialog();
            if (ofd_obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                //Select Image
               Image img = Image.FromFile(ofd_obj.FileName);
                    pictureBox1.Image= img;
            }
        }
    }
}
