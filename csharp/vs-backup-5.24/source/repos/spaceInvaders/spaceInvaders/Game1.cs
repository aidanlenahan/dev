using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spaceInvaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private readonly int maxX = 1600;
        private readonly int maxY = 900;
        Tank theTank;
        Jag theJag;
        SoundEffect death;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            //NEW
            _graphics.PreferredBackBufferWidth = maxX;
            _graphics.PreferredBackBufferHeight = maxY;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            theTank = new Tank(this);
            theJag = new Jag(this);
            death = Content.Load<SoundEffect>("death");
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();

            theJag.Move();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (kb.IsKeyDown(Keys.R))
            {
                theJag.Reset();
            }

            if (kb.IsKeyDown(Keys.Left))
            {
                theTank.Left();
            }
            if (kb.IsKeyDown(Keys.Right))
            {
                theTank.Right();
            }
            // TODO: Add your update logic here

            if (theJag.GetRect().Intersects(theTank.GetRect()))
            {
                theJag.Reset();
                death.Play();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            theTank.Draw(_spriteBatch);
            theJag.Draw(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
