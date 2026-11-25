using RPG_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public class Enemy : BaseCharacter
    {
        protected int _attack = 0;
        protected int _defense = 0;
        protected int _rewardGold = 0;
        protected int _rewardXp = 0;
        protected string _specialAbility;

        public Enemy(string name, int level, string specialAbility) : base(name, level)
        {
            _attack = 25 * level;
            _defense = 10 * level;
            this.HP = new ChangingValue(level * 500);

            _rewardGold = 20 * level;
            _rewardXp = 50 * level;
            _specialAbility = specialAbility;
        }
        public int TakeDamage(int playerAttack)
        {
            int finalDamage = playerAttack - _defense;
            if (finalDamage < 1) finalDamage = 1;

            HP.Decrease(finalDamage);
            return finalDamage;
        }
        public int Attack()
        {
            return _attack + CustomRandom.GetRandomNumber(0, 5);
        }
        public int PowerStrike()
        {
            return _attack * 2;
        }
        public int Heal()
        {
            int healAmount = 40 * _level;
            HP.Increase(healAmount);
            return healAmount;
        }
        public string GetSpecialAbility() => _specialAbility;
        public int GetAttack() => _attack;
        public int getLevel() => _level;
        public int GetDefense() => _defense;
        public int GetRewardGold() => _rewardGold;
        public int GetRewardXp() => _rewardXp;

    }

}
