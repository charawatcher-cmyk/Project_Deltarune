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
        Player Kris;
       

        public HomePage(Player player)
        {
            InitializeComponent();
            Kris = player;
            UpdatePlayerInfo();
        }
        public void UpdatePlayerInfo()
        {


            this.labelMana1.Text = "Мана: " + Kris.MP.GetCurrent() + "/" + Kris.MP.GetMax();

            this.labelExperience.Text = "Досвід: " + Kris.getExperience() + "/" + Kris.getLevelCup();
            this.labelGold.Text = "Темні доллари: " + Kris.getGold();
            this.labelStrength.Text = "Сила: " + Kris.getStrength();
            this.labelIntelligence.Text = "Інтелект: " + Kris.getIntelligence();
            this.labelArmor.Text = "Броня: " + (Kris.getArmor() == null ? "Немає" : Kris.getArmor().GetName());
            this.labelEndurance.Text = "Витривалість: " + Kris.getEndurance();
            this.labelAgility.Text = "Спритність: " + Kris.getAgility();
            this.labelWeapon.Text = "Зброя: " + (Kris.getWeapon() == null ? "Немає" : Kris.getWeapon().GetName());
            this.labelLVL.Text = "LVL: " + Kris.getLevel();
            this.progressBarHealth1.Maximum = Kris.HP.GetMax();
            this.progressBarHealth1.Value = Kris.HP.GetCurrent();
            this.labelHealth1.Text = "Здоров'я: " + Kris.HP.GetCurrent() + "/" + Kris.HP.GetMax();
            this.progressBarMana1.Maximum = Kris.MP.GetMax();
            this.progressBarMana1.Value = Kris.MP.GetCurrent();
            this.progressBarExperience1.Maximum = Kris.getLevelCup();
            this.progressBarExperience1.Value = Kris.getExperience();

        }
        


    }
}
