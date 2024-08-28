using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shoot
{
    class Bullet
    {
        private string direction;
        private int bulletLeft;
        private int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public Bullet(string direction, int bulletLeft, int bulletTop)
        {
            this.direction = direction;
            this.bulletLeft = bulletLeft;
            this.bulletTop = bulletTop;
        }
        public void MakeBullet(Form form)
        {
            bullet.BackColor= Color.Yellow;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft; 
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if(direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }
            if(bullet.Left < 0 || bullet.Left > 1200 || bullet.Top < 0 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet= null;
            }
        }


    }
}