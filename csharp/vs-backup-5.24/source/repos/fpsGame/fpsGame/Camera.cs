using Microsoft.Xna.Framework;

namespace fpsGame.Content
{
    internal class Camera
    {
        public Matrix Transform { get; private set; }
        int maxX = 1600;
        int maxY = 900;

        public void Follow(Player player, int viewportWidth, int viewportHeight)
        {
            int halfViewportWidth = viewportWidth / 2;
            int halfViewportHeight = viewportHeight / 2;

            // Calculate the position of the camera
            int cameraX = player.GetRect().X - halfViewportWidth + player.GetRect().Width / 2;
            int cameraY = player.GetRect().Y - halfViewportHeight + player.GetRect().Height / 2;

            // Clamp the camera position to stay within the game world
            cameraX = MathHelper.Clamp(cameraX, 0, maxX - viewportWidth);
            cameraY = MathHelper.Clamp(cameraY, 0, maxY - viewportHeight);

            // Create the transform matrix for the camera
            Transform = Matrix.CreateTranslation(new Vector3(-cameraX, -cameraY, 0));
        }
    }
}
