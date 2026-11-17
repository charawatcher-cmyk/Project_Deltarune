using RPG_project.Entities;
using RPG_project.GameServices;
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
    public partial class ShopPage : UserControl
    {
        Player Kris;
        Shop shop = new Shop();
        List<BaseItem> items;
        public ShopPage(Player player)
        {
            InitializeComponent();
            LoadItems(player);
            labelShopText.Text = shop.getShopTexte();
            flowLayoutPanelShop.MouseEnter += (s, e) => flowLayoutPanelShop.Focus();
            this.Load += (s, e) => { flowLayoutPanelShop.PerformLayout(); };
        }

        private void LoadItems(Player player)
        {
            items = shop.getItems();

            Kris = player;

            Label[] nameLabels = { labelName1, labelName2, labelName3, labelName4, labelName5 };
            Label[] statLabels = { labelInformation1, labelInformation2, labelInformation3, labelInformation4, labelInformation5 };
            PictureBox[] pictures = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };


            for (int i = 0; i < 5; i++)
            {
                nameLabels[i].Text = items[i].GetName();
                statLabels[i].Text = "Характеристика: " + items[i].GetValue() + " | Ціна: " + items[i].GetPrice();
                pictures[i].Image = GetItemImage(items[i].GetName());
            }
        }
        private Image GetItemImage(string name)
        {
            if (name == "Twisted Sword") return Properties.Resources.Twisted_Sword;
            if (name == "Devilsknife") return Properties.Resources.Devilsknife;
            if (name == "Auto Axe") return Properties.Resources.Auto_Axe;
            if (name == "Aqua Knife") return Properties.Resources.Aqua_Knife;
            if (name == "Winglade") return Properties.Resources.Winglade;
            if (name == "Freeze Ring") return Properties.Resources.Freeze_Ring;
            if (name == "Justice Axe") return Properties.Resources.Justice_Axe;
            if (name == "Bounce Blade") return Properties.Resources.Bounce_Blade;
            if (name == "Mane Axe") return Properties.Resources.Mane_Axe;
            if (name == "Mecha Saber") return Properties.Resources.Mecha_Saber;

            
            if (name == "Shadow Mantle") return Properties.Resources.Shadow_Mantle;
            if (name == "TennaTie") return Properties.Resources.TennaTie;
            if (name == "GoldWidow") return Properties.Resources.GoldWidow;
            if (name == "Seth Specs") return Properties.Resources.Seth_Specs;
            if (name == "LodeStone") return Properties.Resources.LodeStone;
            if (name == "Royal Pin") return Properties.Resources.Royal_Pin;
            if (name == "Spike Band") return Properties.Resources.Spike_Band;
            if (name == "Blue Ribbon") return Properties.Resources.Blue_Ribbon;
            if (name == "Chain Mail") return Properties.Resources.Chain_Mail;
            if (name == "Amber Card") return Properties.Resources.Amber_Card;
            if (name=="Deal Maker")return Properties.Resources.Deal_Maker;
            return null;
        }
        private void BuyItem(Button clickedButton, int itemIndex)
        {
            if (shop.Buy(Kris, items[itemIndex]) == true)
            {
                clickedButton.Enabled = false;
                clickedButton.Text = "Куплено";
                clickedButton.BackColor = Color.LightGreen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyItem(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyItem(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyItem(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyItem(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuyItem(button5, 4);
        }
    }
}
