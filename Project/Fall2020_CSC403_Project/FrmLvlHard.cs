using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLvlHard : Form
    {
        List<string> playerMovements = new List<string>();
        private Player player;
        private FrmInventory inventory;

        private Potion lesserPotion;
        private Potion normalPotion;
        private Potion greaterPotion;

        private NPC[] roomPotions;
        private PictureBox[] roomPotionsP;
        private int collPotionIndex;
        private NPC[] roomWeapons;
        private PictureBox[] roomWeaponsP;
        private int collWeaponIndex;

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private FrmPause frmPause;

        private Character[] borderWalls;
        private PictureBox[] bws;

        private Character[] obstacles;
        private PictureBox[] obstaclesP;

        private Enemy[] enemies;
        private PictureBox[] enemiesP;
        private int collEnemyIndex;

        private Enemy[] doors;
        private PictureBox[] doorsP;
        private PictureBox[] doorEntrP;
        private int collDoorIndex;

        private int numOfRooms;
        private Point putInFrm = new Point(60, 60);
        private Panel curRoom;
        private Point curRoomsPrevLoc;
        private List<Control> controlsToMove;

        PictureBox playerMarker = new PictureBox();

        //private const int PADDING = 0;
        private const int PLAYER_PADDING = 5;
        private const int DOOR_PADDING = 5;
        private const int ENEMY_PADDING = 5;
        private const int OBSTACLE_PADDING = 5;
        private const int WALL_PADDING = 0;

        public FrmLvlHard(FrmInventory inv)
        {
            this.inventory = inv;

            InitializeComponent();

            //this.Size = new Size(1190, 765);
            this.Size = new Size(1300, 765);
            this.AutoScroll = false;

            // Counts the number of rooms in the map
            numOfRooms = countRooms();

            // Create the MiniMap
            //createMiniMap();
            createMiniMap();

            // Create the border walls for the rooms to be surrounded by
            createBorderWalls();

            // Setup starting room
            updateGameScreen(room0Panel);

            //Add the controls from the room to the frm... remove them later...
            drawRoom(curRoom);

            // Updates player location in the minimap
            updateMiniMap(curRoom);

        }

        private void FrmLvlHard_Load(object sender, EventArgs e)
        {
            const int NUM_BORDER_WALLS = 4;

            System.Media.SoundPlayer playersound = new System.Media.SoundPlayer(Properties.Resources.power_rangers_theme_instrumental);
            playersound.Play();
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PLAYER_PADDING));
            // Sets the players background to the image of the selected character
            picPlayer.BackgroundImage = CharacterSelect.characterPicked;
            player.Img = CharacterSelect.characterPicked;
            // Does a setup to display the inventory later
            inventory.displayPlayerStats(player);

            // Create colliders for the border walls...
            borderWalls = new Character[NUM_BORDER_WALLS];
            for (int w = 0; w < NUM_BORDER_WALLS; w++)
            {
                borderWalls[w] = new Character(CreatePosition(bws[w]), CreateCollider(bws[w], WALL_PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;

            // Prevent enemy battle bug
            PictureBox pb1 = new PictureBox();
            pb1.Location = new Point(1200, 1200);
            Enemy newEn = new Enemy(CreatePosition(pb1), CreateCollider(pb1, ENEMY_PADDING));
            FightFix(newEn);
        }

        private int countRooms()
        {
            int panelCount = 0;
            for (int i = 0; i < Controls.Count; i++)
            {
                try
                {
                    if (Controls.Find("room" + i.ToString() + "Panel", true)[0] as Panel != null)
                    {
                        panelCount++;
                    }
                }
                catch
                {

                }
            }
            return panelCount;
        }

        private void createMiniMap()
        {
            Control mMap = sidePanel.Controls.Find("miniMap", true)[0] as Control;
            mMap.BackColor = Color.DarkGray;
            Control cRoom;
            Control pastPanel = new Control();

            for (int i = 0; i < numOfRooms; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(25, 25);
                panel.BackColor = Color.Black;
                panel.Name = "p" + i.ToString();
                mMap.Controls.Add(panel);
                if (i == 0)
                {
                    cRoom = Controls.Find("room0Panel", true)[0] as Control;
                    panel.Location = new Point((mMap.Width / 2) - (panel.Width / 2), (mMap.Height / 2) - (panel.Height / 2));
                    pastPanel = panel;
                    continue;

                }
                cRoom = Controls.Find("room" + i.ToString() + "Panel", true)[0] as Control;
                Control prevCroom = Controls.Find("room" + (i - 1).ToString() + "Panel", true)[0] as Control;

                // Within 10 of same Y point, but a greater X value -> Panel is to the right
                if ((Math.Abs(cRoom.Location.Y - prevCroom.Location.Y) < 10) && cRoom.Location.X > prevCroom.Location.X)
                {
                    Console.WriteLine("Panel to the right");
                    panel.Location = new Point(pastPanel.Location.X + pastPanel.Width + 10, pastPanel.Location.Y);
                    pastPanel = panel;
                }
                // Within 10 of same Y point, but a lesser X value -> Panel is to the left
                else if ((Math.Abs(cRoom.Location.Y - prevCroom.Location.Y) < 10) && cRoom.Location.X < prevCroom.Location.X)
                {
                    Console.WriteLine("Panel to the left");
                    panel.Location = new Point(pastPanel.Location.X - pastPanel.Width - 10, pastPanel.Location.Y);
                    pastPanel = panel;
                }
                // Within 10 of same X point, but a greater Y value -> Panel is below
                else if ((Math.Abs(cRoom.Location.X - prevCroom.Location.X) < 10) && cRoom.Location.Y > prevCroom.Location.Y)
                {
                    Console.WriteLine("Panel is below");
                    panel.Location = new Point(pastPanel.Location.X, pastPanel.Location.Y + pastPanel.Height + 10);
                    pastPanel = panel;
                }
                // Within 10 of same X point, but a lesser Y value -> Panel is above
                else if ((Math.Abs(cRoom.Location.X - prevCroom.Location.X) < 10) && cRoom.Location.Y < prevCroom.Location.Y)
                {
                    Console.WriteLine("Panel is above");
                    panel.Location = new Point(pastPanel.Location.X, pastPanel.Location.Y - pastPanel.Height - 10);
                    pastPanel = panel;
                }
            }
        }

        private void updateMiniMap(Panel curr)
        {
            Control mMap = sidePanel.Controls.Find("miniMap", true)[0] as Control;
            playerMarker.Size = new Size(5, 5);
            playerMarker.BackColor = Color.Red;
            //Control panel;
            updatePlayerMarker(curRoom, mMap);
        }

        private void updatePlayerMarker(Panel curr, Control minimap)
        {
            Control panel = minimap.Controls.Find("p" + curr.Name.Substring(4,1), true)[0] as Control;
            panel.Controls.Add(playerMarker);
            playerMarker.Location = new Point((panel.Size.Width / 2) - (playerMarker.Size.Width / 2), (panel.Size.Height / 2) - (playerMarker.Size.Height / 2));

        }

        private void openTransition()
        {
            transitionPanel.BringToFront();
            transitionPanel.Visible = true;
        }

        private void closeTransition()
        {
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);
            transitionPanel.Visible = false;
            transitionPanel.SendToBack();
        }

        private void putControlsInFrm(Panel room)
        {
            controlsToMove = new List<Control>(room.Controls.Cast<Control>());

            foreach (Control control in controlsToMove)
            {
                // Make the control's parent the Form
                this.Controls.Add(control);

                // Adjust the location relative to the Form
                control.Location = new Point(control.Location.X + 60, control.Location.Y + 60);
            }
            room.Visible = false;
        }

        private void createObsts(Panel curr)
        {
            int count = 0;
            for (int y = 1; y <= Controls.Count; y++)
            {
                try
                {
                    if (Controls.Find(curr.Name.Substring(0, 5) + "Obstacle" + y.ToString(), true)[0] as PictureBox != null)
                    {
                        count++;
                    }
                }
                catch
                {
                    continue;
                }

            }
            obstacles = new Character[count];
            obstaclesP = new PictureBox[count];
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    PictureBox pic = Controls.Find(curr.Name.Substring(0, 5) + "Obstacle" + i.ToString(), true)[0] as PictureBox;
                    obstacles[i - 1] = new Character(CreatePosition(pic), CreateCollider(pic, OBSTACLE_PADDING));
                    obstaclesP[i - 1] = pic;
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0)
            {
                enemies = new Enemy[1];
                enemiesP = new PictureBox[1];
                enemies[0] = null;
                enemiesP[0] = null;
            }
        }

        private void createEnemies(Panel curr)
        {
            int count = 0;
            for (int y = 1; y <= Controls.Count; y++)
            {
                try
                {
                    if (Controls.Find(curr.Name.Substring(0, 5) + "Enemy" + y.ToString(), true)[0] as PictureBox != null)
                    {
                        count++;
                    }
                }
                catch
                {
                    continue;
                }

            }
            enemies = new Enemy[count];
            enemiesP = new PictureBox[count];
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    PictureBox pic = Controls.Find(curr.Name.Substring(0, 5) + "Enemy" + i.ToString(), true)[0] as PictureBox;
                    enemies[i - 1] = new Enemy(CreatePosition(pic), CreateCollider(pic, ENEMY_PADDING));
                    enemies[i - 1].Img = pic.BackgroundImage;
                    enemies[i - 1].Color = Color.Aqua;
                    enemiesP[i - 1] = pic;
                    Console.WriteLine("Enemy name: " + pic.Name);
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0)
            {
                enemies = new Enemy[1];
                enemiesP = new PictureBox[1];
                enemies[0] = null;
                enemiesP[0] = null;
            }
        }

        private void createDoors(Panel curr)
        {
            int count = 0;
            for (int y = 0; y < Controls.Count; y++)
            {
                try
                {
                    if (Controls.Find("toR" + y.ToString() + "FromR" + curr.Name.Substring(4, 1), true)[0] as PictureBox != null)
                    {
                        count++;
                    }
                }
                catch
                {
                    continue;
                }

            }
            doors = new Enemy[count];
            doorsP = new PictureBox[count];
            doorEntrP = new PictureBox[count];
            int cc = 0;
            for (int i = 0; i < numOfRooms; i++)
            {
                //Console.WriteLine("toR" + i.ToString() + "FromR" + curr.Name.Substring(4, 1));
                try
                {
                    PictureBox pic = Controls.Find("toR" + i.ToString() + "FromR" + curr.Name.Substring(4, 1), true)[0] as PictureBox;
                    doors[cc] = new Enemy(CreatePosition(pic), CreateCollider(pic, DOOR_PADDING));
                    doors[cc].Img = pic.BackgroundImage;
                    doorsP[cc] = pic;

                    Console.WriteLine("Door Name: " + pic.Name);
                    // Gets the picturebox of the exit for the door
                    doorEntrP[cc] = Controls.Find("fromR" + curr.Name.Substring(4, 1) + "toR" + i.ToString(), true)[0] as PictureBox;
                    Console.WriteLine("Got the picture box!");
                    cc++;
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            if (count == 0)
            {
                doors = new Enemy[1];
                doorsP = new PictureBox[1];
                doorEntrP = new PictureBox[1];
                doors[0] = null;
                doorsP[0] = null;
                doorEntrP[0] = null;
            }
        }

        private void createRoomWeapons(Panel curr)
        {
            int count = 0;
            for (int y = 1; y <= Controls.Count; y++)
            {
                try
                {
                    if (Controls.Find("room" + curr.Name.Substring(4, 1) + "Weapon" + y.ToString(), true)[0] as PictureBox != null)
                    {
                        count++;
                    }
                }
                catch
                {
                    continue;
                }

            }
            roomWeapons = new NPC[count];
            roomWeaponsP = new PictureBox[count];
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    PictureBox pic = Controls.Find("room" + curr.Name.Substring(4, 1) + "Weapon" + i.ToString(), true)[0] as PictureBox;
                    roomWeapons[i - 1] = new NPC(CreatePosition(pic), CreateCollider(pic, ENEMY_PADDING));
                    roomWeapons[i - 1].Img = pic.BackgroundImage;
                    roomWeaponsP[i - 1] = pic;
                    Console.WriteLine("Weapon name: " + pic.Name);
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0)
            {
                roomWeapons = new NPC[1];
                roomWeaponsP = new PictureBox[1];
                roomWeapons[0] = null;
                roomWeaponsP[0] = null;
            }
        }

        private void createRoomPotions(Panel curr)
        {
            int count = 0;
            for (int y = 1; y <= Controls.Count; y++)
            {
                try
                {
                    if (Controls.Find("room" + curr.Name.Substring(4, 1) + "Potion" + y.ToString(), true)[0] as PictureBox != null)
                    {
                        count++;
                    }
                }
                catch
                {
                    continue;
                }

            }
            roomPotions = new NPC[count];
            roomPotionsP = new PictureBox[count];
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    PictureBox pic = Controls.Find("room" + curr.Name.Substring(4, 1) + "Potion" + i.ToString(), true)[0] as PictureBox;
                    roomPotions[i - 1] = new NPC(CreatePosition(pic), CreateCollider(pic, ENEMY_PADDING));
                    roomPotions[i - 1].Img = pic.BackgroundImage;
                    roomPotionsP[i - 1] = pic;
                    Console.WriteLine("Potion name: " + pic.Name);
                }
                catch
                {
                    continue;
                }
            }
            if (count == 0)
            {
                roomPotions = new NPC[1];
                roomPotionsP = new PictureBox[1];
                roomPotions[0] = null;
                roomPotionsP[0] = null;
            }
        }

        private void createBorderWalls()
        {
            // Creates the border walls that will be used for each room
            PictureBox bw0 = new PictureBox();
            bw0.Location = new Point(0, 0);
            bw0.Size = new Size(1300, 60);
            bw0.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            bw0.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox bw1 = new PictureBox();
            bw1.Location = new Point(0, 670);
            bw1.Size = new Size(1190, 60);
            bw1.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            bw1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox bw2 = new PictureBox();
            bw2.Location = new Point(0, 0);
            bw2.Size = new Size(60, 1300);
            bw2.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            bw2.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox bw3 = new PictureBox();
            bw3.Location = new Point(1115, 0);
            bw3.Size = new Size(170, 1190);
            bw3.Image = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            bw3.SizeMode = PictureBoxSizeMode.StretchImage;

            // Adds the border walls to the windows form, and puts them in an array for collisions
            this.Controls.Add(bw0);
            this.Controls.Add(bw1);
            this.Controls.Add(bw2);
            this.Controls.Add(bw3);
            bws = new PictureBox[4];
            bws[0] = bw0;
            bws[1] = bw1;
            bws[2] = bw2;
            bws[3] = bw3;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLvlHard_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            player.Move();

            // Handles Hitting the border wals
            if (HitABorderWall(player))
            {
                player.MoveBack();
            }
            else if((obstacles.Length > 0 && obstacles[0] != null) && HitAObstacle(player))
            {
                player.MoveBack();
            }
            else if((enemies.Length > 0 && enemies[0] != null) && HitAnEnemy(player))
            {
                player.MoveBack();
                Fight(enemies[collEnemyIndex]);
            }
            else if ((roomWeapons.Length > 0 && roomWeapons[0] != null) && HitAWeapon(player))
            {
                player.MoveBack();
                if (inventory.myWeapons.Contains(null))
                {
                    String b = roomWeaponsP[collWeaponIndex].Tag.ToString();
                    Console.WriteLine("Pic tag: " + b);
                    String[] arrB = b.Split(new string[] { " " }, StringSplitOptions.None);
                    String name = arrB[0];
                    int damage = int.Parse(arrB[1]);
                    bool fire = bool.Parse(arrB[2]);
                    bool ice = bool.Parse(arrB[3]);


                    Weapon w = new Weapon(name, damage, fire, ice);
                    w.Img = roomWeaponsP[collWeaponIndex].BackgroundImage;
                    inventory.addWeapon(w);

                    //remove weapon from map
                    roomWeaponsP[collWeaponIndex].Location = new Point(1200, 1200);
                    roomWeapons[collWeaponIndex] = new NPC(CreatePosition(roomWeaponsP[collWeaponIndex]), CreateCollider(roomWeaponsP[collWeaponIndex], ENEMY_PADDING));
                }
            }
            else if ((roomPotions.Length > 0 && roomPotions[0] != null) && HitAPotion(player))
            {
                player.MoveBack();
                if (inventory.myPotions.Contains(null))
                {
                    String b = roomPotionsP[collPotionIndex].Tag.ToString();
                    Console.WriteLine("Pic tag: " + b);

                    Potion p = new Potion(b);
                    p.Img = roomPotionsP[collPotionIndex].BackgroundImage;
                    inventory.addPotion(p);

                    //remove weapon from map
                    roomPotionsP[collWeaponIndex].Location = new Point(1200, 1200);
                    roomPotions[collWeaponIndex] = new NPC(CreatePosition(roomPotionsP[collPotionIndex]), CreateCollider(roomPotionsP[collPotionIndex], ENEMY_PADDING));
                }
            }
            else if((doors.Length > 0 && doors[0] != null) && HitADoor(player))
            {
                switch(doorsP[collDoorIndex].Name)
                {
                    // Going to Room1 from Room0
                    case "toR1FromR0":
                        //logic
                        Console.WriteLine("Opened Door In Room 0... Entering Room 1");
                        moveRooms(room1Panel);
                        break;

                    case "toR3FromR0":
                        //logic
                        Console.WriteLine("Opened Door In Room 0... Entering Room 3");
                        moveRooms(room3Panel);
                        break;

                    case "toR5FromR0":
                        //logic
                        Console.WriteLine("Opened Door In Room 0... Entering Room 5");
                        moveRooms(room5Panel);
                        break;

                    case "toR7FromR0":
                        //logic
                        Console.WriteLine("Opened Door In Room 0... Entering Room 7");
                        moveRooms(room7Panel);
                        break;

                    // Going to Room2 from Room1
                    case "toR2FromR1":
                        //logic
                        Console.WriteLine("Opened Door In Room 1... Entering Room 2");
                        moveRooms(room2Panel);
                        break;

                    // Going to Room3 from Room2
                    case "toR3FromR2":
                        //logic
                        Console.WriteLine("Opened Door In Room 2... Entering Room 3");
                        moveRooms(room3Panel);
                        break;

                    // Going to Room4 from Room2
                    case "toR4FromR3":
                        //logic
                        Console.WriteLine("Opened Door In Room 3... Entering Room 4");
                        moveRooms(room4Panel);
                        break;

                    // Going to Room5 from Room3
                    case "toR5FromR4":
                        //logic
                        Console.WriteLine("Opened Door In Room 4... Entering Room 5");
                        moveRooms(room5Panel);
                        break;

                    // Going to Room5 from Room4
                    case "toR6FromR5":
                        //logic
                        Console.WriteLine("Opened Door In Room 5... Entering Room 6");
                        moveRooms(room6Panel);
                        break;

                    case "toR7FromR6":
                        //logic
                        Console.WriteLine("Opened Door In Room 6... Entering Room 7");
                        moveRooms(room7Panel);
                        break;

                    case "toR8FromR7":
                        //logic
                        Console.WriteLine("Opened Door In Room 7... Entering Room 8");
                        moveRooms(room8Panel);
                        break;


                    default:
                        break;
                }
            }
            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private bool HitABorderWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 1; w <= borderWalls.Length; w++)
            {
                if (c.Collider.Intersects(borderWalls[w - 1].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAObstacle(Character c)
        {
            bool hitAObst = false;
            for (int t = 0; t < obstacles.Length; t++)
            {
                if (c.Collider.Intersects(obstacles[t].Collider))
                {
                    hitAObst = true;
                    break;
                }
            }
            return hitAObst;
        }

        private bool HitAnEnemy(Character c)
        {
            bool hitAObst = false;
            for (int t = 0; t < enemies.Length; t++)
            {
                if (c.Collider.Intersects(enemies[t].Collider))
                {
                    collEnemyIndex = t;
                    hitAObst = true;
                    break;
                }
            }
            return hitAObst;
        }

        private bool HitADoor(Character c)
        {
            bool hitAObst = false;
            for (int t = 0; t < doors.Length; t++)
            {
                if (c.Collider.Intersects(doors[t].Collider))
                {
                    collDoorIndex = t;
                    hitAObst = true;
                    break;
                }
            }
            return hitAObst;
        }

        private bool HitAWeapon(Character c)
        {
            bool hitAObst = false;
            for (int t = 0; t < roomWeapons.Length; t++)
            {
                if (c.Collider.Intersects(roomWeapons[t].Collider))
                {
                    collWeaponIndex = t;
                    hitAObst = true;
                    break;
                }
            }
            return hitAObst;
        }

        private bool HitAPotion(Character c)
        {
            bool hitAObst = false;
            for (int t = 0; t < roomPotions.Length; t++)
            {
                if (c.Collider.Intersects(roomPotions[t].Collider))
                {
                    collPotionIndex = t;
                    hitAObst = true;
                    break;
                }
            }
            return hitAObst;
        }

        private void relocatePlayer(PictureBox entrance)
        {
            player.MoveBack();
            picPlayer.Location = entrance.Location;
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PLAYER_PADDING));
        }

        private void moveControlsToOGRoom()
        {
            foreach (Control control in controlsToMove)
            {
                curRoom.Controls.Add(control);

                control.Location = new Point(control.Location.X - 60, control.Location.Y - 60);
            }
        }

        private void removeObstacleColliders()
        {
            for (int t = 0; t < obstacles.Length; t++)
            {
                if (obstacles[t] != null)
                {
                    obstaclesP[t].Location = new Point(1200, 1200);
                    obstacles[t] = new Character(CreatePosition(obstaclesP[t]), CreateCollider(obstaclesP[t], OBSTACLE_PADDING));
                }
            }
        }

        private void removeEnemyColliders()
        {
            for (int t = 0; t < enemies.Length; t++)
            {
                if (enemies[t] != null)
                {
                    enemiesP[t].Location = new Point(1200, 1200);
                    enemies[t] = new Enemy(CreatePosition(enemiesP[t]), CreateCollider(enemiesP[t], ENEMY_PADDING));
                }

            }
        }

        private void removeDoorColliders()
        {
            for (int t = 0; t < doors.Length; t++)
            {
                if (doors[t] != null)
                {
                    doorsP[t].Location = new Point(1200, 1200);
                    doors[t] = new Enemy(CreatePosition(doorsP[t]), CreateCollider(doorsP[t], DOOR_PADDING));
                }
            }
        }

        private void drawRoom(Panel cur)
        {

            putControlsInFrm(cur);
            createObsts(cur);
            createEnemies(cur);
            createDoors(cur);
            createRoomWeapons(cur);
            createRoomPotions(cur);
        }

        private void updateGameScreen(Panel p)
        {
            curRoomsPrevLoc = p.Location;
            curRoom = p;
            p.Location = putInFrm;
            this.BackColor = p.BackColor;
        }

        private void adjustDoorColliders()
        {
            for (int t = 0; t < doors.Length; t++)
            {
                if (doors[t] != null)
                {
                    Point usePoint = doorsP[t].Location;
                    doorsP[t].Location = usePoint;
                    doors[t] = new Enemy(CreatePosition(doorsP[t]), CreateCollider(doorsP[t], DOOR_PADDING));
                }
            }
        }

        private void moveRooms(Panel p)
        {
            // Covers the Screen with a transition Panel to make room traversal nicer
            openTransition();

            // Updates the players location to the entrance of the room they are entering; must specify the entrance pic
            relocatePlayer(doorEntrP[collDoorIndex]);

            //Put the controls back in their original room
            moveControlsToOGRoom();

            //Remove entrance collider from last room
            removeDoorColliders();

            // Removes obstacle colliders from the game screen and puts them in a diffrent spot
            removeObstacleColliders();

            // Removes enemy colliders from the game screen and puts them in a different spot
            removeEnemyColliders();

            // Track room(panel) location and move it to the game screen; sets curRoom
            updateGameScreen(p);

            // Set up the controls in the windows from the form
            // Create colliders for obstacles, enemies, and doors
            drawRoom(curRoom);

            // Updates player location in the minimap
            updateMiniMap(curRoom);

            // Adjust new door colliders to be in correct spot
            adjustDoorColliders();

            // Move the room panel back to its previous location
            p.Location = curRoomsPrevLoc;

            // Closes the transition panel and shows the new room
            closeTransition();
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            // Passes the inventory to FrmBattle to be used later
            frmBattle = FrmBattle.GetInstance(enemy, inventory);
            frmBattle.ShowDialog();
        }

        private void FightFix(Enemy enemy) 
        {
            FrmBattle.GetInstanceFix(enemy, inventory);
        }

        private void FrmLvlHard_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;
                case Keys.A:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;
                case Keys.D:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;
                case Keys.W:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;
                case Keys.S:
                    player.GoDown();
                    break;

                case Keys.I:
                    inventory.displayPlayerStats(Game.player);
                    inventory.ShowDialog(this);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.P:
                    frmPause = new FrmPause();
                    frmPause.Show();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }
    }
}
