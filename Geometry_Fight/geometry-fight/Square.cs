using System.Windows.Forms;

namespace geometry_fight
{
    internal class Square : Enemy
    {

        public Square(int speed, int left, int top) : base(speed, left, top)
        {
            Tag = "square";
            Image = Properties.Resources.square;
        }
        public override void enemyMove(Player player)
        {
            if (this.Top > player.PlayerModel.Top)
            {
                this.Top -= speed;
            }
            if (this.Top < player.PlayerModel.Top)
            {
                this.Top += speed;
            }

        }


    }
}
