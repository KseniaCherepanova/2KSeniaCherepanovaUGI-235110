using FormsForPractice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO; 

namespace FormsForPractice
{
    public partial class Form1 : Form
    {
        int pictureNumber = 7;


        //в паблик форме задаются начальные условия, которые будут сразу видны
        public Form1()
        {
          InitializeComponent();
            captionListBox.Items.Add("Заголовок");
            captionListBox.Items.Add("Сон");
            captionListBox.Items.Add("Счастье");
            captionListBox.Items.Add("Димон");

            captionListBox.SelectedIndex = 0;

            fontFamilyComboBox.Items.Add("Microsoft San Serif");
            fontFamilyComboBox.Items.Add("Times New Roman");
            fontFamilyComboBox.Items.Add("Consolas");

            fontFamilyComboBox.SelectedIndex = 0;

            SlideShowPictureBox.Load("pr2.jpg");

            openFileDialog1.Filter = "Обычный текст|*.txt|Форматированный текст|*.rtf";
        }

   

        private void InPutButton_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = textBox1.Text;
            InPutButton.Text = string.Empty;
        }

        private void ChangeFontStyle(object sender, EventArgs e)
        {
            var style = FontStyle.Regular;
            if (BoldCheckBox.Checked)
                style |= FontStyle.Bold;    
            if(ItalicCheckBox.Checked)
                style |= FontStyle.Italic;
            if (UnderlineCheckBox.Checked)
                style |= FontStyle.Underline;

            TitleLabel.Font = new Font(TitleLabel.Font, style);
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                var size = float.Parse(radioButton.Text.Split()[0]);
                TitleLabel.Font = new Font(TitleLabel.Font.FontFamily,
                    size,
                    TitleLabel.Font.Style);
            }
        }

        private void captionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleLabel.Text = captionListBox.SelectedItem.ToString();
        }

        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontFamily = fontFamilyComboBox.SelectedItem.ToString();
            TitleLabel.Font = new Font(fontFamily, 
                TitleLabel.Font.Size,
                TitleLabel.Font.Style
                );
        }


        private void ChangePicture(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                if (button.Text == ">>")
                {
                    pictureNumber++;
                }
                else
                {
                    pictureNumber--;
                }


                if (pictureNumber > 7)
                {
                    pictureNumber = 1;
                    progressBar1.Value = 0;
                }
                else if (pictureNumber < 1)
                {
                    pictureNumber = 7;
                }
                SlideShowPictureBox.Image = Resources.ResourceManager.GetObject("pic" + pictureNumber) as Image;
            }

        }

        private void StartingButton_Click(object sender, EventArgs e)
        {
            if (StartingButton.Text == "Пуск")
            {
                timer1.Enabled = true;
                StartingButton.Text = "Стоп";

            }
            else
            {
                timer1.Enabled= false;
                StartingButton.Text = "Пуск";
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value % 40 == 0)
                ChangePicture(BackButton, new EventArgs());

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;
            }

        }

        private void DiologButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                if (openFileDialog1.FilterIndex == 1)
                    richTextBox1.Text = File.ReadAllText(
                        openFileDialog1.FileName, Encoding.Default);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName);

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InPutButton_Click(InPutButton, new EventArgs());

        }
    }
}
