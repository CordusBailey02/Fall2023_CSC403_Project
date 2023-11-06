namespace Fall2020_CSC403_Project
{
    partial class FrmPause
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
            this.saveGameBtn = new System.Windows.Forms.Button();
            this.restartLvlBtn = new System.Windows.Forms.Button();
            this.quitGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Informal Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(215, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(377, 95);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "PAUSE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveGameBtn
            // 
            this.saveGameBtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGameBtn.Location = new System.Drawing.Point(327, 173);
            this.saveGameBtn.Name = "saveGameBtn";
            this.saveGameBtn.Size = new System.Drawing.Size(154, 50);
            this.saveGameBtn.TabIndex = 1;
            this.saveGameBtn.Text = "SAVE GAME";
            this.saveGameBtn.UseVisualStyleBackColor = true;
            this.saveGameBtn.Click += new System.EventHandler(this.saveGameBtn_Click);
            // 
            // restartLvlBtn
            // 
            this.restartLvlBtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLvlBtn.Location = new System.Drawing.Point(327, 262);
            this.restartLvlBtn.Name = "restartLvlBtn";
            this.restartLvlBtn.Size = new System.Drawing.Size(154, 54);
            this.restartLvlBtn.TabIndex = 2;
            this.restartLvlBtn.Text = "RESTART LEVEL";
            this.restartLvlBtn.UseVisualStyleBackColor = true;
            this.restartLvlBtn.Click += new System.EventHandler(this.restartLvlBtn_Click);
            // 
            // quitGameBtn
            // 
            this.quitGameBtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGameBtn.Location = new System.Drawing.Point(327, 355);
            this.quitGameBtn.Name = "quitGameBtn";
            this.quitGameBtn.Size = new System.Drawing.Size(154, 53);
            this.quitGameBtn.TabIndex = 3;
            this.quitGameBtn.Text = "QUIT GAME";
            this.quitGameBtn.UseVisualStyleBackColor = true;
            this.quitGameBtn.Click += new System.EventHandler(this.quitGameBtn_Click);
            // 
            // FrmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.quitGameBtn);
            this.Controls.Add(this.restartLvlBtn);
            this.Controls.Add(this.saveGameBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmPause";
            this.Text = "FrmPause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveGameBtn;
        private System.Windows.Forms.Button restartLvlBtn;
        private System.Windows.Forms.Button quitGameBtn;
    }
}