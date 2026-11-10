using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    internal class Enemy
    {
        private string name;
        private int level;
        private int attack;
        private int defense;
        private int health;
        private int maxHealth;
        private int rewardGold;
        private int rewardXp;
        private string specialAbility;
        public Enemy(string name, int level, int attack, int defense, int health, int maxHealth, int rewardGold, int rewardXp, string specialAbility)
        {
            this.name = name;
            this.level = level;
            this.attack = attack;
            this.defense = defense;
            this.health = this.maxHealth=health;
            this.rewardGold = rewardGold;
            this.rewardXp = rewardXp;
            this.specialAbility = specialAbility;
        }
        public string getName()
        {
            return this.name;
        }

        public int getLevel()
        {
            return this.level;
        }

        public int getAttack()
        {
            return this.attack;
        }

        public int getDefense()
        {
            return this.defense;
        }

        public int getHealth()
        {
            return this.health;
        }
        public int getRewardGold()
        {
            return this.rewardGold;
        }

        public int getRewardXP()
        {
            return this.rewardXp;
        }

        public string getSpecialAbility()
        {
            return this.specialAbility;
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

        public void AttackPlayer(Player player)
        {
            int damage = this.attack - player.CalculateDefense();

            if (damage < 1)
            {
                damage = 1;
            }

            player.TakeDamage(damage);
        }
    }

}
