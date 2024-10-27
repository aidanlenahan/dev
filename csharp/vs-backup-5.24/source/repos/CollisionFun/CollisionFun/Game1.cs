using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading.Tasks.Sources;

namespace CollisionFun
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int lilGuySpeed = 4;
        private int badLilGuySpeed = 4;
        int score = 0;
        Texture2D lilGuy;
        Rectangle lilGuyRect;
        Texture2D badLilGuy;
        Rectangle badLilGuyRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
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

            lilGuy = Content.Load<Texture2D>("lilGuy");
            lilGuyRect = new Rectangle(700, 300, 16, 16);

            badLilGuy = Content.Load<Texture2D>("badlilguy");
            badLilGuyRect = new Rectangle(50, 10, 16, 16);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            // TODO: Add your update logic here
            
            //lilGuy controls
            if (kb.IsKeyDown(Keys.Right))
            {
                lilGuyRect.X += lilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.Up))
            {
                lilGuyRect.Y -= lilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.Left))
            {
                lilGuyRect.X -= lilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.Down))
            {
                lilGuyRect.Y += lilGuySpeed;
            }

            //badLilGuy controls
            if (kb.IsKeyDown(Keys.D))
            {
                badLilGuyRect.X += badLilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.W))
            {
                badLilGuyRect.Y -= badLilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                badLilGuyRect.X -= badLilGuySpeed;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                badLilGuyRect.Y += badLilGuySpeed;
            }
            if (lilGuyRect.Intersects(badLilGuyRect))
            {
                score++;
                badLilGuyRect.X = 50;
                badLilGuyRect.Y = 50;
                lilGuyRect.X = 700;
                lilGuyRect.Y = 50;
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(lilGuy, lilGuyRect, Color.White); //Color.White here means no tint; third parameter is tint
            _spriteBatch.Draw(badLilGuy, badLilGuyRect, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
