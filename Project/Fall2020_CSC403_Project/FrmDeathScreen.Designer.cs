namespace Fall2020_CSC403_Project
{
    partial class FrmDeathScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuitGameBtn = new System.Windows.Forms.Button();
            this.RestrtLvlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Informal Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(203, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(641, 102);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "YOU DIED!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuitGameBtn
            // 
            this.QuitGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuitGameBtn.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitGameBtn.Location = new System.Drawing.Point(656, 262);
            this.QuitGameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitGameBtn.Name = "QuitGameBtn";
            this.QuitGameBtn.Size = new System.Drawing.Size(337, 139);
            this.QuitGameBtn.TabIndex = 1;
            this.QuitGameBtn.Text = "Quit Game";
            this.QuitGameBtn.UseVisualStyleBackColor = false;
            this.QuitGameBtn.Click += new System.EventHandler(this.QuitGameBtn_Click);
            // 
            // RestrtLvlBtn
            // 
            this.RestrtLvlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RestrtLvlBtn.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestrtLvlBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestrtLvlBtn.Location = new System.Drawing.Point(77, 262);
            this.RestrtLvlBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestrtLvlBtn.Name = "RestrtLvlBtn";
            this.RestrtLvlBtn.Size = new System.Drawing.Size(340, 139);
            this.RestrtLvlBtn.TabIndex = 2;
            this.RestrtLvlBtn.Text = "Restart Level";
            this.RestrtLvlBtn.UseVisualStyleBackColor = false;
            this.RestrtLvlBtn.Click += new System.EventHandler(this.RestrtLvlBtn_Click);
            // 
            // FrmDeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RestrtLvlBtn);
            this.Controls.Add(this.QuitGameBtn);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDeathScreen";
            this.Text = "FrmDeathScreen";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button QuitGameBtn;
        private System.Windows.Forms.Button RestrtLvlBtn;
    }
}