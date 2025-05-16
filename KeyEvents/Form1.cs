using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEvents
{
   
    public partial class Form1 : Form
    {
        int bufferSize = 25;
        Queue<string> lines = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
             KeyPreview = true;
            label1.Text = string.Empty;
        }

        private void UpdateReport(string message)
        {
            lines.Enqueue(message);
            if (lines.Count > bufferSize)
                lines.Dequeue();
            var text = string.Empty;

            foreach (string line in lines)
                text += line + "\n";

            label1.Text = text;   
           

        }

   

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) =>
            UpdateReport("PreviewKeyDown: " + e.KeyCode);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateReport("KeyDown: " + e.KeyCode);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) => UpdateReport("KeyPress: " + e.KeyChar + "код" + (int)e.KeyChar);

        private void Form1_KeyUp(object sender, KeyEventArgs e) => UpdateReport("KeyUp: " + e.KeyCode);

    }
}
