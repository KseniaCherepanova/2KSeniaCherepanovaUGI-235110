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
    public partial class Form1 : Form
    {
      
           public SecondForm MySecondForm;
     public SourceForm Sourceform;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (MySecondForm == null)
            {
                MySecondForm = new SecondForm();
                MySecondForm.BasedForm = this;  
            
            }
          
            MySecondForm.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (MySecondForm == null)
                return;
            
            if(MySecondForm.Visible)
            {
                MySecondForm.Hide();
                hideButton.Text = "Отобразить форму";

            }  
            else
            {
                MySecondForm.Show();
            }    
        }

        private void openButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Question_Click(object sender, EventArgs e)
        {
            new DialogForm().ShowDialog();  
        }

        private void MDIButton_Click(object sender, EventArgs e)
        {
            if (Sourceform == null) 
                Sourceform = new SourceForm(); 
            Sourceform.Show();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SourceForm != null)
            {
                Sourceform.Close();
            }
                    
        }
    }
}
