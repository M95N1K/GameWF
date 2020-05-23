using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameWF
{
    class BatleShip 
    {
        Rectangle box;
        public delegate void onEvent();
        public event onEvent OnResize;
        public event onEvent OnHit;
        public int Top
        {
            get { return box.Y; }
            set { 
                box.Y = value;
                if (!(OnResize is null))
                    OnResize();
            }
        }
        public int Left
        {
            get { return box.X; }
            set
            {
                box.X = value;
                if (!(OnResize is null))
                    OnResize();
            }
        }
        public int Height
        {
            get { return box.Height; }
            set
            {
                box.Height = value;
                if (!(OnResize is null))
                    OnResize();
            }
        }
        public int Width
        {
            get { return box.Width; }
            set
            {
                box.Width = value;
                if (!(OnResize is null))
                    OnResize();
            }
        }
        //public string Tag;

        public BatleShip()
        { }

        public void SetRectangle(int Left , int Top, int Height , int Width)
        {
            this.Top = Top;
            this.Left = Left;
            this.Height = Height;
            this.Width = Width;
        }

        /// <summary>
        /// Определяет пересечение текущего объекта с указанным в ship.
        /// При обнаружении пересечения вызывает OnHit обоих объектов.
        /// </summary>
        /// <param name="value">Объект с которым проверяется пересечение</param>
        /// <returns></returns>
        public void IsIntersection(BatleShip value)
        {
            if (box.IntersectsWith(value.box))
            {
                if (!(value.OnHit is null))
                    value.OnHit();
                if (!(this.OnHit is null))
                    this.OnHit();
            }
        }
    }
}
