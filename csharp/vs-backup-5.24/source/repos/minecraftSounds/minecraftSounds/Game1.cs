using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minecraftSounds
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        SoundEffect zombie;
        SoundEffect villager;
        SoundEffect dirt;
        SoundEffect creeper;

        KeyboardState oldkb1;

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
            villager = Content.Load<SoundEffect>("villager");
            zombie = Content.Load<SoundEffect>("zombie");
            dirt = Content.Load<SoundEffect>("dirt");
            creeper = Content.Load<SoundEffect>("creeper");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            //TO DO
            //import all four sounds in Content.mgcb
            //make an if statment for each sound
            
            KeyboardState kb1 = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //WILL ONLY FIRE SOUND IF KEY GOES DOWN AND ONLY AFTER KEY COMES BACK UP
            
            //creeper sound; c
            if (kb1.IsKeyDown(Keys.C))
            {
                oldkb1 = kb1;
            }
            if (oldkb1.IsKeyDown(Keys.C) && kb1.IsKeyUp(Keys.C))
            {
                creeper.Play();
            }

            //dirt sound; d
            if (kb1.IsKeyDown(Keys.D))
            {
                oldkb1 = kb1;
            }
            if (oldkb1.IsKeyDown(Keys.D) && kb1.IsKeyUp(Keys.D))
            {
                dirt.Play();
            }

            //villager sound; v
            if (kb1.IsKeyDown(Keys.V))
            {
                oldkb1 = kb1;
            }
            if (oldkb1.IsKeyDown(Keys.V) && kb1.IsKeyUp(Keys.V))
            {
                villager.Play();
            }

            //zombie sound; z
            if (kb1.IsKeyDown(Keys.Z))
            {
                oldkb1 = kb1;
            }
            if (oldkb1.IsKeyDown(Keys.Z) && kb1.IsKeyUp(Keys.Z))
            {
                zombie.Play();
            }

            oldkb1 = kb1;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
