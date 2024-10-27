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
    internal class Enemy
    {
        Texture2D enemyTexture;
        Rectangle enemyRect;
        private int enemySpeed = 35;

        public Enemy(Game theGame)
        {
            enemyTexture = theGame.Content.Load<Texture2D>("enemy");
            enemyRect = new Rectangle(1500, 850, 32, 32);
        }

        public void Move()
        {
            
        }

        public Rectangle GetRect()
        {
            return enemyRect;
        }

        public void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(enemyTexture, enemyRect, Color.White);
        }
    }
}
