namespace Fall2020_CSC403_Project
{
    partial class DifficultyForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "EASY\r\n\"I\'m a little baby... waaah\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.easyMode_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "NORMAL\r\n\"I want to experience the game as intended\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.normalMode_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "HARD\r\n\"I\'m a gamer\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.hardMode_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DifficultyForm";
            this.Text = "DifficultyForm";
            this.Load += new System.EventHandler(this.DifficultyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}