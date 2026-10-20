using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(GameManager.instance != null, "Game Manager instance should never be null.");
            Debug.Assert(GameManager.instance.Map != null, "Game Manager Map should never be null.");
            Y = y;
            X = x;
            Icon = icon;
            if (X < 0)
            {
                X = 0;
            }
            else if (X > GameManager.instance.Map._map.GetLength(1)-1)
            {
                X = GameManager.instance.Map._map.GetLength(1)-1;
            }
            if (Y < 0)
            {
                Y = 0;
            }
            else if (Y > GameManager.instance.Map._map.GetLength(0) - 1)
            {
                Y = GameManager.instance.Map._map.GetLength(0) - 1;
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
            else if (X > GameManager.instance.Map._map.GetLength(1)-1)
            {
                X = GameManager.instance.Map._map.GetLength(1)-1;
            }
            if (Y < 0)
            {
                Y = 0;
            }
            else if (Y > GameManager.instance.Map._map.GetLength(0) - 1)
            {
                Y = GameManager.instance.Map._map.GetLength(0) - 1;
            }
        }
    }
}
