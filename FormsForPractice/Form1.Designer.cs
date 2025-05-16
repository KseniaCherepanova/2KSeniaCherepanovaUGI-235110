namespace FormsForPractice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InPutLabel = new System.Windows.Forms.Label();
            this.InPutButton = new System.Windows.Forms.Button();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.ItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.UnderlineCheckBox = new System.Windows.Forms.CheckBox();
            this.Size12RadioButton = new System.Windows.Forms.RadioButton();
            this.Size14RadioButton = new System.Windows.Forms.RadioButton();
            this.Size24RadioButton = new System.Windows.Forms.RadioButton();
            this.captionListBox = new System.Windows.Forms.ListBox();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.SlideShowPictureBox = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartingButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DiologButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(161, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "ЗАГОЛОВОК";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.InPutButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.InPutButton_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // InPutLabel
            // 
            this.InPutLabel.AutoSize = true;
            this.InPutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InPutLabel.Location = new System.Drawing.Point(24, 153);
            this.InPutLabel.Name = "InPutLabel";
            this.InPutLabel.Size = new System.Drawing.Size(238, 20);
            this.InPutLabel.TabIndex = 2;
            this.InPutLabel.Text = "введите текст пожалуйста";
            // 
            // InPutButton
            // 
            this.InPutButton.Location = new System.Drawing.Point(24, 238);
            this.InPutButton.Name = "InPutButton";
            this.InPutButton.Size = new System.Drawing.Size(75, 23);
            this.InPutButton.TabIndex = 3;
            this.InPutButton.Text = "ввод";
            this.InPutButton.UseVisualStyleBackColor = true;
            this.InPutButton.Click += new System.EventHandler(this.InPutButton_Click);
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldCheckBox.Location = new System.Drawing.Point(28, 295);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(206, 24);
            this.BoldCheckBox.TabIndex = 4;
            this.BoldCheckBox.Text = "Полужирный шрифт ";
            this.BoldCheckBox.UseVisualStyleBackColor = false;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // ItalicCheckBox
            // 
            this.ItalicCheckBox.AutoSize = true;
            this.ItalicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicCheckBox.Location = new System.Drawing.Point(28, 325);
            this.ItalicCheckBox.Name = "ItalicCheckBox";
            this.ItalicCheckBox.Size = new System.Drawing.Size(89, 24);
            this.ItalicCheckBox.TabIndex = 4;
            this.ItalicCheckBox.Text = "Курсив";
            this.ItalicCheckBox.UseVisualStyleBackColor = false;
            this.ItalicCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // UnderlineCheckBox
            // 
            this.UnderlineCheckBox.AutoSize = true;
            this.UnderlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderlineCheckBox.Location = new System.Drawing.Point(28, 355);
            this.UnderlineCheckBox.Name = "UnderlineCheckBox";
            this.UnderlineCheckBox.Size = new System.Drawing.Size(160, 24);
            this.UnderlineCheckBox.TabIndex = 4;
            this.UnderlineCheckBox.Text = "Подчеркнутый ";
            this.UnderlineCheckBox.UseVisualStyleBackColor = false;
            this.UnderlineCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // Size12RadioButton
            // 
            this.Size12RadioButton.AutoSize = true;
            this.Size12RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size12RadioButton.Location = new System.Drawing.Point(253, 298);
            this.Size12RadioButton.Name = "Size12RadioButton";
            this.Size12RadioButton.Size = new System.Drawing.Size(120, 24);
            this.Size12RadioButton.TabIndex = 5;
            this.Size12RadioButton.Text = "12 пунктов";
            this.Size12RadioButton.UseVisualStyleBackColor = true;
            this.Size12RadioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // Size14RadioButton
            // 
            this.Size14RadioButton.AutoSize = true;
            this.Size14RadioButton.Checked = true;
            this.Size14RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size14RadioButton.Location = new System.Drawing.Point(253, 328);
            this.Size14RadioButton.Name = "Size14RadioButton";
            this.Size14RadioButton.Size = new System.Drawing.Size(120, 24);
            this.Size14RadioButton.TabIndex = 5;
            this.Size14RadioButton.TabStop = true;
            this.Size14RadioButton.Text = "14 пунктов";
            this.Size14RadioButton.UseVisualStyleBackColor = true;
            this.Size14RadioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // Size24RadioButton
            // 
            this.Size24RadioButton.AutoSize = true;
            this.Size24RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size24RadioButton.Location = new System.Drawing.Point(253, 358);
            this.Size24RadioButton.Name = "Size24RadioButton";
            this.Size24RadioButton.Size = new System.Drawing.Size(110, 24);
            this.Size24RadioButton.TabIndex = 5;
            this.Size24RadioButton.Text = "24 пункта";
            this.Size24RadioButton.UseVisualStyleBackColor = true;
            this.Size24RadioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // captionListBox
            // 
            this.captionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionListBox.FormattingEnabled = true;
            this.captionListBox.ItemHeight = 20;
            this.captionListBox.Location = new System.Drawing.Point(423, 66);
            this.captionListBox.Name = "captionListBox";
            this.captionListBox.Size = new System.Drawing.Size(346, 64);
            this.captionListBox.TabIndex = 6;
            this.captionListBox.SelectedIndexChanged += new System.EventHandler(this.captionListBox_SelectedIndexChanged);
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontFamilyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontFamilyComboBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(253, 187);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(270, 28);
            this.fontFamilyComboBox.TabIndex = 7;
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // SlideShowPictureBox
            // 
            this.SlideShowPictureBox.Location = new System.Drawing.Point(199, 429);
            this.SlideShowPictureBox.Name = "SlideShowPictureBox";
            this.SlideShowPictureBox.Size = new System.Drawing.Size(345, 154);
            this.SlideShowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlideShowPictureBox.TabIndex = 8;
            this.SlideShowPictureBox.TabStop = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardButton.Location = new System.Drawing.Point(573, 456);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(50, 100);
            this.ForwardButton.TabIndex = 9;
            this.ForwardButton.Text = ">>";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ChangePicture);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(115, 456);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(50, 100);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ChangePicture);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 606);
            this.progressBar1.Maximum = 240;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 31);
            this.progressBar1.Step = 4;
            this.progressBar1.TabIndex = 10;
            // 
            // StartingButton
            // 
            this.StartingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartingButton.Location = new System.Drawing.Point(670, 560);
            this.StartingButton.Name = "StartingButton";
            this.StartingButton.Size = new System.Drawing.Size(75, 40);
            this.StartingButton.TabIndex = 11;
            this.StartingButton.Text = "пуск";
            this.StartingButton.UseVisualStyleBackColor = true;
            this.StartingButton.Click += new System.EventHandler(this.StartingButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DiologButton
            // 
            this.DiologButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiologButton.Location = new System.Drawing.Point(59, 662);
            this.DiologButton.Name = "DiologButton";
            this.DiologButton.Size = new System.Drawing.Size(203, 79);
            this.DiologButton.TabIndex = 12;
            this.DiologButton.Text = "Загрузить текст ";
            this.DiologButton.UseVisualStyleBackColor = true;
            this.DiologButton.Click += new System.EventHandler(this.DiologButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 662);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 212);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DiologButton);
            this.Controls.Add(this.StartingButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.SlideShowPictureBox);
            this.Controls.Add(this.fontFamilyComboBox);
            this.Controls.Add(this.captionListBox);
            this.Controls.Add(this.Size24RadioButton);
            this.Controls.Add(this.Size14RadioButton);
            this.Controls.Add(this.Size12RadioButton);
            this.Controls.Add(this.UnderlineCheckBox);
            this.Controls.Add(this.ItalicCheckBox);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.InPutButton);
            this.Controls.Add(this.InPutLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Элементы управления";
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InPutLabel;
        private System.Windows.Forms.Button InPutButton;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.CheckBox ItalicCheckBox;
        private System.Windows.Forms.CheckBox UnderlineCheckBox;
        private System.Windows.Forms.RadioButton Size12RadioButton;
        private System.Windows.Forms.RadioButton Size14RadioButton;
        private System.Windows.Forms.RadioButton Size24RadioButton;
        private System.Windows.Forms.ListBox captionListBox;
        private System.Windows.Forms.ComboBox fontFamilyComboBox;
        private System.Windows.Forms.PictureBox SlideShowPictureBox;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DiologButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

