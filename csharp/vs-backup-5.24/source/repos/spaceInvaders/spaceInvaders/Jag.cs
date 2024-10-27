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
    internal class Jag
    {
        Texture2D theJag;
        Rectangle theJagRect;
        private int initJagSpeed = 35; //initial / default speed, will reset to this each time
        private int jagSpeed = 35; //rolling speed, will change

        public Jag(Game theGame)
        {
            theJag = theGame.Content.Load<Texture2D>("jag");
            theJagRect = new Rectangle(70, 15, 100, 100);
        }

        public void Move()
        {
            theJagRect.X += jagSpeed;
            if (theJagRect.X < 0) //right
            {
                jagSpeed = -jagSpeed; //move opposite
                theJagRect.Y += 50;
                jagSpeed += 1;
            }
            if (theJagRect.X > 1510) //left
            {
                jagSpeed = -jagSpeed; //move opposite
            }
        }

        public void Reset()
        {
            jagSpeed = initJagSpeed; //resets rolling speed to default
            theJagRect.X += jagSpeed; //moves rect to default speed
            theJagRect.X = 70;
            theJagRect.Y = 15;
        }

        public Rectangle GetRect()
        {
            return theJagRect;
        }

        public void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(theJag, theJagRect, Color.White);
        }
    }
}
