using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintFormApp
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        public Form1()
        {
            InitializeComponent();

            canvas = CreateGraphics();
        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
        }
    }
}
