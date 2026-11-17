using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public class Weapon : BaseItem
    {
        public Weapon(string name, int price, int damage) : base(name, price, damage)
        {
        }

        public int GetDamage() => _value;
    }

}
