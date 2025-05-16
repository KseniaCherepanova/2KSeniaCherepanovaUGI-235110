namespace form
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы любите кошек?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yesButton.Location = new System.Drawing.Point(60, 142);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(112, 53);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "да";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noButton.Location = new System.Drawing.Point(286, 144);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(114, 53);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "нет";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 362);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Name = "DialogForm";
            this.Text = "вопрос";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}