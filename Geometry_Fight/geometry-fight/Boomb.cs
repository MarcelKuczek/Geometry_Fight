using System.Windows.Forms;

namespace geometry_fight
{
    internal class Boomb : Bonus
    {
        public Boomb(int left, int top) : base(left, top)
        {
            Tag = "boomb";
            Image = Properties.Resources.boomb;
        }
    }
}
