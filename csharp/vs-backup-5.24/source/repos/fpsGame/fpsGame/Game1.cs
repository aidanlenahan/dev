using fpsGame.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace fpsGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public int maxX = 1600;
        public int maxY = 900;
        Player thePlayer;
        Enemy theEnemy;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = maxX;
            _graphics.PreferredBackBufferHeight = maxY;
            _graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            thePlayer = new Player(this);
            theEnemy = new Enemy(this);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState kb = Keyboard.GetState();

            //borders and move controls
            if (kb.IsKeyDown(Keys.W))
                thePlayer.Up();
            if (kb.IsKeyDown(Keys.S))
                thePlayer.Down();
            if (kb.IsKeyDown(Keys.A))
                thePlayer.Left();
            if (kb.IsKeyDown(Keys.D))
                thePlayer.Right();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            thePlayer.Draw(_spriteBatch);
            theEnemy.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
