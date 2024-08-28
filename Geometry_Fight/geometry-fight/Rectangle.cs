using System.Windows.Forms;

namespace geometry_fight
{
    internal class Rectangle : Enemy
    {


        public Rectangle(int speed,  int left, int top) : base(speed, left, top)
        {
            Tag = "rectangle";
            Image = Properties.Resources.rectangle;
        }
        public override void enemyMove(Player player)
        {
            if (this.Left > player.PlayerModel.Left)
            {
                this.Left -= speed;
            }
            if (this.Left < player.PlayerModel.Left)
            {
                this.Left += speed;
            }

        }

    }
}
