using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace fpsGame.Content
{
    internal class Player
    {
        Texture2D playerTexture;
        Rectangle playerRect;
        int playerSpeed = 5;
        int maxX = 1600;
        int maxY = 900;

        public Player(Game theGame)
        {
            playerTexture = theGame.Content.Load<Texture2D>("player");
            playerRect = new Rectangle(25, 25, 32, 32);
        }

        public void Left()
        {
            if (playerRect.X > 0)
            {
                playerRect.X -= playerSpeed;
            }
        }
        public void Right()
        {
            if (playerRect.X < maxX - 35)
            {
                playerRect.X += playerSpeed;
            }
        }
        public void Up()
        {
            if (playerRect.Y > 0)
            {
                playerRect.Y -= playerSpeed;
            }
        }
        public void Down()
        {
            if (playerRect.Y < maxY - 35)
            {
                playerRect.Y += playerSpeed;
            }
        }
        public Rectangle GetRect()
        {
            return playerRect;
        }

        public void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(playerTexture, playerRect, Color.White);
        }
    }
}
