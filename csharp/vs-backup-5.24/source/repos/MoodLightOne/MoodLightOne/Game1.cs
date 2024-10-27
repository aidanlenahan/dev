using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MoodLightOne
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        byte red;
        byte green;
        byte blue;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            red = 0;
            green = 0;
            blue = 0;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.R) || (GamePad.GetState(PlayerIndex.One).Buttons.B == ButtonState.Pressed))
            {
                red++;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.G) || (GamePad.GetState(PlayerIndex.One).Buttons.A == ButtonState.Pressed))
            {
                green++;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.B) || (GamePad.GetState(PlayerIndex.One).Buttons.X == ButtonState.Pressed))
            {
                blue++;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad0) || (GamePad.GetState(PlayerIndex.One).Buttons.Y == ButtonState.Pressed))
            {
                red = 0;
                green = 0;
                blue = 0;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed)
            {
                red--;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed)
            {
                green--;
            }
            if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed)
            {
                blue--;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            Color backColor = new Color(red, green, blue);
            GraphicsDevice.Clear(backColor);

            // TODO: Add your drawing code here
            
            base.Draw(gameTime);
        }
    }
}