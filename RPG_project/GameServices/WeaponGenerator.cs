using RPG_project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_project.GameServices
{
    internal class WeaponGenerator: ItemGenerator
    {
        
        private  static string[] _name = { "Twisted Sword", "Devilsknife", "Auto Axe", "Aqua Knife", "Winglade", "Freeze Ring", "Justice Axe", "Bounce Blade", "Mane Axe", "Mecha Saber" };
        public WeaponGenerator() : base(_name, (name, price, attack) => new Weapon(name, price, attack))
        {
        }
        
    }
}
