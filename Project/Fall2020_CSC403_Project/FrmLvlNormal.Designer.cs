namespace Fall2020_CSC403_Project
{
    partial class FrmLvlNormal
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
            this.components = new System.ComponentModel.Container();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.room3Panel = new System.Windows.Forms.Panel();
            this.room3Enemy1 = new System.Windows.Forms.PictureBox();
            this.toR4FromR3 = new System.Windows.Forms.PictureBox();
            this.fromR2ToR3 = new System.Windows.Forms.PictureBox();
            this.fromR0ToR3 = new System.Windows.Forms.PictureBox();
            this.room3Obstacle1 = new System.Windows.Forms.PictureBox();
            this.room3Obstacle2 = new System.Windows.Forms.PictureBox();
            this.room2Panel = new System.Windows.Forms.Panel();
            this.fromR1ToR2 = new System.Windows.Forms.PictureBox();
            this.room2Enemy1 = new System.Windows.Forms.PictureBox();
            this.toR3FromR2 = new System.Windows.Forms.PictureBox();
            this.room2Obstacle2 = new System.Windows.Forms.PictureBox();
            this.room2Obstacle1 = new System.Windows.Forms.PictureBox();
            this.room0Panel = new System.Windows.Forms.Panel();
            this.toR1FromR0 = new System.Windows.Forms.PictureBox();
            this.toR3FromR0 = new System.Windows.Forms.PictureBox();
            this.startRoomMessage = new System.Windows.Forms.Label();
            this.room1Panel = new System.Windows.Forms.Panel();
            this.room1Enemy4 = new System.Windows.Forms.PictureBox();
            this.room1Enemy3 = new System.Windows.Forms.PictureBox();
            this.room1Enemy2 = new System.Windows.Forms.PictureBox();
            this.room1Enemy1 = new System.Windows.Forms.PictureBox();
            this.toR2FromR1 = new System.Windows.Forms.PictureBox();
            this.room1Obstacle1 = new System.Windows.Forms.PictureBox();
            this.fromR0ToR1 = new System.Windows.Forms.PictureBox();
            this.room4Panel = new System.Windows.Forms.Panel();
            this.room4Obstacle1 = new System.Windows.Forms.PictureBox();
            this.toR5FromR4 = new System.Windows.Forms.PictureBox();
            this.fromR3ToR4 = new System.Windows.Forms.PictureBox();
            this.room5Panel = new System.Windows.Forms.Panel();
            this.room5Obstacle1 = new System.Windows.Forms.PictureBox();
            this.fromR4ToR5 = new System.Windows.Forms.PictureBox();
            this.transitionPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.miniMap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.room3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room3Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle2)).BeginInit();
            this.room2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromR1ToR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle1)).BeginInit();
            this.room0Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toR1FromR0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR0)).BeginInit();
            this.room1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR2FromR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR1)).BeginInit();
            this.room4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room4Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR5FromR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR3ToR4)).BeginInit();
            this.room5Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room5Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR4ToR5)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(304, 1074);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(108, 129);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 20);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(99, 33);
            this.lblInGameTime.TabIndex = 1;
            this.lblInGameTime.Text = "label1";
            // 
            // room3Panel
            // 
            this.room3Panel.BackColor = System.Drawing.Color.IndianRed;
            this.room3Panel.Controls.Add(this.room3Enemy1);
            this.room3Panel.Controls.Add(this.toR4FromR3);
            this.room3Panel.Controls.Add(this.fromR2ToR3);
            this.room3Panel.Controls.Add(this.fromR0ToR3);
            this.room3Panel.Controls.Add(this.room3Obstacle1);
            this.room3Panel.Controls.Add(this.room3Obstacle2);
            this.room3Panel.Location = new System.Drawing.Point(4862, 1656);
            this.room3Panel.Name = "room3Panel";
            this.room3Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room3Panel.TabIndex = 7;
            // 
            // room3Enemy1
            // 
            this.room3Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room3Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room3Enemy1.Location = new System.Drawing.Point(1442, 785);
            this.room3Enemy1.Name = "room3Enemy1";
            this.room3Enemy1.Size = new System.Drawing.Size(100, 166);
            this.room3Enemy1.TabIndex = 12;
            this.room3Enemy1.TabStop = false;
            // 
            // toR4FromR3
            // 
            this.toR4FromR3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR4FromR3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR4FromR3.Location = new System.Drawing.Point(1904, 311);
            this.toR4FromR3.Name = "toR4FromR3";
            this.toR4FromR3.Size = new System.Drawing.Size(100, 50);
            this.toR4FromR3.TabIndex = 6;
            this.toR4FromR3.TabStop = false;
            // 
            // fromR2ToR3
            // 
            this.fromR2ToR3.BackColor = System.Drawing.Color.Transparent;
            this.fromR2ToR3.Location = new System.Drawing.Point(533, 1027);
            this.fromR2ToR3.Name = "fromR2ToR3";
            this.fromR2ToR3.Size = new System.Drawing.Size(100, 50);
            this.fromR2ToR3.TabIndex = 5;
            this.fromR2ToR3.TabStop = false;
            // 
            // fromR0ToR3
            // 
            this.fromR0ToR3.BackColor = System.Drawing.Color.Transparent;
            this.fromR0ToR3.Location = new System.Drawing.Point(118, 610);
            this.fromR0ToR3.Name = "fromR0ToR3";
            this.fromR0ToR3.Size = new System.Drawing.Size(100, 50);
            this.fromR0ToR3.TabIndex = 3;
            this.fromR0ToR3.TabStop = false;
            // 
            // room3Obstacle1
            // 
            this.room3Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room3Obstacle1.Location = new System.Drawing.Point(1527, 424);
            this.room3Obstacle1.Name = "room3Obstacle1";
            this.room3Obstacle1.Size = new System.Drawing.Size(296, 182);
            this.room3Obstacle1.TabIndex = 0;
            this.room3Obstacle1.TabStop = false;
            // 
            // room3Obstacle2
            // 
            this.room3Obstacle2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room3Obstacle2.Location = new System.Drawing.Point(412, 224);
            this.room3Obstacle2.Name = "room3Obstacle2";
            this.room3Obstacle2.Size = new System.Drawing.Size(296, 182);
            this.room3Obstacle2.TabIndex = 1;
            this.room3Obstacle2.TabStop = false;
            // 
            // room2Panel
            // 
            this.room2Panel.BackColor = System.Drawing.Color.IndianRed;
            this.room2Panel.Controls.Add(this.fromR1ToR2);
            this.room2Panel.Controls.Add(this.room2Enemy1);
            this.room2Panel.Controls.Add(this.toR3FromR2);
            this.room2Panel.Controls.Add(this.room2Obstacle2);
            this.room2Panel.Controls.Add(this.room2Obstacle1);
            this.room2Panel.Location = new System.Drawing.Point(4862, 3021);
            this.room2Panel.Name = "room2Panel";
            this.room2Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room2Panel.TabIndex = 8;
            // 
            // fromR1ToR2
            // 
            this.fromR1ToR2.Location = new System.Drawing.Point(181, 530);
            this.fromR1ToR2.Name = "fromR1ToR2";
            this.fromR1ToR2.Size = new System.Drawing.Size(100, 50);
            this.fromR1ToR2.TabIndex = 8;
            this.fromR1ToR2.TabStop = false;
            // 
            // room2Enemy1
            // 
            this.room2Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room2Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room2Enemy1.Location = new System.Drawing.Point(516, 698);
            this.room2Enemy1.Name = "room2Enemy1";
            this.room2Enemy1.Size = new System.Drawing.Size(100, 166);
            this.room2Enemy1.TabIndex = 7;
            this.room2Enemy1.TabStop = false;
            // 
            // toR3FromR2
            // 
            this.toR3FromR2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR3FromR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR3FromR2.Location = new System.Drawing.Point(533, 68);
            this.toR3FromR2.Name = "toR3FromR2";
            this.toR3FromR2.Size = new System.Drawing.Size(100, 50);
            this.toR3FromR2.TabIndex = 5;
            this.toR3FromR2.TabStop = false;
            // 
            // room2Obstacle2
            // 
            this.room2Obstacle2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room2Obstacle2.Location = new System.Drawing.Point(879, 924);
            this.room2Obstacle2.Name = "room2Obstacle2";
            this.room2Obstacle2.Size = new System.Drawing.Size(296, 182);
            this.room2Obstacle2.TabIndex = 2;
            this.room2Obstacle2.TabStop = false;
            // 
            // room2Obstacle1
            // 
            this.room2Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room2Obstacle1.Location = new System.Drawing.Point(1338, 698);
            this.room2Obstacle1.Name = "room2Obstacle1";
            this.room2Obstacle1.Size = new System.Drawing.Size(296, 182);
            this.room2Obstacle1.TabIndex = 1;
            this.room2Obstacle1.TabStop = false;
            // 
            // room0Panel
            // 
            this.room0Panel.BackColor = System.Drawing.Color.Gray;
            this.room0Panel.Controls.Add(this.toR1FromR0);
            this.room0Panel.Controls.Add(this.toR3FromR0);
            this.room0Panel.Controls.Add(this.startRoomMessage);
            this.room0Panel.Location = new System.Drawing.Point(2502, 1656);
            this.room0Panel.Name = "room0Panel";
            this.room0Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room0Panel.TabIndex = 9;
            // 
            // toR1FromR0
            // 
            this.toR1FromR0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR1FromR0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR1FromR0.Location = new System.Drawing.Point(1592, 829);
            this.toR1FromR0.Name = "toR1FromR0";
            this.toR1FromR0.Size = new System.Drawing.Size(100, 122);
            this.toR1FromR0.TabIndex = 2;
            this.toR1FromR0.TabStop = false;
            // 
            // toR3FromR0
            // 
            this.toR3FromR0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR3FromR0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR3FromR0.Location = new System.Drawing.Point(562, 699);
            this.toR3FromR0.Name = "toR3FromR0";
            this.toR3FromR0.Size = new System.Drawing.Size(100, 122);
            this.toR3FromR0.TabIndex = 1;
            this.toR3FromR0.TabStop = false;
            // 
            // startRoomMessage
            // 
            this.startRoomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRoomMessage.Location = new System.Drawing.Point(97, 153);
            this.startRoomMessage.Name = "startRoomMessage";
            this.startRoomMessage.Size = new System.Drawing.Size(1810, 73);
            this.startRoomMessage.TabIndex = 0;
            this.startRoomMessage.Text = "Welcome to the Normal Level! Proceed to the door when ready...";
            // 
            // room1Panel
            // 
            this.room1Panel.BackColor = System.Drawing.Color.Maroon;
            this.room1Panel.Controls.Add(this.room1Enemy4);
            this.room1Panel.Controls.Add(this.room1Enemy3);
            this.room1Panel.Controls.Add(this.room1Enemy2);
            this.room1Panel.Controls.Add(this.room1Enemy1);
            this.room1Panel.Controls.Add(this.toR2FromR1);
            this.room1Panel.Controls.Add(this.room1Obstacle1);
            this.room1Panel.Controls.Add(this.fromR0ToR1);
            this.room1Panel.Location = new System.Drawing.Point(2502, 3019);
            this.room1Panel.Name = "room1Panel";
            this.room1Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room1Panel.TabIndex = 11;
            // 
            // room1Enemy4
            // 
            this.room1Enemy4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room1Enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy4.Location = new System.Drawing.Point(1304, 635);
            this.room1Enemy4.Name = "room1Enemy4";
            this.room1Enemy4.Size = new System.Drawing.Size(100, 166);
            this.room1Enemy4.TabIndex = 11;
            this.room1Enemy4.TabStop = false;
            // 
            // room1Enemy3
            // 
            this.room1Enemy3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room1Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy3.Location = new System.Drawing.Point(221, 161);
            this.room1Enemy3.Name = "room1Enemy3";
            this.room1Enemy3.Size = new System.Drawing.Size(100, 166);
            this.room1Enemy3.TabIndex = 10;
            this.room1Enemy3.TabStop = false;
            // 
            // room1Enemy2
            // 
            this.room1Enemy2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room1Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy2.Location = new System.Drawing.Point(888, 716);
            this.room1Enemy2.Name = "room1Enemy2";
            this.room1Enemy2.Size = new System.Drawing.Size(100, 166);
            this.room1Enemy2.TabIndex = 9;
            this.room1Enemy2.TabStop = false;
            // 
            // room1Enemy1
            // 
            this.room1Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room1Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy1.Location = new System.Drawing.Point(549, 483);
            this.room1Enemy1.Name = "room1Enemy1";
            this.room1Enemy1.Size = new System.Drawing.Size(100, 166);
            this.room1Enemy1.TabIndex = 8;
            this.room1Enemy1.TabStop = false;
            // 
            // toR2FromR1
            // 
            this.toR2FromR1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR2FromR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR2FromR1.Location = new System.Drawing.Point(1905, 522);
            this.toR2FromR1.Name = "toR2FromR1";
            this.toR2FromR1.Size = new System.Drawing.Size(100, 50);
            this.toR2FromR1.TabIndex = 6;
            this.toR2FromR1.TabStop = false;
            // 
            // room1Obstacle1
            // 
            this.room1Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room1Obstacle1.Location = new System.Drawing.Point(99, 881);
            this.room1Obstacle1.Name = "room1Obstacle1";
            this.room1Obstacle1.Size = new System.Drawing.Size(296, 182);
            this.room1Obstacle1.TabIndex = 2;
            this.room1Obstacle1.TabStop = false;
            // 
            // fromR0ToR1
            // 
            this.fromR0ToR1.Location = new System.Drawing.Point(1592, 124);
            this.fromR0ToR1.Name = "fromR0ToR1";
            this.fromR0ToR1.Size = new System.Drawing.Size(100, 50);
            this.fromR0ToR1.TabIndex = 0;
            this.fromR0ToR1.TabStop = false;
            // 
            // room4Panel
            // 
            this.room4Panel.BackColor = System.Drawing.Color.Lime;
            this.room4Panel.Controls.Add(this.room4Obstacle1);
            this.room4Panel.Controls.Add(this.toR5FromR4);
            this.room4Panel.Controls.Add(this.fromR3ToR4);
            this.room4Panel.Location = new System.Drawing.Point(7126, 1656);
            this.room4Panel.Name = "room4Panel";
            this.room4Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room4Panel.TabIndex = 12;
            // 
            // room4Obstacle1
            // 
            this.room4Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room4Obstacle1.Location = new System.Drawing.Point(1659, 743);
            this.room4Obstacle1.Name = "room4Obstacle1";
            this.room4Obstacle1.Size = new System.Drawing.Size(296, 182);
            this.room4Obstacle1.TabIndex = 2;
            this.room4Obstacle1.TabStop = false;
            // 
            // toR5FromR4
            // 
            this.toR5FromR4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.toR5FromR4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR5FromR4.Location = new System.Drawing.Point(912, 1018);
            this.toR5FromR4.Name = "toR5FromR4";
            this.toR5FromR4.Size = new System.Drawing.Size(100, 50);
            this.toR5FromR4.TabIndex = 1;
            this.toR5FromR4.TabStop = false;
            // 
            // fromR3ToR4
            // 
            this.fromR3ToR4.Location = new System.Drawing.Point(126, 299);
            this.fromR3ToR4.Name = "fromR3ToR4";
            this.fromR3ToR4.Size = new System.Drawing.Size(151, 62);
            this.fromR3ToR4.TabIndex = 0;
            this.fromR3ToR4.TabStop = false;
            // 
            // room5Panel
            // 
            this.room5Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.room5Panel.Controls.Add(this.room5Obstacle1);
            this.room5Panel.Controls.Add(this.fromR4ToR5);
            this.room5Panel.Location = new System.Drawing.Point(7124, 3021);
            this.room5Panel.Name = "room5Panel";
            this.room5Panel.Size = new System.Drawing.Size(2110, 1175);
            this.room5Panel.TabIndex = 13;
            // 
            // room5Obstacle1
            // 
            this.room5Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room5Obstacle1.Location = new System.Drawing.Point(539, 414);
            this.room5Obstacle1.Name = "room5Obstacle1";
            this.room5Obstacle1.Size = new System.Drawing.Size(717, 394);
            this.room5Obstacle1.TabIndex = 2;
            this.room5Obstacle1.TabStop = false;
            // 
            // fromR4ToR5
            // 
            this.fromR4ToR5.Location = new System.Drawing.Point(914, 122);
            this.fromR4ToR5.Name = "fromR4ToR5";
            this.fromR4ToR5.Size = new System.Drawing.Size(100, 50);
            this.fromR4ToR5.TabIndex = 0;
            this.fromR4ToR5.TabStop = false;
            // 
            // transitionPanel
            // 
            this.transitionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.transitionPanel.Location = new System.Drawing.Point(0, 0);
            this.transitionPanel.Name = "transitionPanel";
            this.transitionPanel.Size = new System.Drawing.Size(2576, 1404);
            this.transitionPanel.TabIndex = 14;
            this.transitionPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Controls.Add(this.miniMap);
            this.sidePanel.Location = new System.Drawing.Point(2227, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(349, 1404);
            this.sidePanel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 77);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // miniMap
            // 
            this.miniMap.BackColor = System.Drawing.Color.White;
            this.miniMap.Location = new System.Drawing.Point(12, 30);
            this.miniMap.Name = "miniMap";
            this.miniMap.Size = new System.Drawing.Size(325, 325);
            this.miniMap.TabIndex = 1;
            // 
            // FrmLvlNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(3076, 1879);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.room5Panel);
            this.Controls.Add(this.room4Panel);
            this.Controls.Add(this.room1Panel);
            this.Controls.Add(this.room0Panel);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.room2Panel);
            this.Controls.Add(this.room3Panel);
            this.Controls.Add(this.transitionPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLvlNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLvlNormal";
            this.Load += new System.EventHandler(this.FrmLvlNormal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLvlNormal_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLvlNormal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.room3Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room3Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle2)).EndInit();
            this.room2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromR1ToR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle1)).EndInit();
            this.room0Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toR1FromR0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR0)).EndInit();
            this.room1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR2FromR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR1)).EndInit();
            this.room4Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room4Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR5FromR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR3ToR4)).EndInit();
            this.room5Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room5Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR4ToR5)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Panel room3Panel;
        private System.Windows.Forms.Panel room2Panel;
        private System.Windows.Forms.PictureBox room3Obstacle2;
        private System.Windows.Forms.PictureBox room3Obstacle1;
        private System.Windows.Forms.PictureBox room2Obstacle1;
        private System.Windows.Forms.PictureBox room2Obstacle2;
        private System.Windows.Forms.Panel room0Panel;
        private System.Windows.Forms.Panel room1Panel;
        private System.Windows.Forms.Panel room4Panel;
        private System.Windows.Forms.Panel room5Panel;
        private System.Windows.Forms.Label startRoomMessage;
        private System.Windows.Forms.PictureBox toR3FromR0;
        private System.Windows.Forms.PictureBox fromR0ToR3;
        private System.Windows.Forms.PictureBox toR3FromR2;
        private System.Windows.Forms.PictureBox fromR0ToR1;
        private System.Windows.Forms.PictureBox toR5FromR4;
        private System.Windows.Forms.PictureBox fromR3ToR4;
        private System.Windows.Forms.PictureBox fromR4ToR5;
        private System.Windows.Forms.PictureBox room1Obstacle1;
        private System.Windows.Forms.PictureBox room4Obstacle1;
        private System.Windows.Forms.Panel transitionPanel;
        private System.Windows.Forms.PictureBox room5Obstacle1;
        private System.Windows.Forms.PictureBox room2Enemy1;
        private System.Windows.Forms.PictureBox toR1FromR0;
        private System.Windows.Forms.PictureBox fromR2ToR3;
        private System.Windows.Forms.PictureBox fromR1ToR2;
        private System.Windows.Forms.PictureBox toR2FromR1;
        private System.Windows.Forms.PictureBox toR4FromR3;
        private System.Windows.Forms.PictureBox room1Enemy1;
        private System.Windows.Forms.PictureBox room1Enemy4;
        private System.Windows.Forms.PictureBox room1Enemy3;
        private System.Windows.Forms.PictureBox room1Enemy2;
        private System.Windows.Forms.PictureBox room3Enemy1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel miniMap;
    }
}