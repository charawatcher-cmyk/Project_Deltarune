using RPG_project.Entities;
using RPG_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.GameServices
{
    public  class ItemGenerator
    {
        protected string[] Names;
        Func<string, int, int, BaseItem> createItem;
        public ItemGenerator(string[] names, Func<string, int, int, BaseItem> createItem) 
        {
            this.Names = names;
            this.createItem = createItem;

        }
        public BaseItem CreateOne()
        {
            int value = CustomRandom.GetRandomNumber(5, 100);
            int price = value * 20;
            string name = Names[CustomRandom.GetRandomNumber(0, Names.Length - 1)];
            return createItem(name, price, value);
        }
        public List<BaseItem> CreateMany(int count)
        {
            List<BaseItem> items = new List<BaseItem>();
            for (int i = 0; i < count; i++)
            {
                items.Add(CreateOne());
            }

            return items;
        }


    }
}
