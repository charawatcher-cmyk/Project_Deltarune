using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public class Armor : BaseItem
    {
        public Armor(string name, int price, int defence) : base(name, price, defence)
        {
        }

        public int GetDefence() => _value;
    }
}  



