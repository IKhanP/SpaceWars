using Space_Game_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Space_Game_Project
{
    public partial class Form1 : Form
    {
        static Image playerimg = Properties.Resources.ship5;
        bool moveup, movedown, moveleft, moveright;      //logic for moving the player
        int speed = 8;    //speed of the spacecraft
        int playerX, playerY;    //player's position
        int score = 0;    

        float rotationAngle;
        List<Bullet> bullets = new List<Bullet>();
        private List<enemies> enemies_list = new List<enemies>();  //store enemy instances

        private enemies enemy;

        private int countdown = 10; //initial countdown value
        private int waveCount = 0; //number of enemies in wave

        private Random rand = new Random();

        string[] typesofenemies = { "Large", "Medium", "Small"};  //possible types of enemies
        string randomtype;   //used to create and store random type of enemy


        //for game over screen
        public Label gameOverLabel;
        Button mainMenuButton;
        Button restartbutton;

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up ) moveup = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) movedown = false;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) moveleft = false;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) moveright = false;
        }

        private void gameTimer_event(object sender, EventArgs e)
        {
            //move the spacecraft
            if (moveup) playerY -= 10;
            if (movedown) playerY += 10;
            if (moveleft) playerX -= 10;
            if (moveright) playerX += 10;

            for (int i = bullets.Count - 1; i >= 0; i--)  //iterate over list of bullets backwords
            {
                Bullet bullet = bullets[i];
                bullet.Move();         //continously move the bullet in timer

                foreach (var enemy in enemies_list)   //iterate over every enemy in the list
                {
                    if (bullet.BulletPictureBox.Bounds.IntersectsWith
                        (enemy.EnemyPictureBox.Bounds))  //check collision between bullets and enemy spacecraft
                    {
                        // reduce health
                        enemy.sethealth(enemy.gethealth() - 1);

                        // remove bullet
                        this.Controls.Remove(bullet.BulletPictureBox);
                        bullets.RemoveAt(i);
                        i--; 
                        break;
                    }
                }

                if (bullet.IsOutOfBounds(ClientSize))
                {
                    // Remove bullets that go out of bounds
                    this.Controls.Remove(bullets[i].BulletPictureBox);
                    bullets.RemoveAt(i);
                }
            }

            for (int j = enemies_list.Count - 1; j >= 0; j--)  //go through each enemy in the list
            {
                if (enemies_list[j].gethealth() <= 0)   //if enemy health is 0
                {
                    //remove enemy from screen and list
                    this.Controls.Remove(enemies_list[j].EnemyPictureBox);
                    enemies_list.RemoveAt(j);
                    score++;  //increase score
                }
                //update score label
                Scorelbl.Text = "Score: " + Convert.ToString(score);
            }

            foreach (var enemy in enemies_list)   
            {
                enemy.Update(playerX, playerY); //move every enemy in the list
            }


            foreach (var enemy in enemies_list)   //loop through enemy list
            {
                //if player collides with any enemy
                if (playerhitbox.Bounds.IntersectsWith(enemy.EnemyPictureBox.Bounds))
                {
                    gameOverScreen();
                    return;   //exit loop
                }
            }

            this.Invalidate();  //trigger a repaint continously
        }

        private void gameOverScreen()
        {
            //stop timers
            gameTimer.Stop();   
            wave_timer.Stop();  

            //large text on game over screen
            gameOverLabel = new Label();
            gameOverLabel.Text = "GAME OVER";
            gameOverLabel.Font = new Font("Arial", 36, FontStyle.Bold);
            gameOverLabel.ForeColor = Color.Red;   //red colour
            gameOverLabel.Location = new Point(ClientSize.Width / 4, 100);
            gameOverLabel.AutoSize = true;
            this.Controls.Add(gameOverLabel);
            gameOverLabel.BringToFront();  //move it to the front of the form

            //main menu option in death menu
            mainMenuButton = new Button();
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.Font = new Font("Arial", 22, FontStyle.Bold);  //increase font
            mainMenuButton.Size = new Size(250, 50);   
            mainMenuButton.Location = new Point(ClientSize.Width / 4 + 30, 220);  //position
            mainMenuButton.Click += openMainMenu;
            this.Controls.Add(mainMenuButton);
            mainMenuButton.BringToFront();    //bring to the front

            //restart game
            restartbutton = new Button();
            restartbutton.Text = "Restart Game";
            restartbutton.Font = new Font("Arial", 22, FontStyle.Bold);  //increase font
            restartbutton.Size = new Size(250, 50);
            restartbutton.Location = new Point(ClientSize.Width / 4 + 30, 300);  //position
            restartbutton.Click += RestartGame;   //call restartGame method
            this.Controls.Add(restartbutton);
            restartbutton.BringToFront();    //bring to the front


        }
        private void openMainMenu(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu showmenu = new MainMenu();
            showmenu.Show();
            
        }
        private void RestartGame(object sender, EventArgs e)
        {
            // Reset variables
            playerX = ClientSize.Width / 2;
            playerY = ClientSize.Height / 2;
            rotationAngle = 0;
            score = 0;
            waveCount = 0;
            countdown = 10;

            // Clear bullets and enemies
            foreach (var bullet in bullets)
            {
                this.Controls.Remove(bullet.BulletPictureBox);
            }
            foreach (var enemy in enemies_list)
            {
                this.Controls.Remove(enemy.EnemyPictureBox);
            }
            bullets.Clear();
            enemies_list.Clear();

            //remove game over screen controls
            this.Controls.Remove(gameOverLabel);
            this.Controls.Remove(mainMenuButton);
            this.Controls.Remove(restartbutton);

            SpawnWave();  //spawn initial wave

            //start timer
            gameTimer.Start();
            wave_timer.Start();
        }

        private void GamePaintEvent(object sender, PaintEventArgs e)
        {
            int shipwidth = 76;
            int shipheight = 70;

            int hitboxWidth = 52;
            int hitboxHeight = 44;

            DoubleBuffered = true;

            //set the origin to middle of the screen
            e.Graphics.TranslateTransform(playerX, playerY);
            e.Graphics.RotateTransform(rotationAngle + 90);

            // Draw the player ship
            e.Graphics.DrawImage(playerimg, -(shipwidth / 2),
                -(shipheight / 2), shipwidth, shipheight);

            //hitbox position
            playerhitbox.Location = new Point(playerX - (hitboxWidth/2), playerY - (hitboxHeight/2));

            //reset origin to top left of the window
            e.Graphics.ResetTransform();

            
        }

        private void MouseIsClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //only shoot on left mouse click
            {
                int bulletsize = 8;

                // Create a new PictureBox for the bullet
                PictureBox bullet_picbox = new PictureBox();
                bullet_picbox.Size = new Size(bulletsize, bulletsize);
                bullet_picbox.BackColor = Color.Red; // Set bullet color to red

                // Calculate the bullet's starting position
                int bulletX = (int)(playerX + 50 * Math.Cos((rotationAngle) * Math.PI / 180)); // 50 here means the no of pixels in front of the ship
                int bulletY = (int)(playerY + 50 * Math.Sin((rotationAngle) * Math.PI / 180));

                bullet_picbox.Location = new Point(bulletX - bulletsize / 2, bulletY - bulletsize / 2);

                // Add the bullet to the form
                this.Controls.Add(bullet_picbox);

                //add bullet to list
                bullets.Add(new Bullet(bullet_picbox, rotationAngle * Math.PI / 180));
            }
            

        }

        private void Mouse_move(object sender, MouseEventArgs e)
        {
            // update mouse position and calculate the angle between the player and the mouse
            Point mousePosition = e.Location;
            rotationAngle = (float)(Math.Atan2(mousePosition.Y - playerY, mousePosition.X - playerX) * (180 / Math.PI));

            // trigger a repaint
            this.Invalidate();

        }

        private void wave_timer_event(object sender, EventArgs e)
        {
            countdown--;

            if (countdown <= 0)  //after 10 seconds
            {
                if (waveCount <= 10) waveCount++;
                countdown = 10; // Reset countdown
                SpawnWave();   //spawn wave
            }

            // Update countdown label
            countdownlbl.Text = Convert.ToString(countdown);
            countdownlbl.Font = new Font("Impact", 26, FontStyle.Bold);
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) moveup = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) movedown = true;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) moveleft = true;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) moveright = true;
        }

        private void SpawnEnemy(Point spawnLocation)
        {
            randomtype = typesofenemies[rand.Next(0, typesofenemies.Length)];   //choose random type of enemy

            enemy = new enemies(spawnLocation, randomtype);   //create new instance of enemy
            enemies_list.Add(enemy);         //add to the list
            this.Controls.Add(enemy.EnemyPictureBox);    //add to the form        

        }
        public void SpawnWave()
        {
            int maxEnemies = Math.Min(3 + waveCount, 10);  // max enemies = 10
            int enemyCount = rand.Next(1, maxEnemies + 1);    //random number of enemy
            
            for (int i = 0; i<enemyCount; i++)   //iterate until enemycount number
            {
                Point spawnPoint = GetRandomSpawnPoint();
                SpawnEnemy(spawnPoint);
            }
        }

        public Point GetRandomSpawnPoint()
        {          
            int side = rand.Next(4);
            int x = 0, y = 0;

            if (side == 0)    //top side
            {
                x = rand.Next(ClientSize.Width);
                y = -50;
            }
            else if (side == 1)    //bottom side
            {
                x = rand.Next(ClientSize.Width);
                y = ClientSize.Height + 50;
            }
            else if (side == 2)   //left side
            {
                x = -50;
                y = rand.Next(ClientSize.Height);
            }
            else    //right side
            {                
                x = ClientSize.Width + 50;
                y = rand.Next(ClientSize.Height);
            }

            return new Point(x, y);
        }

        public Form1()
        {
            InitializeComponent();
            player.Dispose();  //remove the picturebox once the form is started

            //set the initial position to centre
            playerX = ClientSize.Width / 2;   
            playerY = ClientSize.Height / 2;
            SpawnWave();

            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  
        }

    }
}
