using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public abstract class BaseItem : BaseEntity
    {
        protected int _price;
        protected int _value;

        public BaseItem(string name, int price, int value) : base(name)
        {
            _price = price;
            _value = value;
        }

        public int GetPrice() => _price;
        public int GetValue() => _value;

    }
}
