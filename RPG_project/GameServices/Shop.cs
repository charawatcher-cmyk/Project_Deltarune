using RPG_project.Entities;
using RPG_project.Utils;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_project.GameServices
{
    public class Shop
    {
        protected string _shopText;
        protected List<BaseItem> _items;
        protected ItemGenerator _generator;
        public Shop()
        {
            int choice = CustomRandom.GetRandomNumber(0, 1);
            if (choice == 0)
            {
                _shopText = "Магазин зброї";
                _generator = new WeaponGenerator();
            }
            else
            {
                _shopText = "Магазин броні";
                _generator = new ArmorGenerator();
            }
            _items = new List<BaseItem>();
            GenerateItems();
        }
        public void GenerateItems()
        {
            _items = _generator.CreateMany(5);
        }
        public bool Buy(Player player, BaseItem item) 
        { 
            if(item == null)
            {
                return false;
            }
            else if (player.getGold()>=item.GetPrice())
            {
                player.SpendGold(item.GetPrice());

                if (item is Weapon)
                {
                    player.AddWeapon((Weapon)item);
                }
                else if (item is Armor)
                {
                    player.AddArmor((Armor)item);
                }
                _items.Remove(item);
                MessageBox.Show("Ви купили "+  item.GetName() + "!", "Покупка успішна!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            else 
            { 

                MessageBox.Show("У вас не вистачає коштів!", "Не вийшло купити предмет!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            
        }
        public string getShopTexte()
        {
            return this._shopText;
        }

        public List<BaseItem> getItems()
        {
            return this._items;
        }

    }
}
