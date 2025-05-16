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
    
    public partial class SourceForm : Form
    {
        int documentCounter = 0;

        public SourceForm()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Hide();
        }

        private void новыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = new documentForm2();
            document.MdiParent = this;
            document.Text = $ "Документ {++documentcForm2}";
            document.Show();

        }

        private void SourceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) 
                e.Cancel = true;
        }

      
    }
}
