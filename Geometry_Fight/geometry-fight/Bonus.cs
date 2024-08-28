using System.Windows.Forms;

namespace geometry_fight
{

    public abstract class Bonus : PictureBox
    {
        public Bonus(int left, int top)
        {
            Left = left;
            Top = top;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }
}