namespace Fall2020_CSC403_Project
{
    partial class CharacterSelect
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
            this.PicBlack = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picYellow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "PICK A RANGER";
            // 
            // PicBlack
            // 
            this.PicBlack.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Black_Ranger_Idle_Fight;
            this.PicBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBlack.Location = new System.Drawing.Point(42, 132);
            this.PicBlack.Name = "PicBlack";
            this.PicBlack.Size = new System.Drawing.Size(151, 238);
            this.PicBlack.TabIndex = 1;
            this.PicBlack.TabStop = false;
            this.PicBlack.Click += new System.EventHandler(this.PicBlack_Click);
            // 
            // picBlue
            // 
            this.picBlue.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Blue_Ranger_Idle_Fight;
            this.picBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlue.Location = new System.Drawing.Point(429, 132);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(166, 238);
            this.picBlue.TabIndex = 2;
            this.picBlue.TabStop = false;
            this.picBlue.Click += new System.EventHandler(this.picBlue_Click);
            // 
            // picYellow
            // 
            this.picYellow.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Yellow_Ranger_Idle_Fight;
            this.picYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picYellow.Location = new System.Drawing.Point(242, 132);
            this.picYellow.Name = "picYellow";
            this.picYellow.Size = new System.Drawing.Size(149, 238);
            this.picYellow.TabIndex = 3;
            this.picYellow.TabStop = false;
            this.picYellow.Click += new System.EventHandler(this.picYellow_Click);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.picYellow);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.PicBlack);
            this.Controls.Add(this.label1);
            this.Name = "CharacterSelect";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBlack;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picYellow;
    }
}