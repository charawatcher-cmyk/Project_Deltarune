using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project.Utils
{
    public class ChangingValue
    {
        private int _min;
        private int _max;
        private int _current;

        public ChangingValue(int max, int min = 0)
        {
            this._min = min;
            this._max = max;
            this._current = this._max;
        }

        public void ChangeMax(int max)
        {
            this._max = max;
            this._current = this._max;
        }

        public int GetCurrent() => _current;
        public int GetMax() => _current;

        public void Increase(int amount)
        {
            this._current += amount;

            if (this._max < this._current)
                this._current = this._max;
        }

        public void Decrease(int amount)
        {
            this._current -= amount;

            if (this._min < this._current)
                this._current = this._min;
        }

    }
}
