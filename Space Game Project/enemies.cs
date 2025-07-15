using Space_Game_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Game_Project
{
    internal class enemies
    {
        public PictureBox EnemyPictureBox { get; set; }
        private float speed;       //speed of enemy
        private int playerX, playerY;   //player position reference

        private string type;
        private int health;

        public enemies(Point spawnLocation, string enemytype)    //constructor for enemy class
        {
            type = enemytype;
            EnemyPictureBox = new PictureBox
            {
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = spawnLocation,
                Enabled = false   //disable response to user interaction (mouse events)
            };

            if (type == "Large")  //properties/attributes for large enemy
            {
                EnemyPictureBox.Size = new Size(79, 103);
                EnemyPictureBox.Image = Resources.Large_Enemy;
                speed = 4;
                health = 3;
            }
            else if (type == "Medium")  //properties/attributes of medium enemy
            {
                EnemyPictureBox.Size = new Size(61,86);
                EnemyPictureBox.Image = Resources.Medium_enemy;
                speed = 5.1f;
                health = 2;
            }  
            else    //properties/attributes of small enemy
            {
                EnemyPictureBox.Size = new Size(59, 46);
                EnemyPictureBox.Image = Resources.Small_enemy;
                speed = 6.2f;
                health = 1;
            }
        }

        //get and set methods
        public int gethealth()
        {
            return health;
        }

        public void sethealth(int healthvalue)
        {
            health = healthvalue;
        }

        public void Update(int playerX, int playerY)
        {
            this.playerX = playerX;
            this.playerY = playerY;

            // Calculate distance
            float dx = playerX - EnemyPictureBox.Left;
            float dy = playerY - EnemyPictureBox.Top;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance > 0)    //move towards player
            {
                EnemyPictureBox.Left += (int)(speed * dx / distance);
                EnemyPictureBox.Top += (int)(speed * dy / distance);
            }
        }
    }
}
