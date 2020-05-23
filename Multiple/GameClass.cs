using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    class GameClass
    {
        public delegate void onEvent(object sender);
        public delegate void onEror(string message);
        public event onEvent OnChenge;
        public event onEvent OnLoose;
        public event onEvent OnWin;
        public event onEvent OnStart;
        public event onEror OnError;

        int target;
        int current;
        int steps;
        int maxSteps;
        Stack<int> history = new Stack<int>();

        /// <summary>
        /// Возвращает целевое значение
        /// </summary>
        public int Target
        {
            get { return target; }
        }
        /// <summary>
        /// Возвращает максимум шагов за которое надо добиться целевого значения
        /// </summary>
        public int MaxSteps
        {
            get { return maxSteps; }
        }
        /// <summary>
        /// Возвращает текущее значение
        /// </summary>
        public int Current
        {
            get { return current; }
            set
            {
                current = value;
                history.Push(value);
                if (!(OnChenge is null))
                    OnChenge(this);
                if (current == target)
                    if (!(OnWin is null))
                        OnWin(this);
            }
        }
        /// <summary>
        /// Возвращает текущее количество шагов
        /// </summary>
        public int Steps
        {
            get { return steps; }
            set
            {
                steps = value;
                if (steps > maxSteps)
                    if (!(OnLoose is null))
                        OnLoose(this);
            }
        }

        /// <summary>
        /// Начинает игру
        /// </summary>
        public void Start()
        {
            Random rnd = new Random();
            target = rnd.Next(500);
            maxSteps = countSteps(target);
            Current = 1;
            
            if (!(OnStart is null))
                OnStart(this);
        }

        /// <summary>
        /// Сбрасывает игру на начало
        /// </summary>
        public void Reset()
        {
            history.Clear();
            Steps = 0;
            Current = 1;
        }

        /// <summary>
        /// Отменяет последнее действие
        /// </summary>
        public void Undo()
        {
            if (steps <= 0)
                steps = 0;
            else steps--;

            if (history.Count > 1)
            {
                history.Pop();
                current = history.Peek();
                if (!(OnChenge is null))
                    OnChenge(this);
            }
            else
            {
                if (!(OnError is null))
                    OnError("Больше нельзя отменять действия");
            }
        }

        /// <summary>
        /// Плюс 1
        /// </summary>
        public void PlusOne()
        {
            Steps++;
            Current++;
        }

        /// <summary>
        /// Умножить на 2
        /// </summary>
        public void MultipднByTwo()
        {
            Steps++;
            Current *= 2;
        }

        int countSteps(int value)
        {
            int result = 0;
            do
            {
                if (value % 2 == 0)
                    value /= 2;
                else value -= 1;
                result++;
            } while (value != 1);
            return result;
        }
    }
}
