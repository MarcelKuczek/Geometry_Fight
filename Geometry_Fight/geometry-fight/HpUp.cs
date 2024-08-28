using System.Windows.Forms;

namespace geometry_fight
{
    internal class HpUp : Bonus
    {
        public HpUp(int left, int top) : base(left, top)
        {
            Tag = "hpup";
            Image = Properties.Resources.hpup;
        }
    }
}