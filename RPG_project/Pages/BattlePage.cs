using RPG_project.Entities;
using RPG_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_project.Pages
{
    public partial class BattlePage : UserControl
    {
        Player Kris;
        Enemy enemy;
        Form1 mainForm;
        
        public BattlePage(Player player, Form1 form)
        {
            InitializeComponent();
            Kris = player;
            mainForm = form;
            string[] specialAbilities = { "None","Сильний удар","Лікування"};
            string[] enemyNames = { "Lancer", "Tenna", "Roaring Knight", "K_K", "Gerson Boom", "Flowery", "Aqua", "Shadow Guy", "Miss Mizle", "Seth", "Leafling", "Jevil", "Yellow", "Cat Mike", "Berdly", "Queen" };
            Image[] enemyImages =
            {
              Properties.Resources.Lancer,Properties.Resources.Tenna,Properties.Resources.Knight_battle_afterimage,Properties.Resources.K_K,
              Properties.Resources.Gerson_Boom,Properties.Resources.Flowery,Properties.Resources.Aqua,Properties.Resources.Shadowguy,
              Properties.Resources.Miss_Mizzle,Properties.Resources.Seth,Properties.Resources.Leafling,
              Properties.Resources.Jevil,Properties.Resources.Yellow,Properties.Resources.Cat_Mike,Properties.Resources.Berdly,
              Properties.Resources.Queen
            };
            int randomIndex = CustomRandom.GetRandomNumber(0, enemyNames.Length - 1);
            string enemyName = enemyNames[randomIndex];
            int abilityIndex = CustomRandom.GetRandomNumber(0, specialAbilities.Length - 1);
            string randomAbility = specialAbilities[abilityIndex];
            pictureBoxEnemy.Image = enemyImages[randomIndex];
            int enemyLevel = CustomRandom.GetRandomNumber(Kris.getLevel(), Kris.getLevel() + 1);
            enemy = new Enemy(enemyName, enemyLevel,randomAbility);
            labelNameBattle2.Text = enemy.GetName() + " (LVL " + enemy.getLevel() + ")";
            UpdateBars();
            AddLog("Бій розпочато! Проти вас: " + enemy.GetName() + " (" + enemy.getLevel() + " рівень).");
            if (enemy.GetSpecialAbility() == "None")
            {
                AddLog("Особливих вмінь у ворога немає.");
            }
            else
            {
                AddLog("Особливе вміння ворога: " + enemy.GetSpecialAbility() + "");
            }
        }
        private void UpdateBars()
        {

            progressBarHPKris.Maximum = Kris.HP.GetMax();
            progressBarHPKris.Value = Kris.HP.GetCurrent();
            labelHPKris.Text = "HP: " + Kris.HP.GetCurrent() + "/" + Kris.HP.GetMax();

            progressBarMPKris.Maximum = Kris.MP.GetMax();
            progressBarMPKris.Value = Kris.MP.GetCurrent();
            labelMPKris.Text = "MP: " + Kris.MP.GetCurrent() + "/" + Kris.MP.GetMax();


            progressBarHPEnemy.Maximum = enemy.HP.GetMax();
            progressBarHPEnemy.Value = enemy.HP.GetCurrent();
            labelHPEnemy.Text = "HP: " + enemy.HP.GetCurrent() + "/" + enemy.HP.GetMax();
        }
        private void AddLog(string text)
        {
            richTextBox1.AppendText(text + "\n");
            richTextBox1.ScrollToCaret();
        }
        private void CheckBattle()
        {
            UpdateBars();            
            if (enemy.HP.GetCurrent() <= 0)
            {
                pictureBoxKris.Image=Properties.Resources.Kris_win;
                int rewardGold = enemy.GetRewardGold();
                int rewardExp = enemy.GetRewardXp();
                Kris.AddReward(rewardGold, rewardExp);
                Kris.HP.Increase(Kris.HP.GetMax());
                Kris.MP.Increase(Kris.MP.GetMax());
                MessageBox.Show(" Ви отримали " + rewardGold + " темних доларів та " + rewardExp + " досвіду!", "Ви виграли!:)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.EndBattle();
                return;
            }

            int abilityChance = CustomRandom.GetRandomNumber(1, 100);
            if (enemy.GetSpecialAbility() != "None" && abilityChance <= 50)
            {
                if (enemy.GetSpecialAbility() == "Лікування")
                {
                    int healed = enemy.Heal();
                    AddLog(enemy.GetName() + " лікує себе і відновлює собі " + healed + " HP!");
                }
                else if (enemy.GetSpecialAbility() == "Сильний удар")
                {
                    int heavyDamage = Kris.TakeDamage(enemy.PowerStrike());
                    AddLog(enemy.GetName() + " використовує Сильний удар і наносить " + heavyDamage + " урону!");
                }
            }
            else
            {
               
                int enemyDamage = Kris.TakeDamage(enemy.Attack());
                AddLog(enemy.GetName() + " атакує  і наносить вам " + enemyDamage + " урону!");
            }

            
            UpdateBars();

            if (Kris.HP.GetCurrent() <= 0)
            {
                pictureBoxKris.Image = Properties.Resources.Kris_sitting;
                MessageBox.Show("Здається, ти дійшов до кінця", "Ви програли!:(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kris.HP.Increase(Kris.HP.GetMax());
                Kris.MP.Increase(Kris.MP.GetMax());
                mainForm.EndBattle();
            }
        }
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (Kris.MP.GetCurrent() < 15)
            {
                MessageBox.Show("Не вистачає MP! Може відпочинете?.", "Невистачає мани", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                pictureBoxKris.Image = Properties.Resources.Kris_attack;
                Kris.MP.Decrease(15);
                int damage = enemy.TakeDamage(Kris.NormalAttack());
                AddLog("Ви атакували " + enemy.GetName() + " і нанесли " + damage + " урону!");
                CheckBattle();
            }


        }

        private void buttonStrongAttack_Click(object sender, EventArgs e)
        {
            if (Kris.MP.GetCurrent() < 50)
            {
                MessageBox.Show("Не вистачає MP для сильної атаки (потрібно 50 MP). Може відпочинете?!", " Невистачає мани", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                pictureBoxKris.Image = Properties.Resources.Kris_attack;
                Kris.MP.Decrease(50);
                int damage = enemy.TakeDamage(Kris.HeavyAttack());
                AddLog("Ви використали СИЛЬНУ АТАКУ і нанесли " + damage + " урону!");

                CheckBattle();
            }
        }

        private void buttonHeal_Click(object sender, EventArgs e)
        {
            if (Kris.MP.GetCurrent() < 40)
            {
                MessageBox.Show("Не вистачає MP для лікування (потрібно 40 MP)!", "Невистачає мани", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                pictureBoxKris.Image = Properties.Resources.Kris_item;
                Kris.MP.Decrease(40);
                Kris.HP.Increase(150);
                AddLog("Ви вилікували себе на 150 HP!");
                CheckBattle();
            }
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            pictureBoxKris.Image = Properties.Resources.Kris_guard;
            Kris.MP.Increase(80);
            AddLog("Ви відпочили і відновили 80 MP.");

            CheckBattle();
        }
    }
}
