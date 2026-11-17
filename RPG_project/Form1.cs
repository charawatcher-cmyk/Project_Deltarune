using RPG_project.Entities;
using RPG_project.Pages;
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

namespace RPG_project
{
    public partial class Form1 : Form
    {
        Player Kris = new Player("Kris Dreemur");
        HomePage homePage;
        BattlePage battlePage = new BattlePage();
        ShopPage shopPage;
        
        public Form1()
        {
           
            InitializeComponent();
             homePage = new HomePage(Kris);
            shopPage = new ShopPage(Kris);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти з гри?","Вихід", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        
        private void buttonCharectar_Click(object sender, EventArgs e)
        {
            homePage.UpdatePlayerInfo();
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }

        private void buttonBattle_Click_1(object sender, EventArgs e)
        {
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(battlePage);
        }

        private void buttonShop_Click_1(object sender, EventArgs e)
        {
            shopPage = new ShopPage(Kris);
            this.panelContent.Controls.Clear();
            shopPage.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(shopPage);
            
        }
    }
}
