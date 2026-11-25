namespace RPG_project.Pages
{
    partial class BattlePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContentBattle = new System.Windows.Forms.Panel();
            this.labelNameBattle1 = new System.Windows.Forms.Label();
            this.labelNameBattle2 = new System.Windows.Forms.Label();
            this.progressBarHPKris = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBarMPKris = new System.Windows.Forms.ProgressBar();
            this.labelHPKris = new System.Windows.Forms.Label();
            this.labelMPKris = new System.Windows.Forms.Label();
            this.labelHPEnemy = new System.Windows.Forms.Label();
            this.progressBarHPEnemy = new System.Windows.Forms.ProgressBar();
            this.labelMPEnemy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonStrongAttack = new System.Windows.Forms.Button();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.buttonRest = new System.Windows.Forms.Button();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxKris = new System.Windows.Forms.PictureBox();
            this.panelContentBattle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelContentBattle
            // 
            this.panelContentBattle.BackColor = System.Drawing.Color.RosyBrown;
            this.panelContentBattle.BackgroundImage = global::RPG_project.Properties.Resources.Background;
            this.panelContentBattle.Controls.Add(this.panel1);
            this.panelContentBattle.Controls.Add(this.labelMPEnemy);
            this.panelContentBattle.Controls.Add(this.progressBarHPEnemy);
            this.panelContentBattle.Controls.Add(this.labelHPEnemy);
            this.panelContentBattle.Controls.Add(this.labelMPKris);
            this.panelContentBattle.Controls.Add(this.labelHPKris);
            this.panelContentBattle.Controls.Add(this.progressBarMPKris);
            this.panelContentBattle.Controls.Add(this.richTextBox1);
            this.panelContentBattle.Controls.Add(this.progressBarHPKris);
            this.panelContentBattle.Controls.Add(this.labelNameBattle2);
            this.panelContentBattle.Controls.Add(this.labelNameBattle1);
            this.panelContentBattle.Controls.Add(this.pictureBoxEnemy);
            this.panelContentBattle.Controls.Add(this.pictureBoxKris);
            this.panelContentBattle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentBattle.Location = new System.Drawing.Point(0, 0);
            this.panelContentBattle.Name = "panelContentBattle";
            this.panelContentBattle.Size = new System.Drawing.Size(800, 450);
            this.panelContentBattle.TabIndex = 3;
            // 
            // labelNameBattle1
            // 
            this.labelNameBattle1.AutoSize = true;
            this.labelNameBattle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameBattle1.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameBattle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNameBattle1.Location = new System.Drawing.Point(18, 0);
            this.labelNameBattle1.Name = "labelNameBattle1";
            this.labelNameBattle1.Size = new System.Drawing.Size(155, 29);
            this.labelNameBattle1.TabIndex = 3;
            this.labelNameBattle1.Text = "Kris Dreemur";
            // 
            // labelNameBattle2
            // 
            this.labelNameBattle2.AutoSize = true;
            this.labelNameBattle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameBattle2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameBattle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNameBattle2.Location = new System.Drawing.Point(593, 0);
            this.labelNameBattle2.Name = "labelNameBattle2";
            this.labelNameBattle2.Size = new System.Drawing.Size(81, 29);
            this.labelNameBattle2.TabIndex = 4;
            this.labelNameBattle2.Text = "Enemy";
            // 
            // progressBarHPKris
            // 
            this.progressBarHPKris.Location = new System.Drawing.Point(3, 61);
            this.progressBarHPKris.Name = "progressBarHPKris";
            this.progressBarHPKris.Size = new System.Drawing.Size(201, 22);
            this.progressBarHPKris.TabIndex = 5;
            this.progressBarHPKris.Value = 70;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(255, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 369);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // progressBarMPKris
            // 
            this.progressBarMPKris.Location = new System.Drawing.Point(8, 117);
            this.progressBarMPKris.Name = "progressBarMPKris";
            this.progressBarMPKris.Size = new System.Drawing.Size(201, 22);
            this.progressBarMPKris.TabIndex = 7;
            this.progressBarMPKris.Value = 70;
            // 
            // labelHPKris
            // 
            this.labelHPKris.AutoSize = true;
            this.labelHPKris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHPKris.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHPKris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHPKris.Location = new System.Drawing.Point(3, 29);
            this.labelHPKris.Name = "labelHPKris";
            this.labelHPKris.Size = new System.Drawing.Size(113, 29);
            this.labelHPKris.TabIndex = 8;
            this.labelHPKris.Text = "Здоров\'я:";
            // 
            // labelMPKris
            // 
            this.labelMPKris.AutoSize = true;
            this.labelMPKris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMPKris.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMPKris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMPKris.Location = new System.Drawing.Point(3, 86);
            this.labelMPKris.Name = "labelMPKris";
            this.labelMPKris.Size = new System.Drawing.Size(75, 29);
            this.labelMPKris.TabIndex = 9;
            this.labelMPKris.Text = "Мана:";
            // 
            // labelHPEnemy
            // 
            this.labelHPEnemy.AutoSize = true;
            this.labelHPEnemy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHPEnemy.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHPEnemy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHPEnemy.Location = new System.Drawing.Point(540, 29);
            this.labelHPEnemy.Name = "labelHPEnemy";
            this.labelHPEnemy.Size = new System.Drawing.Size(113, 29);
            this.labelHPEnemy.TabIndex = 10;
            this.labelHPEnemy.Text = "Здоров\'я:";
            // 
            // progressBarHPEnemy
            // 
            this.progressBarHPEnemy.Location = new System.Drawing.Point(545, 61);
            this.progressBarHPEnemy.Name = "progressBarHPEnemy";
            this.progressBarHPEnemy.Size = new System.Drawing.Size(201, 22);
            this.progressBarHPEnemy.TabIndex = 11;
            this.progressBarHPEnemy.Value = 70;
            // 
            // labelMPEnemy
            // 
            this.labelMPEnemy.AutoSize = true;
            this.labelMPEnemy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMPEnemy.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMPEnemy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMPEnemy.Location = new System.Drawing.Point(540, 86);
            this.labelMPEnemy.Name = "labelMPEnemy";
            this.labelMPEnemy.Size = new System.Drawing.Size(0, 29);
            this.labelMPEnemy.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonRest);
            this.panel1.Controls.Add(this.buttonHeal);
            this.panel1.Controls.Add(this.buttonStrongAttack);
            this.panel1.Controls.Add(this.buttonAttack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 14;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAttack.Location = new System.Drawing.Point(19, 3);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(185, 48);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Атака";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonStrongAttack
            // 
            this.buttonStrongAttack.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStrongAttack.Location = new System.Drawing.Point(216, 3);
            this.buttonStrongAttack.Name = "buttonStrongAttack";
            this.buttonStrongAttack.Size = new System.Drawing.Size(185, 48);
            this.buttonStrongAttack.TabIndex = 1;
            this.buttonStrongAttack.Text = "Сильна атака";
            this.buttonStrongAttack.UseVisualStyleBackColor = true;
            this.buttonStrongAttack.Click += new System.EventHandler(this.buttonStrongAttack_Click);
            // 
            // buttonHeal
            // 
            this.buttonHeal.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHeal.Location = new System.Drawing.Point(407, 3);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(185, 48);
            this.buttonHeal.TabIndex = 2;
            this.buttonHeal.Text = "Лікування";
            this.buttonHeal.UseVisualStyleBackColor = true;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_Click);
            // 
            // buttonRest
            // 
            this.buttonRest.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRest.Location = new System.Drawing.Point(598, 3);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(185, 48);
            this.buttonRest.TabIndex = 3;
            this.buttonRest.Text = "Відпочинок";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(545, 86);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(201, 257);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy.TabIndex = 2;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxKris
            // 
            this.pictureBoxKris.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKris.Image = global::RPG_project.Properties.Resources.kris_battle;
            this.pictureBoxKris.Location = new System.Drawing.Point(23, 117);
            this.pictureBoxKris.Name = "pictureBoxKris";
            this.pictureBoxKris.Size = new System.Drawing.Size(165, 241);
            this.pictureBoxKris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKris.TabIndex = 1;
            this.pictureBoxKris.TabStop = false;
            // 
            // BattlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelContentBattle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "BattlePage";
            this.Size = new System.Drawing.Size(800, 450);
            this.panelContentBattle.ResumeLayout(false);
            this.panelContentBattle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContentBattle;
        private System.Windows.Forms.Label labelNameBattle1;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBoxKris;
        private System.Windows.Forms.Label labelNameBattle2;
        private System.Windows.Forms.Label labelHPKris;
        private System.Windows.Forms.ProgressBar progressBarMPKris;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBarHPKris;
        private System.Windows.Forms.Label labelMPKris;
        private System.Windows.Forms.Label labelMPEnemy;
        private System.Windows.Forms.ProgressBar progressBarHPEnemy;
        private System.Windows.Forms.Label labelHPEnemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStrongAttack;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonHeal;
    }
}
