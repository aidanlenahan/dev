using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Drawing.Text;

namespace FlappyBird
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D bgTexture;
        Texture2D downPipeTexture;
        Texture2D upPipeTexture;

        Rectangle downPipe1Rect, downPipe2Rect, downPipe3Rect;
        Rectangle upPipe1Rect, upPipe2Rect, upPipe3Rect;

        int upPipeOneHeight;
        int upPipeTwoHeight;
        int upPipeThreeHeight;

        const int pipeGap = 700; // Gap between upper and lower pipes
        const int pipeDistance = 300; // Distance between two adjacent pipes


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            // Set fullscreen mode
            graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {
            RandomPipeHeight(4);
            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            bgTexture = Content.Load<Texture2D>("bg");
            // Load pipe textures
            downPipeTexture = Content.Load<Texture2D>("downpipe");
            upPipeTexture = Content.Load<Texture2D>("uppipe");

            // Define the position and size of each pipe
            upPipe1Rect = new Rectangle(GraphicsDevice.Viewport.Width, upPipeOneHeight, 50, 500); // Adjust width and height as needed
            upPipe2Rect = new Rectangle(GraphicsDevice.Viewport.Width + pipeDistance, upPipeTwoHeight, 50, 500); // Adjust width and height as needed
            upPipe3Rect = new Rectangle(GraphicsDevice.Viewport.Width + pipeDistance * 2, upPipeThreeHeight, 50, 500); // Adjust width and height as needed
            
            downPipe1Rect = new Rectangle(GraphicsDevice.Viewport.Width, upPipeOneHeight + pipeGap, 50, 500); // Adjust width and height as needed
            downPipe2Rect = new Rectangle(GraphicsDevice.Viewport.Width + pipeDistance, upPipeTwoHeight + pipeGap, 50, 500); // Adjust width and height as needed
            downPipe3Rect = new Rectangle(GraphicsDevice.Viewport.Width + pipeDistance * 2, upPipeThreeHeight + pipeGap, 50, 500); // Adjust width and height as needed
        }

        private void RandomPipeHeight(int currentPipe)
        {
            Random random = new Random();

            // Generate random heights for up pipes
            if (currentPipe == 1 || currentPipe == 4)
            {
                upPipeOneHeight = random.Next(-400, GraphicsDevice.Viewport.Height - 700); // Adjust min and max heights as needed
                upPipe1Rect.Y = upPipeOneHeight;
            }
            if (currentPipe == 2 || currentPipe == 4)
            {
                upPipeTwoHeight = random.Next(-400, GraphicsDevice.Viewport.Height - 700); // Adjust min and max heights as needed
                upPipe2Rect.Y = upPipeTwoHeight;

            }
            if (currentPipe == 3 || currentPipe == 4)
            {
                upPipeThreeHeight = random.Next(-400, GraphicsDevice.Viewport.Height - 700); // Adjust min and max heights as needed
                upPipe3Rect.Y = upPipeThreeHeight;

            }
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Move the pipes
            MovePipes();

            base.Update(gameTime);
        }

        private void MovePipes()
        {
            int pipeSpeed = 3; // Adjust the speed as needed

            // Move pipes to the left
            downPipe1Rect.X -= pipeSpeed;
            downPipe2Rect.X -= pipeSpeed;
            downPipe3Rect.X -= pipeSpeed;

            upPipe1Rect.X -= pipeSpeed;
            upPipe2Rect.X -= pipeSpeed;
            upPipe3Rect.X -= pipeSpeed;

            // Check if pipes moved out of the screen, then reset their positions
            if (downPipe1Rect.Right < 0)
            {
                downPipe1Rect.X = GraphicsDevice.Viewport.Width;
                RandomPipeHeight(1);
            }

            if (downPipe2Rect.Right < 0)
            {
                downPipe2Rect.X = GraphicsDevice.Viewport.Width;
                RandomPipeHeight(2);
            }

            if (downPipe3Rect.Right < 0)
            {
                downPipe3Rect.X = GraphicsDevice.Viewport.Width;
                RandomPipeHeight(3);
            }

            if (upPipe1Rect.Right < 0)
                upPipe1Rect.X = GraphicsDevice.Viewport.Width;

            if (upPipe2Rect.Right < 0)
                upPipe2Rect.X = GraphicsDevice.Viewport.Width;

            if (upPipe3Rect.Right < 0)
                upPipe3Rect.X = GraphicsDevice.Viewport.Width;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            //bg
            //spriteBatch.Draw(bgTexture, Color.White);
            // Draw pipes
            spriteBatch.Draw(downPipeTexture, downPipe1Rect, Color.White);
            spriteBatch.Draw(downPipeTexture, downPipe2Rect, Color.White);
            spriteBatch.Draw(downPipeTexture, downPipe3Rect, Color.White);

            spriteBatch.Draw(upPipeTexture, upPipe1Rect, Color.White);
            spriteBatch.Draw(upPipeTexture, upPipe2Rect, Color.White);
            spriteBatch.Draw(upPipeTexture, upPipe3Rect, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }


    }
}
