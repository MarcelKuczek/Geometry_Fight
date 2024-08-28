using geometry_fight.geometry_fight;
using Shoot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace geometry_fight
{
    public partial class Game : Form
    {
        // Zmienne gry
        private int score;
        private int round = 1;
        public int point = 1;
        public int point2 = 2;
        public string NickValue;
        private bool gameOver;
        private int numberOfEnemys;
        private Random randNum = new Random();
        //Konstruktory innych klas
        private Player player = new Player(100, "right", 10);
        private List<PictureBox> enemyList = new List<PictureBox>();
        private List<PictureBox> bonusList = new List<PictureBox>();

        public Game()
        {
            InitializeComponent();
            RestartGame();
            player.PlayerModel = playerModel;
        }

        private async void MainTimerEvent(object sender, EventArgs e)
        {
            txtnick.Text = NickValue;
            // Spreeawdzenie czy gracz nie przegrał
            IfAlive();

            // Zliczanie punktów, rund i ilości przeciwników
            MenuCounter();

            //Poruszanie
            Move();

            // Przeciwnicy ruszaja w kierunku gracza
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "triangle")
                    {
                        if (x is Triangle)
                        {
                            ((Triangle)x).enemyMove(player);
                        }
                        if (playerModel.Bounds.IntersectsWith(x.Bounds))
                        {
                            player.PlayerHealth -= 1;
                        }
                    }
                    else if ((string)x.Tag == "square")
                    {
                        if (x is Square)
                        {
                            ((Square)x).enemyMove(player);
                        }
                        if (playerModel.Bounds.IntersectsWith(x.Bounds))
                        {
                            player.PlayerHealth -= 2;
                        }
                    }
                    else if ((string)x.Tag == "rectangle")
                    {
                        if (x is Rectangle)
                        {
                            ((Rectangle)x).enemyMove(player);
                        }
                        if (playerModel.Bounds.IntersectsWith(x.Bounds))
                        {
                            player.PlayerHealth -= 2;
                        }
                    }
                    else if ((string)x.Tag == "hpup")
                    {
                        if (playerModel.Bounds.IntersectsWith(x.Bounds) && player.PlayerHealth < 76)
                        {
                            player.PlayerHealth += 25;
                            this.Controls.Remove(x);

                        }
                    }
                    
                    else if ((string)x.Tag == "boomb")
                    {
                        if (playerModel.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            foreach (PictureBox i in enemyList)
                            {
                                this.Controls.Remove(i);
                                enemyList.Remove(((PictureBox)x));
                                if (i is PictureBox && (string)i.Tag == "triangle")
                                {
                                    score += point2;
                                }
                                else if (i is PictureBox && (string)i.Tag == "square" || i is PictureBox && (string)i.Tag == "rectangle")
                                {
                                    score += point;
                                    
                                }
                                enemyList.Remove(((PictureBox)x));
                            }
                            numberOfEnemys = 0;
                            await MakeEnemyAsync();
                        }
                    }

                }

                // Eliminacja przeciwników
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet")
                    {
                        if (x is PictureBox && (string)x.Tag == "triangle")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score += point2;
                                numberOfEnemys--;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemyList.Remove(((PictureBox)x));
                                if (numberOfEnemys == 0)
                                {
                                    MakeBonus();
                                    await MakeEnemyAsync();
                                    round++;
                                }
                            }
                        }


                        if (j is PictureBox && (string)x.Tag == "square")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score += point;
                                numberOfEnemys--;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemyList.Remove(((PictureBox)x));
                                if (numberOfEnemys == 0)
                                {
                                    MakeBonus();
                                    await MakeEnemyAsync();
                                    round++;
                                }
                            }
                        }

                        if (j is PictureBox && (string)x.Tag == "rectangle")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score += point;
                                numberOfEnemys--;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemyList.Remove(((PictureBox)x));
                                if (numberOfEnemys == 0)
                                {
                                    MakeBonus();
                                    await MakeEnemyAsync();
                                    round++;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.FaceLeft();
                playerModel.Image = Properties.Resources.player3;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.FaceRight();
                playerModel.Image = Properties.Resources.player1;
            }
            if (e.KeyCode == Keys.Up)
            {
                player.FaceUp();
                playerModel.Image = Properties.Resources.player4;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.FaceDown();
                playerModel.Image = Properties.Resources.player2;
            }
        }


        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.GoLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                player.GoRight = false;

            }
            if (e.KeyCode == Keys.Up)
            {
                player.GoUp = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                player.GoDown = false;

            }
            if (e.KeyCode == Keys.Space && gameOver == false)
            {
                ShootBullet(player.Facing);
            }
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }

        }

        private void ShootBullet(object direction)
        {
            int bulletLeft = playerModel.Left + (playerModel.Width / 2);
            int bulletTop = playerModel.Top + (playerModel.Height / 2);

            Bullet shootBullet = new Bullet((string)direction, bulletLeft, bulletTop);
            shootBullet.MakeBullet(this);
        }

        public async Task MakeEnemyAsync()
        {
            await Task.Run(() =>
            {
                for (int i = score; i >= 0; i -= 5)
                {
                    if (i % 2 == 0)
                    {
                        int Left = (randNum.Next(0, 2) == 0) ? -10 : this.ClientSize.Width + 10;
                        int Top = (randNum.Next(0, 2) == 0) ? randNum.Next(-100, 0) : this.ClientSize.Height + randNum.Next(0, 100);
                        Triangle triangle = new Triangle(3, Left, Top);
                        this.Invoke(new Action(() => { this.Controls.Add(triangle); enemyList.Add(triangle); }));
                        numberOfEnemys++;
                    }
                    if (i % 3 == 0)
                    {
                        int Left = randNum.Next(0, this.ClientSize.Width);
                        int Top = (randNum.Next(0, 2) == 0) ? randNum.Next(-10, 0) : this.ClientSize.Height + randNum.Next(0, 10);
                        Square square = new Square(4, Left, Top);
                        this.Invoke(new Action(() => { this.Controls.Add(square); enemyList.Add(square); }));
                        numberOfEnemys++;
                    }
                    if (i % 4 == 0)
                    {
                        int Left = (randNum.Next(0, 2) == 0) ? randNum.Next(-10, 0) : this.ClientSize.Height + randNum.Next(0, 10);
                        int Top = randNum.Next(100, this.ClientSize.Height - 100);
                        Rectangle rectangle = new Rectangle(2, Left, Top);
                        this.Invoke(new Action(() => { this.Controls.Add(rectangle); enemyList.Add(rectangle); }));
                        numberOfEnemys++;
                    }
                }
            });
        }

        public void MakeBonus()
        {
            if (round % 5 == 0)
            {
                int Left = randNum.Next(0, this.ClientSize.Height - 10);
                int Top = randNum.Next(0, this.ClientSize.Height - 10);
                Boomb boomb = new Boomb(Left, Top);
                this.Controls.Add(boomb);
                this.bonusList.Add(boomb);
            }
            else if (round % 2 == 0)
            {
                int Left = randNum.Next(0, this.ClientSize.Height - 10);
                int Top = randNum.Next(0, this.ClientSize.Height - 10);
                HpUp hpup = new HpUp(Left, Top);
                this.Controls.Add(hpup);
                this.bonusList.Add(hpup);
            }
        }


        private async void RestartGame()
        {
            // Użycie ranges
            var rangeToRemove = Enumerable.Range(0, enemyList.Count);
            enemyList.GetRange(0, enemyList.Count).RemoveAll(x =>
            {
                this.Controls.Remove(x);
                return true;
            });

            bonusList.RemoveAll(x =>
            {
                this.Controls.Remove(x);
                return true;
            });

            SaveScore();
            numberOfEnemys = 0;
            enemyList.Clear();
            player.GoUp = false;
            player.GoDown = false;
            player.GoLeft = false;
            player.GoRight = false;
            gameOver = false;
            player.PlayerHealth = 100;
            score = 0;
            round = 1;
            await MakeEnemyAsync();
            GameTimer.Start();
        }
        //Wykorzystanie filesystem
        private void SaveScore()
        {
            string filePath = "..\\..\\Score.txt";
            string data = $"Gracz: {NickValue} wynik: {score}";
            if (score > 0)
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(data);
                }
            }
            
        }

        private void MenuCounter()
        {
            txtscore.Text = "Score: " + score;
            txtround.Text = "Round: " + round;
            txtenemy.Text = "Przeciwnicy: " + numberOfEnemys;
        }

        private void IfAlive()
        {
            if (player.PlayerHealth > 1)
            {
                healthBar.Value = player.PlayerHealth;
            }
            else
            {
                gameOver = true;
                GameTimer.Stop();
                MessageBox.Show("Przegrales, wciśnij enter aby zresetowac gre.", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private new void Move()
        {
            if (player.GoLeft == true && playerModel.Left > 0)
            {
                player.MoveLeft();
            }
            if (player.GoRight == true && playerModel.Left + playerModel.Width < this.ClientSize.Width)
            {
                player.MoveRight();
            }
            if (player.GoUp == true && playerModel.Top > 40)
            {
                player.MoveTop();
            }
            if (player.GoDown == true && playerModel.Top + playerModel.Height < this.ClientSize.Height)
            {
                player.MoveDown();
            }
        }
    }

}
