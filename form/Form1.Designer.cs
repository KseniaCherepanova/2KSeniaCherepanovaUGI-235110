namespace form
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
            this.openButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.MDIButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(187, 332);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(427, 76);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Открыть форму ";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(187, 117);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(426, 64);
            this.hideButton.TabIndex = 1;
            this.hideButton.Text = "скрыть форму";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(186, 35);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(427, 76);
            this.Question.TabIndex = 0;
            this.Question.Text = "Открыть вопрос";
            this.Question.UseVisualStyleBackColor = true;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // MDIButton
            // 
            this.MDIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDIButton.Location = new System.Drawing.Point(186, 210);
            this.MDIButton.Name = "MDIButton";
            this.MDIButton.Size = new System.Drawing.Size(427, 76);
            this.MDIButton.TabIndex = 0;
            this.MDIButton.Text = "документы ";
            this.MDIButton.UseVisualStyleBackColor = true;
            this.MDIButton.Click += new System.EventHandler(this.MDIButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 145);
            this.button1.TabIndex = 2;
            this.button1.Text = "закрыть документы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.MDIButton);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.openButton_Click);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.Button MDIButton;
        private System.Windows.Forms.Button button1;
    }
}

