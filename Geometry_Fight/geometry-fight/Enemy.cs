using System.Windows.Forms;

namespace geometry_fight
{
    internal abstract class Enemy : Moving
    {
        public Enemy(int speed, int left, int top)
        {
            Left = left;
            this.speed = speed;
            Top = top;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
        public abstract void enemyMove(Player player);

    }
}
