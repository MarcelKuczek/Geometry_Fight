using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace geometry_fight
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void LoadEasyGame(object sender, EventArgs e)
        {
            // Wykorzystanie Regexa
            string pattern = @"^[a-zA-Z0-9\s]+$";
            Game game = new Game();
            game.point = 1;
            game.point2 = 2;
            string validate = txtboxnick.Text;
            if (Regex.IsMatch(validate, pattern))
            {
                game.NickValue = validate;
                game.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawny nick. Dozwolone są tylko litery i cyfry.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxnick.Focus();
            }

        }

        private void LoadNormalGame(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9\s]+$";
            Game game = new Game();
            game.point = 2;
            game.point2 = 3;
            string validate = txtboxnick.Text;
            if (Regex.IsMatch(validate, pattern))
            {
                game.NickValue = validate;
                game.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawny nick. Dozwolone są tylko litery i cyfry.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxnick.Focus();
            }
        }

        private void LoadHardGame(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9\s]+$";
            Game game = new Game();
            game.point = 3;
            game.point2 = 4;
            string validate = txtboxnick.Text;
            if (Regex.IsMatch(validate, pattern))
            {
                game.NickValue = validate;
                game.Show();

            }
            else
            {
                MessageBox.Show("Niepoprawny nick. Dozwolone są tylko litery i cyfry.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxnick.Focus();
            }
        }

        private void OpenScores(object sender, EventArgs e)
        {
            string filePath = "..\\..\\Score.txt";
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Otwieranie pliku nie powiodlo sie: " + ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
