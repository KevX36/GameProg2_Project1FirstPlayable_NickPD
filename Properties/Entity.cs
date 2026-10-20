using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg2_Project1FirstPlayable_NickPD
{
    public abstract class Entity
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Icon { get; set; }
        public Entity(int x, int y, char icon) 
        {
            Y = y;
            X = x;
            Icon = icon;
            if(X < 0)
            {
                X = 0;
            }
            else if(X > GameManager.Map._map.Length)
            {
                X = GameManager.Map._map.Length;
            }
            if (Y < 0)
            {
                Y = 0;
            }
            else if (Y > GameManager.Map._map.GetLength(1))
            {
                Y = GameManager.Map._map.Length;
            }
        }
        public void SetPosition(int newX, int newY)
        {
            X = newX;
            Y = newY;
            if (X < 0)
            {
                X = 0;
            }
            else if (X > GameManager.Map._map.Length)
            {
                X = GameManager.Map._map.Length;
            }
            if (Y < 0)
            {
                Y = 0;
            }
            else if (Y > GameManager.Map._map.GetLength(1))
            {
                Y = GameManager.Map._map.Length;
            }
        }
    }
}
