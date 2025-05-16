using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class SecondForm : Form
    {
        public Form1 BasedForm;
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BasedForm.MySecondForm = null;  
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
