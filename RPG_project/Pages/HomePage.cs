using RPG_project.Entities;
using RPG_project.Utils;
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
        Form1 mainForm;

        public HomePage(Player player, Form1 form)
        {
            InitializeComponent();
            Kris = player;
            mainForm = form;
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

        private void button2_Click(object sender, EventArgs e)
        {
            int nextTurn = CustomRandom.GetRandomNumber(1, 4);
            if (nextTurn == 1)
            {
                MessageBox.Show("Ви пройшлися темним коридором. Нічого не сталося...може спробуєте знову?", "І..нічого", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nextTurn == 2)
            {
                RandomEvent();
            }
            else if (nextTurn == 3)
            {
                MessageBox.Show("Ви натрапили на загадкову лавку! Час оновити спорядження.", "Магазин!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.OpenShop();
            }
            else if (nextTurn == 4)
            {
                MessageBox.Show("Dаш шлях перегородила якась тінь! Починається бій!", "Бій!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainForm.OpenBattle();
            }

            UpdatePlayerInfo();
        }
        private void RandomEvent()
        {
            int eventNumber = CustomRandom.GetRandomNumber(1, 10);

            if (eventNumber == 1)
            {
                Kris.HP.Increase(100);
                MessageBox.Show("У кутку кімнати ви знайшли дивний зелений мох і з'їли його. Відновлено +100 HP!", "Зелений мох", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 2)
            {
                Kris.ChangeGold(150);
                MessageBox.Show("Зі старого сміттєвого бака вилетів чек: «ВІТАЮ, [Шановний Клієнт]! ВИ ВИГРАЛИ [Безкоштовні Гроші]!!». Отримано +150 темних доларів!", "Вигідна пропозиція!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 3)
            {
                Kris.MP.Increase(50);
                Kris.ChangeEndurance(1);
                MessageBox.Show("На п'єдесталі лежав теплий  пиріг. Схоже хтось піклується про вас. +50 MP та +1 до Витривалості!", "Пиріг", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 4)
            {
                Kris.ChangeStrength(2);
                MessageBox.Show("Ви знайшли зім'яту інструкцію «Як бити сильніше за [3 Легкі Кроки]». Сила зросла на +2!", "Секретний прийом", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 5)
            {
                Kris.ChangeIntelligence(2);
                MessageBox.Show("Ви підібрали уламок темного кристала, крізь який світ виглядає інакше. Інтелект зріс на +2!", "Темний кристал", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 6)
            {
                Kris.ChangeAgility(2);
                MessageBox.Show("Ви знайшли заховану коробку зі свіжими темними цукерками у формі зірочок і з'їли одну. Спритність зросла на +2!", "Темні цукерки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 7)
            {
                Kris.AddReward(80, 100);
                MessageBox.Show("Ви торкнулися дивного жовтого сяйва посеред кімнати. Від думки про те, що колись ви таки розберетеся з усім цим хаосом, ви наповнилися рішучістю! Ви отримали +80 темних доларів та +100 досвіду!", "Рішучість", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (eventNumber == 8) 
            {
                Kris.ChangeGold(-70);
                MessageBox.Show("Повітря закрутилося з диким сміхом: «ХАОС, ХАОС! ТВОЇ МОНЕТИ ТЕПЕР МОЇ!». Ви втратили 70 темних доларів!", "Вихор хаос!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (eventNumber == 9) 
            {
                Kris.ChangeAgility(-1);
                Kris.HP.Decrease(100);
                MessageBox.Show("Ви наступили на розсипану кольорову крейду та послизнулися! -1 до Спритності та -100 HP!", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (eventNumber == 10) 
            {
                Kris.MP.Decrease(30);
                Kris.ChangeIntelligence(-1);
                MessageBox.Show("На екран прийшло 999 вікон: «НАТИСНИ ТУТ, ЩОБ СТАТИ [Великим Босом]!!».У вас розболілася голова: -30 MP та -1 до Інтелекту!", "Вірус!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
