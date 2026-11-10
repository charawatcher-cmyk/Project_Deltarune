using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    internal class Armor
    {
        private string name;
        private int cost;
        private int defenseBonus;
        public Armor(string name, int cost, int defenseBonus)
        {
            this.name = name;
            this.cost = cost;
            this.defenseBonus = defenseBonus;
        }
        public string getName()
        {
            return this.name;
        }
        public int getCost() 
        {
            return this.cost;
        }
        public int getDefenseBonus()
        {
            return this.defenseBonus;
        }
    }
}  



