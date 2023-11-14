namespace Fall2020_CSC403_Project
{
    partial class FrmLvlEasy
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
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.room1Panel = new System.Windows.Forms.Panel();
            this.room1Enemy2 = new System.Windows.Forms.PictureBox();
            this.room1Enemy1 = new System.Windows.Forms.PictureBox();
            this.fromR0ToR1 = new System.Windows.Forms.PictureBox();
            this.room1Obstacle1 = new System.Windows.Forms.PictureBox();
            this.toR2FromR1 = new System.Windows.Forms.PictureBox();
            this.room1Obstacle2 = new System.Windows.Forms.PictureBox();
            this.room2Panel = new System.Windows.Forms.Panel();
            this.room2Enemy1 = new System.Windows.Forms.PictureBox();
            this.toR3FromR2 = new System.Windows.Forms.PictureBox();
            this.toR5FromR2 = new System.Windows.Forms.PictureBox();
            this.fromR1ToR2 = new System.Windows.Forms.PictureBox();
            this.room2Obstacle2 = new System.Windows.Forms.PictureBox();
            this.room2Obstacle1 = new System.Windows.Forms.PictureBox();
            this.room0Panel = new System.Windows.Forms.Panel();
            this.toR1FromR0 = new System.Windows.Forms.PictureBox();
            this.startRoomMessage = new System.Windows.Forms.Label();
            this.room5Panel = new System.Windows.Forms.Panel();
            this.room5Enemy2 = new System.Windows.Forms.PictureBox();
            this.room5Enemy1 = new System.Windows.Forms.PictureBox();
            this.room5Obstacle1 = new System.Windows.Forms.PictureBox();
            this.toR4FromR5 = new System.Windows.Forms.PictureBox();
            this.fromR2ToR5 = new System.Windows.Forms.PictureBox();
            this.room3Panel = new System.Windows.Forms.Panel();
            this.room3Obstacle1 = new System.Windows.Forms.PictureBox();
            this.toR4FromR3 = new System.Windows.Forms.PictureBox();
            this.fromR2ToR3 = new System.Windows.Forms.PictureBox();
            this.room4Panel = new System.Windows.Forms.Panel();
            this.room4Obstacle1 = new System.Windows.Forms.PictureBox();
            this.fromR5ToR4 = new System.Windows.Forms.PictureBox();
            this.fromR3ToR4 = new System.Windows.Forms.PictureBox();
            this.transitionPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.miniMap = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.room1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR2FromR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle2)).BeginInit();
            this.room2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room2Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR5FromR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR1ToR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle1)).BeginInit();
            this.room0Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toR1FromR0)).BeginInit();
            this.room5Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room5Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR5)).BeginInit();
            this.room3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR3)).BeginInit();
            this.room4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room4Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR5ToR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR3ToR4)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
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
            this.lblInGameTime.Location = new System.Drawing.Point(6, 10);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(52, 18);
            this.lblInGameTime.TabIndex = 1;
            this.lblInGameTime.Text = "label1";
            // 
            // room1Panel
            // 
            this.room1Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room1Panel.Controls.Add(this.room1Enemy2);
            this.room1Panel.Controls.Add(this.room1Enemy1);
            this.room1Panel.Controls.Add(this.fromR0ToR1);
            this.room1Panel.Controls.Add(this.room1Obstacle1);
            this.room1Panel.Controls.Add(this.toR2FromR1);
            this.room1Panel.Controls.Add(this.room1Obstacle2);
            this.room1Panel.Location = new System.Drawing.Point(2431, 861);
            this.room1Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room1Panel.Name = "room1Panel";
            this.room1Panel.Size = new System.Drawing.Size(1055, 611);
            this.room1Panel.TabIndex = 7;
            // 
            // room1Enemy2
            // 
            this.room1Enemy2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Grinch;
            this.room1Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy2.Location = new System.Drawing.Point(640, 80);
            this.room1Enemy2.Name = "room1Enemy2";
            this.room1Enemy2.Size = new System.Drawing.Size(110, 128);
            this.room1Enemy2.TabIndex = 5;
            this.room1Enemy2.TabStop = false;
            // 
            // room1Enemy1
            // 
            this.room1Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room1Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1Enemy1.Location = new System.Drawing.Point(516, 249);
            this.room1Enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.room1Enemy1.Name = "room1Enemy1";
            this.room1Enemy1.Size = new System.Drawing.Size(50, 86);
            this.room1Enemy1.TabIndex = 4;
            this.room1Enemy1.TabStop = false;
            // 
            // fromR0ToR1
            // 
            this.fromR0ToR1.BackColor = System.Drawing.Color.Transparent;
            this.fromR0ToR1.Location = new System.Drawing.Point(232, 408);
            this.fromR0ToR1.Margin = new System.Windows.Forms.Padding(2);
            this.fromR0ToR1.Name = "fromR0ToR1";
            this.fromR0ToR1.Size = new System.Drawing.Size(50, 26);
            this.fromR0ToR1.TabIndex = 3;
            this.fromR0ToR1.TabStop = false;
            // 
            // room1Obstacle1
            // 
            this.room1Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room1Obstacle1.Location = new System.Drawing.Point(764, 220);
            this.room1Obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.room1Obstacle1.Name = "room1Obstacle1";
            this.room1Obstacle1.Size = new System.Drawing.Size(148, 95);
            this.room1Obstacle1.TabIndex = 0;
            this.room1Obstacle1.TabStop = false;
            // 
            // toR2FromR1
            // 
            this.toR2FromR1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR2FromR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR2FromR1.Location = new System.Drawing.Point(656, 470);
            this.toR2FromR1.Margin = new System.Windows.Forms.Padding(2);
            this.toR2FromR1.Name = "toR2FromR1";
            this.toR2FromR1.Size = new System.Drawing.Size(50, 61);
            this.toR2FromR1.TabIndex = 2;
            this.toR2FromR1.TabStop = false;
            // 
            // room1Obstacle2
            // 
            this.room1Obstacle2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room1Obstacle2.Location = new System.Drawing.Point(206, 116);
            this.room1Obstacle2.Margin = new System.Windows.Forms.Padding(2);
            this.room1Obstacle2.Name = "room1Obstacle2";
            this.room1Obstacle2.Size = new System.Drawing.Size(148, 95);
            this.room1Obstacle2.TabIndex = 1;
            this.room1Obstacle2.TabStop = false;
            // 
            // room2Panel
            // 
            this.room2Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room2Panel.Controls.Add(this.room2Enemy1);
            this.room2Panel.Controls.Add(this.toR3FromR2);
            this.room2Panel.Controls.Add(this.toR5FromR2);
            this.room2Panel.Controls.Add(this.fromR1ToR2);
            this.room2Panel.Controls.Add(this.room2Obstacle2);
            this.room2Panel.Controls.Add(this.room2Obstacle1);
            this.room2Panel.Location = new System.Drawing.Point(2431, 1571);
            this.room2Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room2Panel.Name = "room2Panel";
            this.room2Panel.Size = new System.Drawing.Size(1055, 611);
            this.room2Panel.TabIndex = 8;
            // 
            // room2Enemy1
            // 
            this.room2Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room2Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room2Enemy1.Location = new System.Drawing.Point(908, 363);
            this.room2Enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.room2Enemy1.Name = "room2Enemy1";
            this.room2Enemy1.Size = new System.Drawing.Size(50, 86);
            this.room2Enemy1.TabIndex = 7;
            this.room2Enemy1.TabStop = false;
            // 
            // toR3FromR2
            // 
            this.toR3FromR2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR3FromR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR3FromR2.Location = new System.Drawing.Point(282, 462);
            this.toR3FromR2.Margin = new System.Windows.Forms.Padding(2);
            this.toR3FromR2.Name = "toR3FromR2";
            this.toR3FromR2.Size = new System.Drawing.Size(50, 55);
            this.toR3FromR2.TabIndex = 6;
            this.toR3FromR2.TabStop = false;
            // 
            // toR5FromR2
            // 
            this.toR5FromR2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR5FromR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR5FromR2.Location = new System.Drawing.Point(47, 242);
            this.toR5FromR2.Margin = new System.Windows.Forms.Padding(2);
            this.toR5FromR2.Name = "toR5FromR2";
            this.toR5FromR2.Size = new System.Drawing.Size(50, 54);
            this.toR5FromR2.TabIndex = 5;
            this.toR5FromR2.TabStop = false;
            // 
            // fromR1ToR2
            // 
            this.fromR1ToR2.Location = new System.Drawing.Point(733, 87);
            this.fromR1ToR2.Margin = new System.Windows.Forms.Padding(2);
            this.fromR1ToR2.Name = "fromR1ToR2";
            this.fromR1ToR2.Size = new System.Drawing.Size(50, 26);
            this.fromR1ToR2.TabIndex = 4;
            this.fromR1ToR2.TabStop = false;
            // 
            // room2Obstacle2
            // 
            this.room2Obstacle2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room2Obstacle2.Location = new System.Drawing.Point(440, 480);
            this.room2Obstacle2.Margin = new System.Windows.Forms.Padding(2);
            this.room2Obstacle2.Name = "room2Obstacle2";
            this.room2Obstacle2.Size = new System.Drawing.Size(148, 95);
            this.room2Obstacle2.TabIndex = 2;
            this.room2Obstacle2.TabStop = false;
            // 
            // room2Obstacle1
            // 
            this.room2Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room2Obstacle1.Location = new System.Drawing.Point(669, 363);
            this.room2Obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.room2Obstacle1.Name = "room2Obstacle1";
            this.room2Obstacle1.Size = new System.Drawing.Size(148, 95);
            this.room2Obstacle1.TabIndex = 1;
            this.room2Obstacle1.TabStop = false;
            // 
            // room0Panel
            // 
            this.room0Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room0Panel.Controls.Add(this.toR1FromR0);
            this.room0Panel.Controls.Add(this.startRoomMessage);
            this.room0Panel.Location = new System.Drawing.Point(1251, 861);
            this.room0Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room0Panel.Name = "room0Panel";
            this.room0Panel.Size = new System.Drawing.Size(1055, 611);
            this.room0Panel.TabIndex = 9;
            // 
            // toR1FromR0
            // 
            this.toR1FromR0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR1FromR0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR1FromR0.Location = new System.Drawing.Point(427, 431);
            this.toR1FromR0.Margin = new System.Windows.Forms.Padding(2);
            this.toR1FromR0.Name = "toR1FromR0";
            this.toR1FromR0.Size = new System.Drawing.Size(50, 63);
            this.toR1FromR0.TabIndex = 1;
            this.toR1FromR0.TabStop = false;
            // 
            // startRoomMessage
            // 
            this.startRoomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRoomMessage.Location = new System.Drawing.Point(48, 80);
            this.startRoomMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startRoomMessage.Name = "startRoomMessage";
            this.startRoomMessage.Size = new System.Drawing.Size(905, 38);
            this.startRoomMessage.TabIndex = 0;
            this.startRoomMessage.Text = "Welcome to the Easy Level! Proceed to the door when ready...";
            // 
            // room5Panel
            // 
            this.room5Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room5Panel.Controls.Add(this.room5Enemy2);
            this.room5Panel.Controls.Add(this.room5Enemy1);
            this.room5Panel.Controls.Add(this.room5Obstacle1);
            this.room5Panel.Controls.Add(this.toR4FromR5);
            this.room5Panel.Controls.Add(this.fromR2ToR5);
            this.room5Panel.Location = new System.Drawing.Point(1251, 1570);
            this.room5Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room5Panel.Name = "room5Panel";
            this.room5Panel.Size = new System.Drawing.Size(1055, 611);
            this.room5Panel.TabIndex = 11;
            // 
            // room5Enemy2
            // 
            this.room5Enemy2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.room5Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room5Enemy2.Location = new System.Drawing.Point(502, 262);
            this.room5Enemy2.Margin = new System.Windows.Forms.Padding(2);
            this.room5Enemy2.Name = "room5Enemy2";
            this.room5Enemy2.Size = new System.Drawing.Size(50, 86);
            this.room5Enemy2.TabIndex = 10;
            this.room5Enemy2.TabStop = false;
            // 
            // room5Enemy1
            // 
            this.room5Enemy1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.room5Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room5Enemy1.Location = new System.Drawing.Point(203, 249);
            this.room5Enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.room5Enemy1.Name = "room5Enemy1";
            this.room5Enemy1.Size = new System.Drawing.Size(50, 86);
            this.room5Enemy1.TabIndex = 8;
            this.room5Enemy1.TabStop = false;
            // 
            // room5Obstacle1
            // 
            this.room5Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room5Obstacle1.Location = new System.Drawing.Point(50, 458);
            this.room5Obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.room5Obstacle1.Name = "room5Obstacle1";
            this.room5Obstacle1.Size = new System.Drawing.Size(148, 95);
            this.room5Obstacle1.TabIndex = 2;
            this.room5Obstacle1.TabStop = false;
            // 
            // toR4FromR5
            // 
            this.toR4FromR5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR4FromR5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR4FromR5.Location = new System.Drawing.Point(791, 464);
            this.toR4FromR5.Margin = new System.Windows.Forms.Padding(2);
            this.toR4FromR5.Name = "toR4FromR5";
            this.toR4FromR5.Size = new System.Drawing.Size(50, 54);
            this.toR4FromR5.TabIndex = 1;
            this.toR4FromR5.TabStop = false;
            // 
            // fromR2ToR5
            // 
            this.fromR2ToR5.Location = new System.Drawing.Point(916, 271);
            this.fromR2ToR5.Margin = new System.Windows.Forms.Padding(2);
            this.fromR2ToR5.Name = "fromR2ToR5";
            this.fromR2ToR5.Size = new System.Drawing.Size(50, 26);
            this.fromR2ToR5.TabIndex = 0;
            this.fromR2ToR5.TabStop = false;
            // 
            // room3Panel
            // 
            this.room3Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room3Panel.Controls.Add(this.room3Obstacle1);
            this.room3Panel.Controls.Add(this.toR4FromR3);
            this.room3Panel.Controls.Add(this.fromR2ToR3);
            this.room3Panel.Location = new System.Drawing.Point(2432, 2282);
            this.room3Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room3Panel.Name = "room3Panel";
            this.room3Panel.Size = new System.Drawing.Size(1055, 611);
            this.room3Panel.TabIndex = 12;
            // 
            // room3Obstacle1
            // 
            this.room3Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room3Obstacle1.Location = new System.Drawing.Point(830, 386);
            this.room3Obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.room3Obstacle1.Name = "room3Obstacle1";
            this.room3Obstacle1.Size = new System.Drawing.Size(148, 95);
            this.room3Obstacle1.TabIndex = 2;
            this.room3Obstacle1.TabStop = false;
            // 
            // toR4FromR3
            // 
            this.toR4FromR3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Door;
            this.toR4FromR3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toR4FromR3.Location = new System.Drawing.Point(96, 249);
            this.toR4FromR3.Margin = new System.Windows.Forms.Padding(2);
            this.toR4FromR3.Name = "toR4FromR3";
            this.toR4FromR3.Size = new System.Drawing.Size(50, 58);
            this.toR4FromR3.TabIndex = 1;
            this.toR4FromR3.TabStop = false;
            // 
            // fromR2ToR3
            // 
            this.fromR2ToR3.Location = new System.Drawing.Point(276, 62);
            this.fromR2ToR3.Margin = new System.Windows.Forms.Padding(2);
            this.fromR2ToR3.Name = "fromR2ToR3";
            this.fromR2ToR3.Size = new System.Drawing.Size(76, 32);
            this.fromR2ToR3.TabIndex = 0;
            this.fromR2ToR3.TabStop = false;
            // 
            // room4Panel
            // 
            this.room4Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.room4Panel.Controls.Add(this.room4Obstacle1);
            this.room4Panel.Controls.Add(this.fromR5ToR4);
            this.room4Panel.Controls.Add(this.fromR3ToR4);
            this.room4Panel.Location = new System.Drawing.Point(1251, 2284);
            this.room4Panel.Margin = new System.Windows.Forms.Padding(2);
            this.room4Panel.Name = "room4Panel";
            this.room4Panel.Size = new System.Drawing.Size(1055, 611);
            this.room4Panel.TabIndex = 13;
            // 
            // room4Obstacle1
            // 
            this.room4Obstacle1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.room4Obstacle1.Location = new System.Drawing.Point(270, 215);
            this.room4Obstacle1.Margin = new System.Windows.Forms.Padding(2);
            this.room4Obstacle1.Name = "room4Obstacle1";
            this.room4Obstacle1.Size = new System.Drawing.Size(358, 205);
            this.room4Obstacle1.TabIndex = 2;
            this.room4Obstacle1.TabStop = false;
            // 
            // fromR5ToR4
            // 
            this.fromR5ToR4.Location = new System.Drawing.Point(750, 75);
            this.fromR5ToR4.Margin = new System.Windows.Forms.Padding(2);
            this.fromR5ToR4.Name = "fromR5ToR4";
            this.fromR5ToR4.Size = new System.Drawing.Size(50, 26);
            this.fromR5ToR4.TabIndex = 1;
            this.fromR5ToR4.TabStop = false;
            // 
            // fromR3ToR4
            // 
            this.fromR3ToR4.Location = new System.Drawing.Point(890, 267);
            this.fromR3ToR4.Margin = new System.Windows.Forms.Padding(2);
            this.fromR3ToR4.Name = "fromR3ToR4";
            this.fromR3ToR4.Size = new System.Drawing.Size(50, 26);
            this.fromR3ToR4.TabIndex = 0;
            this.fromR3ToR4.TabStop = false;
            // 
            // transitionPanel
            // 
            this.transitionPanel.BackColor = System.Drawing.Color.Silver;
            this.transitionPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.transitionPanel.Location = new System.Drawing.Point(0, 0);
            this.transitionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.transitionPanel.Name = "transitionPanel";
            this.transitionPanel.Size = new System.Drawing.Size(1288, 730);
            this.transitionPanel.TabIndex = 14;
            this.transitionPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Controls.Add(this.miniMap);
            this.sidePanel.Location = new System.Drawing.Point(1114, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(174, 730);
            this.sidePanel.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miniMap
            // 
            this.miniMap.Location = new System.Drawing.Point(6, 16);
            this.miniMap.Margin = new System.Windows.Forms.Padding(2);
            this.miniMap.Name = "miniMap";
            this.miniMap.Size = new System.Drawing.Size(162, 169);
            this.miniMap.TabIndex = 1;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(152, 558);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 67);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // FrmLvlEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.transitionPanel);
            this.Controls.Add(this.room4Panel);
            this.Controls.Add(this.room3Panel);
            this.Controls.Add(this.room5Panel);
            this.Controls.Add(this.room0Panel);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.room2Panel);
            this.Controls.Add(this.room1Panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLvlEasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLvlEasy";
            this.Load += new System.EventHandler(this.FrmLvlEasy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLvlEasy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLvlEasy_KeyUp);
            this.room1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR0ToR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR2FromR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1Obstacle2)).EndInit();
            this.room2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room2Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR3FromR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR5FromR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR1ToR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2Obstacle1)).EndInit();
            this.room0Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toR1FromR0)).EndInit();
            this.room5Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room5Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room5Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR5)).EndInit();
            this.room3Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room3Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toR4FromR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR2ToR3)).EndInit();
            this.room4Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room4Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR5ToR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromR3ToR4)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Panel room1Panel;
        private System.Windows.Forms.Panel room2Panel;
        private System.Windows.Forms.PictureBox room1Obstacle2;
        private System.Windows.Forms.PictureBox room1Obstacle1;
        private System.Windows.Forms.PictureBox room2Obstacle1;
        private System.Windows.Forms.PictureBox toR2FromR1;
        private System.Windows.Forms.PictureBox room2Obstacle2;
        private System.Windows.Forms.Panel room0Panel;
        private System.Windows.Forms.Panel room5Panel;
        private System.Windows.Forms.Panel room3Panel;
        private System.Windows.Forms.Panel room4Panel;
        private System.Windows.Forms.Label startRoomMessage;
        private System.Windows.Forms.PictureBox toR1FromR0;
        private System.Windows.Forms.PictureBox fromR0ToR1;
        private System.Windows.Forms.PictureBox fromR1ToR2;
        private System.Windows.Forms.PictureBox toR5FromR2;
        private System.Windows.Forms.PictureBox fromR2ToR5;
        private System.Windows.Forms.PictureBox toR3FromR2;
        private System.Windows.Forms.PictureBox toR4FromR5;
        private System.Windows.Forms.PictureBox toR4FromR3;
        private System.Windows.Forms.PictureBox fromR2ToR3;
        private System.Windows.Forms.PictureBox fromR5ToR4;
        private System.Windows.Forms.PictureBox fromR3ToR4;
        private System.Windows.Forms.PictureBox room5Obstacle1;
        private System.Windows.Forms.PictureBox room3Obstacle1;
        private System.Windows.Forms.PictureBox room1Enemy1;
        private System.Windows.Forms.Panel transitionPanel;
        private System.Windows.Forms.PictureBox room4Obstacle1;
        private System.Windows.Forms.PictureBox room2Enemy1;
        private System.Windows.Forms.PictureBox room5Enemy1;
        private System.Windows.Forms.PictureBox room5Enemy2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel miniMap;
        private System.Windows.Forms.PictureBox room1Enemy2;
    }
}