using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace chase
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D rbr;
        private Rectangle rbrRect;
        private Texture2D rfh;
        private Rectangle rfhRect;
        private int rbrSpeed = 16;
        private int rfhSpeed = 16;
        private Color[] bgColor = {Color.CornflowerBlue, Color.Blue, Color.Black, Color.Pink, Color.Red, Color.Purple, Color.Yellow, Color.SeaGreen, Color.Silver, Color.LightBlue};
        private int bgColorIndex;
        int score = 0;

        KeyboardState oldkb;

        SoundEffect coin;
        SoundEffect explosion;

        SpriteFont scoreFont;
        SpriteFont smallFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //ADDED CODE FOR FULLSCREEN
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1600;
            _graphics.PreferredBackBufferHeight = 900;
            _graphics.ApplyChanges();
            bgColorIndex = new Random().Next(0, bgColor.Length);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rbr = this.Content.Load<Texture2D>("rbr");
            rbrRect = new Rectangle(200, 410, 100, 100);
            rfh = this.Content.Load<Texture2D>("rfh");
            rfhRect = new Rectangle(1300, 410, 100, 100);
            scoreFont = Content.Load<SpriteFont>("scoreFont");
            score = 0;

            smallFont = Content.Load<SpriteFont>("smallFont");
            coin = Content.Load<SoundEffect>("coin");
            explosion = Content.Load<SoundEffect>("explosion");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            //RESET FUNCTIONALITY
            if (kb.IsKeyDown(Keys.Enter))
            {
                oldkb = kb;
            }
            if (oldkb.IsKeyDown(Keys.Enter) && kb.IsKeyUp(Keys.Enter))
            {
                explosion.Play();
                score = 0;
                rfhRect.X = 1300;
                rfhRect.Y = 410;
                rbrRect.X = 200;
                rbrRect.Y = 410;
                bgColorIndex = new Random().Next(0, bgColor.Length);
            }
            //TO CHANGE BG COLOR
            if (kb.IsKeyDown(Keys.C))
            {
                oldkb = kb;
            }
            if (oldkb.IsKeyDown(Keys.C) && kb.IsKeyUp(Keys.C))
            {
                bgColorIndex = new Random().Next(0, bgColor.Length);
            }
            //comment out following line for seizure
            oldkb = kb;

            //rbr controls
            if (kb.IsKeyDown(Keys.D))
            {
                rbrRect.X += rbrSpeed;
            }
            if (kb.IsKeyDown(Keys.W))
            {
                rbrRect.Y -= rbrSpeed;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                rbrRect.X -= rbrSpeed;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                rbrRect.Y += rbrSpeed;
            }

            //rfh controls
            if (kb.IsKeyDown(Keys.Right))
            {
                rfhRect.X += rfhSpeed;
            }
            if (kb.IsKeyDown(Keys.Up))
            {
                rfhRect.Y -= rfhSpeed;
            }
            if (kb.IsKeyDown(Keys.Left))
            {
                rfhRect.X -= rfhSpeed;
            }
            if (kb.IsKeyDown(Keys.Down))
            {
                rfhRect.Y += rfhSpeed;
            }

            //rbr borders
            if (rbrRect.X < 0)
            {
                rbrRect.X = 0;
            }
            if (rbrRect.X > 1500) //def 1550
            {
                rbrRect.X = 1500;
            }
            if (rbrRect.Y < 0)
            {
                rbrRect.Y = 0;
            }
            if (rbrRect.Y > 820) //def 828
            {
                rbrRect.Y = 820;
            }

            //rfh borders
            if (rfhRect.X < 0)
            {
                rfhRect.X = 0;
            }
            if (rfhRect.X > 1550)
            {
                rfhRect.X = 1550;
            }
            if (rfhRect.Y < 0)
            {
                rfhRect.Y = 0;
            }
            if (rfhRect.Y > 828)
            {
                rfhRect.Y = 828;
            }
            //1550 and 828
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //COLLISION AND SCORE LOGIC
            if (rbrRect.Intersects(rfhRect))
            {
                score++;
                rfhRect.X = 1300;
                rfhRect.Y = 410;
                rbrRect.X = 200;
                rbrRect.Y = 410;

                if (bgColorIndex >= bgColor.Length - 1)
                {
                    bgColorIndex = 0;
                }
                else
                {
                    bgColorIndex++;
                }
                coin.Play();
            }
            GraphicsDevice.Clear(bgColor[bgColorIndex]);

            _spriteBatch.Begin();
            _spriteBatch.Draw(rbr, rbrRect, Color.White);
            _spriteBatch.Draw(rfh, rfhRect, Color.White);
            _spriteBatch.DrawString(scoreFont, "Score:", new Vector2(10, 10), Color.White);
            _spriteBatch.DrawString(scoreFont, score.ToString(), new Vector2(140, 10), Color.White); //score var display on screen at x150 y100

            _spriteBatch.DrawString(smallFont, "Press enter to reset ; WASD and arrow keys to control", new Vector2(1220, 5), Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
