using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace doomGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D backgroundTexture;
        private Texture2D playerTexture;
        private Texture2D enemyTexture;
        private Texture2D boomTexture;
        private Vector2 playerPosition;
        private Vector2 enemyPosition;
        private Vector2 enemyVelocity;
        private Vector2 bulletPosition;
        private Vector2 bulletVelocity;
        private bool isShooting = false;
        private List<Vector2> enemyPositions = new List<Vector2>(); // Track positions of all enemies


        SpriteFont deathFont;
        SpriteFont killFont;


        private int deathCount = 0;
        private int killCount = 0;

        private const float PlayerSpeed = 5f;
        private const float EnemySpeed = 7f;
        private const float BulletSpeed = 7f;

        private KeyboardState prevKeyboardState;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            // Set fullscreen mode
            _graphics.IsFullScreen = true;

            // Set resolution to the screen's current resolution
            _graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            _graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            backgroundTexture = Content.Load<Texture2D>("bg");
            playerTexture = Content.Load<Texture2D>("player");
            enemyTexture = Content.Load<Texture2D>("enemy");
            boomTexture = Content.Load<Texture2D>("boom");

            deathFont = Content.Load<SpriteFont>("deathFont");
            killFont = Content.Load<SpriteFont>("killFont");

            // Scale player and enemy textures by 300%
            playerTexture = ScaleTexture(playerTexture, 0.3f);
            enemyTexture = ScaleTexture(enemyTexture, 0.2f);

            // Scale boomTexture by 1000% smaller
            boomTexture = ScaleTexture(boomTexture, 0.1f);

            playerPosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            enemyPosition = new Vector2(100, 100);
        }

        private Texture2D ScaleTexture(Texture2D source, float scale)
        {
            int newWidth = (int)(source.Width * scale);
            int newHeight = (int)(source.Height * scale);

            Texture2D result = new Texture2D(GraphicsDevice, newWidth, newHeight);
            Color[] data = new Color[source.Width * source.Height];
            source.GetData(data);

            Color[] newData = new Color[newWidth * newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int index = (int)(y / scale) * source.Width + (int)(x / scale);
                    newData[y * newWidth + x] = data[index];
                }
            }

            result.SetData(newData);
            return result;
        }
        private void SpawnEnemy()
        {
            // Spawn a new enemy
            // You can adjust the spawn position as needed
            Vector2 newEnemyPosition = new Vector2(100,200);
            enemyPositions.Add(newEnemyPosition);
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var keyboardState = Keyboard.GetState();
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            //enemy autospawn
            if (killCount % 2 == 0)
            {
                // Spawn a new enemy
                SpawnEnemy();
            }
            // Update enemy positions
            for (int i = 0; i < enemyPositions.Count; i++)
            {
                // Enemy movement logic
                Vector2 directionToPlayer = playerPosition - enemyPositions[i]; // Assuming playerPosition is accessible here
                directionToPlayer.Normalize();
                Vector2 enemyVelocity = directionToPlayer * EnemySpeed; // Assuming EnemySpeed is accessible here
                enemyPositions[i] += enemyVelocity;
            }
                // Player movement
                Vector2 movement = Vector2.Zero;
            if (keyboardState.IsKeyDown(Keys.W))
                movement.Y = -1;
            if (keyboardState.IsKeyDown(Keys.S))
                movement.Y = 1;
            if (keyboardState.IsKeyDown(Keys.A))
                movement.X = -1;
            if (keyboardState.IsKeyDown(Keys.D))
                movement.X = 1;

            playerPosition += movement * PlayerSpeed;
            
            // Ensure player stays within screen boundaries
            playerPosition.X = MathHelper.Clamp(playerPosition.X, 0, GraphicsDevice.Viewport.Width - playerTexture.Width);
            playerPosition.Y = MathHelper.Clamp(playerPosition.Y, 0, GraphicsDevice.Viewport.Height - playerTexture.Height);

            // Enemy movement (chasing player)
            Vector2 direction = playerPosition - enemyPosition;
            direction.Normalize();
            enemyVelocity = direction * EnemySpeed;
            enemyPosition += enemyVelocity;

            // Shooting
            if (keyboardState.IsKeyDown(Keys.Space) && prevKeyboardState.IsKeyUp(Keys.Space))
            {
                isShooting = true;
                bulletPosition = playerPosition;

                // Corrected direction calculation
                Vector2 shootDirection = enemyPosition - playerPosition;
                shootDirection.Normalize();
                bulletVelocity = shootDirection * BulletSpeed;
            }

            Rectangle enemyRect; // Declare enemyRect here

            if (isShooting)
            {
                bulletPosition += bulletVelocity;
                if (bulletPosition.X < 0 || bulletPosition.X > GraphicsDevice.Viewport.Width || bulletPosition.Y < 0 || bulletPosition.Y > GraphicsDevice.Viewport.Height)
                {
                    isShooting = false;
                }
                else
                {
                    // Check for bullet-enemy collision
                    Rectangle bulletRect = new Rectangle((int)bulletPosition.X, (int)bulletPosition.Y, playerTexture.Width, playerTexture.Height);
                    enemyRect = new Rectangle((int)enemyPosition.X, (int)enemyPosition.Y, enemyTexture.Width, enemyTexture.Height); // Declare enemyRect here
                    if (bulletRect.Intersects(enemyRect))
                    {
                        // Increment kill count
                        killCount++;

                        // Reset enemy position
                        enemyPosition = new Vector2(100, 100);

                        // Stop shooting
                        isShooting = false;
                    }
                }
            }

            // Check for player-enemy collision
            Rectangle playerRect = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, playerTexture.Width, playerTexture.Height);
            enemyRect = new Rectangle((int)enemyPosition.X, (int)enemyPosition.Y, enemyTexture.Width, enemyTexture.Height); // Move this line here
            if (playerRect.Intersects(enemyRect))
            {
                // Increment death count
                deathCount++;

                // Reset player and enemy positions
                playerPosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
                enemyPosition = new Vector2(100, 100);
            }

            prevKeyboardState = keyboardState;

            base.Update(gameTime);

        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Draw background
            _spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);

            // Draw player
            _spriteBatch.Draw(playerTexture, playerPosition, Color.White);

            // Draw enemy
            _spriteBatch.Draw(enemyTexture, enemyPosition, Color.White);

            // Draw bullet if shooting
            if (isShooting)
            {
                _spriteBatch.Draw(boomTexture, bulletPosition, Color.Red);
            }

            //FONT
            _spriteBatch.DrawString(deathFont, "Deaths:", new Vector2(10, 10), Color.White);
            _spriteBatch.DrawString(deathFont, deathCount.ToString(), new Vector2(70, 10), Color.White);

            _spriteBatch.DrawString(deathFont, "Kills:", new Vector2(110, 10), Color.White);
            _spriteBatch.DrawString(deathFont, killCount.ToString(), new Vector2(155, 10), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
