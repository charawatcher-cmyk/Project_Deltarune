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
        BattlePage battlePage;
        ShopPage shopPage;
        
        public Form1()
        {
           
            InitializeComponent();
             homePage = new HomePage(Kris,this);
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
            panel1.Visible = false;
            battlePage = new BattlePage(Kris, this);
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(battlePage);
        }
        public void EndBattle()
        {
            panel1.Visible = true; 
            homePage.UpdatePlayerInfo(); 

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(homePage);
        }

        private void buttonShop_Click_1(object sender, EventArgs e)
        {
            shopPage = new ShopPage(Kris);
            this.panelContent.Controls.Clear();
            shopPage.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(shopPage);
            
        }
        public void OpenShop()
        {
            shopPage = new ShopPage(Kris);
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(shopPage);
        }
        public void OpenBattle()
        {
            panel1.Visible = false;
            battlePage = new BattlePage(Kris, this);
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(battlePage);
        }
    }
}
