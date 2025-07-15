using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Game_Project
{
    internal class Bullet
    {
        public PictureBox BulletPictureBox { get; }
        private double Angle { get; }  //angle in relation to mouse position
        private int Speed { get; } = 20; 

        public Bullet(PictureBox pictureBox, double angle)   //constructor for bullet class
        {
            BulletPictureBox = pictureBox;
            Angle = angle;
        }

        public void Move()
        {
            int moveX = (int)(Speed * Math.Cos(Angle));
            int moveY = (int)(Speed * Math.Sin(Angle));
            BulletPictureBox.Left += moveX;
            BulletPictureBox.Top += moveY;
        }
        public bool IsOutOfBounds(Size clientSize)
        {
            // Check if the bullet is outside the form boundaries
            return BulletPictureBox.Right < 0 || BulletPictureBox.Left > clientSize.Width ||
                   BulletPictureBox.Bottom < 0 || BulletPictureBox.Top > clientSize.Height;
        }
    }
}
