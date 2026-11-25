using RPG_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Entities
{
    public class Player : BaseCharacter
    {
        protected int _levelCup = 1000;
        protected int _expirience = 0;
        protected int _strength = 0;
        protected int _endurance = 0;
        protected int _agility = 0;
        protected int _intelligence = 0;

        public ChangingValue MP;

        protected int _gold = 0;
        protected Weapon _weapon = null;
        protected Armor _armor = null;

        public Player(string name) : base(name, 1)
        {
            this._strength = 20;
            this._endurance = 10;
            this._agility = 16;
            this._intelligence = 16;
            

            this.HP = new ChangingValue(this._endurance * 200);
            this.MP = new ChangingValue(this._intelligence * 100);
        }

        public void AddWeapon(Weapon weapon)
        {
            this._weapon = weapon;
        }
        public void AddArmor(Armor armor)  
        {
            this._armor = armor;
        }
        public bool SpendGold(int amount)
        {
            if (_gold >= amount)
            {
                _gold -= amount;
                return true;
            }
            return false;
        }

        public int Attack()
        {
            int attack = this._strength;

            if (_weapon != null)
            {
                attack += _weapon.GetDamage();
            }

            if (this._agility / 2 <= CustomRandom.GetRandomNumber(1, 100))
            {
                attack *= 2;
            }

            return attack;
        }
        public int getLevel()
        {
            return this._level;
        }

        public int getLevelCup()
        {
            return this._levelCup;
        }

        public int getExperience()
        {
            return this._expirience;
        }

        public int getStrength()
        {
            return this._strength;
        }

        public int getEndurance()
        {
            return this._endurance;
        }

        public int getAgility()
        {
            return this._agility;
        }

        public int getIntelligence()
        {
            return this._intelligence;
        }

        

        
        public int getGold()
        {
            return this._gold;
        }
        public Weapon getWeapon()
        {
            return this._weapon;
        }

        public Armor getArmor()
        {
            return this._armor;
        }
        public int TakeDamage(int enemyAttack)
        {
            int defence = 0;
            if (_armor != null)
            {
                defence = _armor.GetDefence();
            }

            int finalDamage = enemyAttack - defence;
            if (finalDamage < 1) finalDamage = 1;

            HP.Decrease(finalDamage);
            return finalDamage;
        }
        public int NormalAttack()
        {
          
            MP.Decrease(15);
            return Attack();
        }
        public int HeavyAttack()
        {
            int heavyAttack = Attack() * 2;
            return heavyAttack;
        }
        public void AddReward(int gold, int exp)
        {
            _gold += gold;
            _expirience += exp;
            if (_expirience >= _levelCup)
            {
                _expirience -= _levelCup;
                _level++;
                _levelCup += 500;
                _strength += 3;
                _endurance += 2;
                _agility += 2;
                _intelligence += 2;
                HP.ChangeMax(_endurance * 200);
                MP.ChangeMax(_intelligence * 100);
            }

        }
        public void ChangeGold(int amount)
        {
            _gold += amount;
            if (_gold < 0) _gold = 0;
        }

        public void ChangeStrength(int amount)
        {
            _strength += amount;
            if (_strength < 1) _strength = 1;
        }

        public void ChangeEndurance(int amount)
        {
            _endurance += amount;
            if (_endurance < 1) _endurance = 1;
            HP.ChangeMax(_endurance * 200);
        }
        public void ChangeAgility(int amount)
        {
            _agility += amount;
            if (_agility < 1) _agility = 1;
        }
        public void ChangeIntelligence(int amount)
        {
            _intelligence += amount;
            if (_intelligence < 1) _intelligence = 1;
            MP.ChangeMax(_intelligence * 100);
        }
    }   

}
