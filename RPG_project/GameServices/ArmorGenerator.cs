using RPG_project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_project.GameServices
{
    internal class ArmorGenerator: ItemGenerator
    {
        private static string[] _name = { "Shadow Mantle", "TennaTie", "GoldWidow", "Seth Specs", "LodeStone", "Royal Pin", "Spike Band", "Blue Ribbon", "Chain Mail", "Amber Card","Deal Maker" };
        public ArmorGenerator() : base(_name, (name, price, attack) => new Armor(name, price, attack))
        {

        }
    }

}
