using System.Windows.Forms;

namespace geometry_fight
{
    namespace geometry_fight
    {
        internal class Triangle : Enemy
        {

            public Triangle(int speed, int left, int top) : base(speed, left, top)
            {
                Tag = "triangle";
                Image = Properties.Resources.triangle;
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
}
