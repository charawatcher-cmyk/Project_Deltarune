using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    internal class Player
    {
        private string name;

        private int level;
        private int levelCup;
        private int experience;

        private int strength;
        private int endurance;
        private int agility;
        private int intelligence;

        private int health;
        private int maxHealth;

        private int mana;
        private int maxMana;

        private int gold;
        private Weapon weapon;
        private Armor armor;
        public Player()
        {
            this.name = "Kris Dreemurr";

            this.level = 1;
            this.levelCup = 100;
            this.experience = 0;

            this.strength = 10;
            this.endurance = 10;
            this.agility = 10;
            this.intelligence = 10;

            this.maxHealth = 200;
            this.maxMana = 200;
            this.health = endurance * 10;
            this.mana = intelligence * 5;

            this.gold = 100;
            this.weapon = null;
            this.armor = null;


        }
        public string getName()
        {
            return this.name;
        }

        public int getLevel()
        {
            return this.level;
        }

        public int getLevelCup()
        {
            return this.levelCup;
        }

        public int getExperience()
        {
            return this.experience;
        }

        public int getStrength()
        {
            return this.strength;
        }

        public int getEndurance()
        {
            return this.endurance;
        }

        public int getAgility()
        {
            return this.agility;
        }

        public int getIntelligence()
        {
            return this.intelligence;
        }

        public int getHealth()
        {
            return this.health;
        }

        public int getMaxHealth()
        {
            return this.maxHealth;
        }

        public int getMana()
        {
            return this.mana;
        }

        public int getMaxMana()
        {
            return this.maxMana;
        }

        public int getGold()
        {
            return this.gold;
        }
        public Weapon getWeapon()
        {
            return this.weapon;
        }

        public Armor getArmor()
        {
            return this.armor;
        }



        public double getCriticalChance()
        {
            return this.agility * 0.5;
        }
        public int  CalculateAttackPower() 
        {
            int attack = this.strength;
            if (this.weapon != null)
            {
        
                attack += this.weapon.getAttackBonus();
            }

            return attack;
        }
        public int CalculateDefense()
        {
            int defense = this.agility;

            if (this.armor != null)
            {
                defense += this.armor.getDefenseBonus();
            }

            return defense;
        }
        public void TakeDamage(int value)
        {
            this.health -= value;

            if (this.health < 0)
            {
                this.health = 0;
            }
        }

        public void Heal(int value)
        {
            this.health += value;

            if (this.health > this.maxHealth)
            {
                this.health = this.maxHealth;
            }
        }

        public void UseMana(int value)
        {
            this.mana -= value;

            if (this.mana < 0)
            {
                this.mana = 0;
            }
        }

        public void AddGold(int value)
        {
            this.gold += value;
        }
        public void AddExperience(int value)
        {
            this.experience += value;

            if (this.experience >= this.levelCup)
            {
                this.experience -= this.levelCup;
                this.level++;

                this.levelCup += 50;

                this.strength += 2;
                this.endurance += 2;
                this.agility += 2;
                this.intelligence += 2;

                this.maxHealth = this.endurance * 10;
                this.maxMana = this.intelligence * 5;

                this.health = this.maxHealth;
                this.mana = this.maxMana;
            }
        }

    }

}
