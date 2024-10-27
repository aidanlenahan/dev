using Microsoft.Win32.SafeHandles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Runtime.CompilerServices;
using System.Threading;

//room layout
//https://docs.google.com/drawings/d/1qmT1pRedD2X1Y4UafcYB3vFS6vKof7WCTOrOsW5xOqI/edit?usp=sharing

namespace adventure
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D player;
        private Rectangle playerRect;
        private int room = 0;
        private int speed = 25;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1600;
            _graphics.PreferredBackBufferHeight = 900;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player = this.Content.Load<Texture2D>("dvd");
            playerRect = new Rectangle(0, 0, 100, 41);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                playerRect.X += speed;
                if (room == 0)
                {
                    if (playerRect.X > 1584)
                    {
                        room = 3;
                        playerRect.X = 0;
                    }
                }
                if (room == 1)
                {
                    if (playerRect.X > 1584)
                    {
                        room = 0;
                        playerRect.X = 0;
                    }
                }
                //RIGHT BORDER LOGIC
                if (room == 3 || room == 2 || room == 4 || room == 5)
                {
                    if (playerRect.X > 1500) //MAX X-COORDINATE HAS TO BE MODIFIED FROM 1584 DUE TO SIZE OF IMG
                    {
                        playerRect.X = 1500;
                    }
                }
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                playerRect.X -= speed;
                if (room == 0)
                {
                    if (playerRect.X < 0)
                    {
                        room = 1;
                        playerRect.X = 1584;
                    }
                }
                if (room == 3)
                {
                    if (playerRect.X < 0)
                    {
                        room = 0;
                        playerRect.X = 1584;
                    }
                }
                //LEFT BORDER LOGIC
                if (room == 1 || room == 2 || room == 4 || room == 5)
                {
                    if (playerRect.X < 0)
                    {
                        playerRect.X = 0;
                    }
                }
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                playerRect.Y -= speed;
                if (room == 0)
                {
                    if (playerRect.Y < 0)
                    {
                        room = 2;
                        playerRect.Y = 860;
                    }
                }
                if (room == 4)
                {
                    if (playerRect.Y < 0)
                    {
                        room = 0;
                        playerRect.Y = 860;
                    }
                }
                if (room == 5)
                {
                    if (playerRect.Y < 0)
                    {
                        room = 4;
                        playerRect.Y = 860;
                    }
                }
                //UPPER BORDER LOGIC
                if (room == 1 || room == 2 || room == 3)
                {
                    if (playerRect.Y < 0)
                    {
                        playerRect.Y = 0;
                    }
                }
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                playerRect.Y += speed;
                if (room == 0)
                {
                    if (playerRect.Y > 860)
                    {
                        room = 4;
                        playerRect.Y = 0;
                    }
                }
                if (room == 4)
                {
                    if (playerRect.Y > 860)
                    {
                        room = 5;
                        playerRect.Y = 0;
                    }
                }
                if (room == 2)
                {
                    if (playerRect.Y > 860)
                    {
                        room = 0;
                        playerRect.Y = 0;
                    }
                }
                //BOTTOM BORDER LOGIC
                if (room == 1 || room == 3 || room == 5)
                {
                    if (playerRect.Y > 837) //MAX X-COORDINATE HAS TO BE MODIFIED FROM 860 DUE TO SIZE OF IMG
                    {
                        playerRect.Y = 837;
                    }
                }

                // TODO: Add your update logic here
            }
            
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here

            if (room == 0)
            {
                GraphicsDevice.Clear(Color.CornflowerBlue);
            }
            if (room == 1)
            {
                GraphicsDevice.Clear(Color.HotPink);
            }
            if (room == 2)
            {
                GraphicsDevice.Clear(Color.DarkRed);
            }
            if (room == 3)
            {
                GraphicsDevice.Clear(Color.Azure);
            }
            if (room == 4)
            {
                GraphicsDevice.Clear(Color.PeachPuff);
            }
            if (room == 5)
            {
                GraphicsDevice.Clear(Color.Violet);
            }

            _spriteBatch.Begin();
            _spriteBatch.Draw(player, playerRect, Color.White);
            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
