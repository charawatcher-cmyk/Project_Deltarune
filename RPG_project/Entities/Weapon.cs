using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    internal class Weapon
    {
        private string name;
        private int cost;
        private int attackBonus;
        public Weapon(string name , int cost,int attackBonus) 
        { 
            this.name= name;
            this.cost = cost;
            this.attackBonus= attackBonus;
        }
        public string getName()
        {
            return this.name;
        }
        public int getCost() 
        { 
            return this.cost;
        }
        public int getAttackBonus() 
        {
            return this.attackBonus;
        }
    }
    
}
