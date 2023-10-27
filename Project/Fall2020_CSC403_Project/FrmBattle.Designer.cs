namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnLightAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.btnHeavyAttack = new System.Windows.Forms.Button();
            this.btnDodge = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.labelPotionRemain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLightAttack
            // 
            this.btnLightAttack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLightAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightAttack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLightAttack.Location = new System.Drawing.Point(73, 760);
            this.btnLightAttack.Margin = new System.Windows.Forms.Padding(6);
            this.btnLightAttack.Name = "btnLightAttack";
            this.btnLightAttack.Size = new System.Drawing.Size(256, 83);
            this.btnLightAttack.TabIndex = 2;
            this.btnLightAttack.Text = "Light Attack";
            this.btnLightAttack.UseVisualStyleBackColor = false;
            this.btnLightAttack.Click += new System.EventHandler(this.btnLightAttack_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(142, 115);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(452, 38);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(140, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1030, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 44);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(1032, 115);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(452, 38);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1560, 1083);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(6);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(60, 54);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(1030, 188);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(6);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(454, 510);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(140, 188);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(454, 510);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // btnHeavyAttack
            // 
            this.btnHeavyAttack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHeavyAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnHeavyAttack.Location = new System.Drawing.Point(399, 760);
            this.btnHeavyAttack.Name = "btnHeavyAttack";
            this.btnHeavyAttack.Size = new System.Drawing.Size(251, 83);
            this.btnHeavyAttack.TabIndex = 8;
            this.btnHeavyAttack.Text = "Heavy Attack";
            this.btnHeavyAttack.UseVisualStyleBackColor = false;
            this.btnHeavyAttack.Click += new System.EventHandler(this.btnHeavyAttack_Click);
            // 
            // btnDodge
            // 
            this.btnDodge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDodge.Location = new System.Drawing.Point(73, 872);
            this.btnDodge.Name = "btnDodge";
            this.btnDodge.Size = new System.Drawing.Size(256, 83);
            this.btnDodge.TabIndex = 9;
            this.btnDodge.Text = "Dodge";
            this.btnDodge.UseVisualStyleBackColor = false;
            this.btnDodge.Click += new System.EventHandler(this.btnDodge_Click);
            // 
            // btnFlee
            // 
            this.btnFlee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFlee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFlee.Location = new System.Drawing.Point(399, 872);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(251, 83);
            this.btnFlee.TabIndex = 10;
            this.btnFlee.Text = "Flee";
            this.btnFlee.UseVisualStyleBackColor = false;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsePotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnUsePotion.Location = new System.Drawing.Point(73, 996);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(256, 76);
            this.btnUsePotion.TabIndex = 11;
            this.btnUsePotion.Text = "Use Potion";
            this.btnUsePotion.UseVisualStyleBackColor = false;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // labelPotionRemain
            // 
            this.labelPotionRemain.AutoSize = true;
            this.labelPotionRemain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPotionRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelPotionRemain.Location = new System.Drawing.Point(37, 1093);
            this.labelPotionRemain.Name = "labelPotionRemain";
            this.labelPotionRemain.Size = new System.Drawing.Size(350, 44);
            this.labelPotionRemain.TabIndex = 12;
            this.labelPotionRemain.Text = "Potions Remaining:";
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1644, 1160);
            this.Controls.Add(this.labelPotionRemain);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLightAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnHeavyAttack);
            this.Controls.Add(this.btnDodge);
            this.Controls.Add(this.btnFlee);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnLightAttack;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Button btnHeavyAttack;
        private System.Windows.Forms.Button btnDodge;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Label labelPotionRemain;
    }
}