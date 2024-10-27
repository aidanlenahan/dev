using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spaceInvaders
{
    internal class Tank
    {
        Texture2D theTank;
        Rectangle theTankRect;
        private readonly int tankSpeed = 10;
        public int maxX = 1510;
        //private int maxY = 900;

        public Tank(Game theGame)
        {
            theTank = theGame.Content.Load<Texture2D>("tank");
            theTankRect = new Rectangle(750, 750, 90, 120);
        }

        public void Left()
        {
            if (theTankRect.X > 0)
            {
                theTankRect.X -= tankSpeed;
            }
        }

        public void Right()
        {
            if (theTankRect.X < maxX)
            {
                theTankRect.X += tankSpeed;
            }
        }

        public Rectangle GetRect()
        {
            return theTankRect;
        }

        public void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(theTank, theTankRect, Color.White);
        }
    }
}
