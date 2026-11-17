using RPG_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public abstract class BaseCharacter : BaseEntity
    {
        protected int _level;
        public ChangingValue HP;

        public BaseCharacter(string name, int level) : base(name)
        {
            this._level = level;
        }
    }
}
