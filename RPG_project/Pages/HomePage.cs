using RPG_project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_project.Pages
{
    public partial class HomePage : UserControl
    {
        Player Kris = new Player();
       

        public HomePage()
        {
            InitializeComponent();
            UpdatePlayerInfo();
        }
        private void UpdatePlayerInfo()
        {
            this.labelMana1.Text = "Мана: " + Kris.getMana() + "/" + Kris.getMaxMana();

            this.labelExperience.Text = "Досвід: " + Kris.getExperience() + "/" + Kris.getLevelCup();
            this.labelGold.Text = "Темні доллари: " + Kris.getGold();
            this.labelStrength.Text = "Сила: " + Kris.getStrength();
            this.labelIntelligence.Text = "Інтелект: " + Kris.getIntelligence();
            this.labelArmor.Text = "Броня: " + Kris.getArmor();
            this.labelEndurance.Text = "Витривалість: " + Kris.getEndurance();
            this.labelAgility.Text = "Спритність: " + Kris.getAgility();
            this.labelWeapon.Text = "Зброя: " + Kris.getWeapon();
            this.labelLVL.Text = "LVL: " + Kris.getLevel();
            this.progressBarHealth1.Value = Kris.getHealth();
            this.labelHealth1.Text = "Здоров'я: " + Kris.getHealth() + "/" + Kris.getMaxHealth();
            this.progressBarMana1.Value = Kris.getMana();
            this.progressBarExperience1.Value = Kris.getExperience();

        }
        


    }
}
