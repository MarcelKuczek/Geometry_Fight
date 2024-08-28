namespace geometry_fight
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnick = new System.Windows.Forms.Label();
            this.txtenemy = new System.Windows.Forms.Label();
            this.txtround = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.playerModel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerModel)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtnick);
            this.panel1.Controls.Add(this.txtenemy);
            this.panel1.Controls.Add(this.txtround);
            this.panel1.Controls.Add(this.txtscore);
            this.panel1.Controls.Add(this.health);
            this.panel1.Controls.Add(this.healthBar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 8;
            // 
            // txtnick
            // 
            this.txtnick.AutoSize = true;
            this.txtnick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnick.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtnick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnick.Image = ((System.Drawing.Image)(resources.GetObject("txtnick.Image")));
            this.txtnick.Location = new System.Drawing.Point(839, 5);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(54, 18);
            this.txtnick.TabIndex = 9;
            this.txtnick.Text = "Gracz";
            // 
            // txtenemy
            // 
            this.txtenemy.AutoSize = true;
            this.txtenemy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtenemy.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtenemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtenemy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtenemy.Image = ((System.Drawing.Image)(resources.GetObject("txtenemy.Image")));
            this.txtenemy.Location = new System.Drawing.Point(124, 5);
            this.txtenemy.Name = "txtenemy";
            this.txtenemy.Size = new System.Drawing.Size(117, 18);
            this.txtenemy.TabIndex = 8;
            this.txtenemy.Text = "Przeciwnicy: 0";
            // 
            // txtround
            // 
            this.txtround.AutoSize = true;
            this.txtround.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtround.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtround.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtround.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtround.Image = ((System.Drawing.Image)(resources.GetObject("txtround.Image")));
            this.txtround.Location = new System.Drawing.Point(25, 5);
            this.txtround.Name = "txtround";
            this.txtround.Size = new System.Drawing.Size(76, 18);
            this.txtround.TabIndex = 7;
            this.txtround.Text = "Round: 0";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtscore.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtscore.Image = ((System.Drawing.Image)(resources.GetObject("txtscore.Image")));
            this.txtscore.Location = new System.Drawing.Point(530, 5);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(72, 18);
            this.txtscore.TabIndex = 6;
            this.txtscore.Text = "Score: 0";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.health.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.health.Image = ((System.Drawing.Image)(resources.GetObject("health.Image")));
            this.health.Location = new System.Drawing.Point(947, 5);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(61, 18);
            this.health.TabIndex = 3;
            this.health.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthBar.Location = new System.Drawing.Point(1014, 5);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(150, 20);
            this.healthBar.TabIndex = 4;
            this.healthBar.Value = 100;
            // 
            // playerModel
            // 
            this.playerModel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playerModel.Image = global::geometry_fight.Properties.Resources.player1;
            this.playerModel.Location = new System.Drawing.Point(517, 260);
            this.playerModel.Name = "playerModel";
            this.playerModel.Size = new System.Drawing.Size(85, 50);
            this.playerModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerModel.TabIndex = 5;
            this.playerModel.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerModel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Game";
            this.Text = "Geometry_fight";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox playerModel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtscore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtround;
        private System.Windows.Forms.Label txtenemy;
        private System.Windows.Forms.Label txtnick;
    }
}

