namespace geometry_fight
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.txtboxnick = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::geometry_fight.Properties.Resources.concrete_wall;
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 80);
            this.panel1.TabIndex = 2;
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.BackColor = System.Drawing.SystemColors.Control;
            this.txttitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txttitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txttitle.Image = global::geometry_fight.Properties.Resources.concrete_wall;
            this.txttitle.Location = new System.Drawing.Point(437, 19);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(288, 42);
            this.txttitle.TabIndex = 0;
            this.txttitle.Text = "Geometry Fight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(402, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wpisz swój nick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(292, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz poziom trudności";
            // 
            // buttonEasy
            // 
            this.buttonEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEasy.Image = global::geometry_fight.Properties.Resources.zielony;
            this.buttonEasy.Location = new System.Drawing.Point(164, 449);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(203, 60);
            this.buttonEasy.TabIndex = 9;
            this.buttonEasy.Text = "Łatwy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.LoadEasyGame);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMedium.Image = global::geometry_fight.Properties.Resources.zolty;
            this.buttonMedium.Location = new System.Drawing.Point(484, 449);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(203, 60);
            this.buttonMedium.TabIndex = 10;
            this.buttonMedium.Text = "Średni";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.LoadNormalGame);
            // 
            // buttonHard
            // 
            this.buttonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHard.Image = global::geometry_fight.Properties.Resources.czerwony;
            this.buttonHard.Location = new System.Drawing.Point(793, 449);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(203, 60);
            this.buttonHard.TabIndex = 11;
            this.buttonHard.Text = "Trudny";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.LoadHardGame);
            // 
            // txtboxnick
            // 
            this.txtboxnick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxnick.Location = new System.Drawing.Point(367, 214);
            this.txtboxnick.Name = "txtboxnick";
            this.txtboxnick.Size = new System.Drawing.Size(427, 38);
            this.txtboxnick.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::geometry_fight.Properties.Resources.concrete_wall;
            this.button1.Location = new System.Drawing.Point(484, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tablica Wynikow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenScores);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::geometry_fight.Properties.Resources.dark_wall;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxnick);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.TextBox txtboxnick;
        private System.Windows.Forms.Button button1;
    }
}