using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WakaSkies.WakaModelBuilder;

namespace WakaSkies.Desktop
{
    /// <summary>
    /// The camera logic for the app.
    /// </summary>
    internal class Camera
    {

        // http://rbwhitaker.wikidot.com/monogame-using-3d-models
        // rotate by -90 degrees to make the model render upright.
        // the model is in a +Z up axis so a rotation on the X axis 
        // will make the model loop right.
        public Matrix world = Matrix.CreateRotationX(MathHelper.ToRadians(-90)) *
            // the -29, -5 moves the model about half-way right
            // and down a little bit.
            Matrix.CreateTranslation(new Vector3(-28, -5, -2));
        public Matrix view = Matrix.CreateLookAt(new Vector3(0, 10, 30), new Vector3(0, 0, 0), Vector3.UnitY);
        public Matrix projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), 1280f / 720f, 0.1f, 1000f);

        public Vector3 cameraPos = new Vector3(0, 20, 60);

        private float angle = 90;
        private float distance = 60;

        private const float ROTATE_SPEED = 0.08f;

        private bool rotate;

        private MouseState prevMouse;
        private MouseState currentMouse = Mouse.GetState();

        /// <summary>
        /// When the camera is force-rotated by the user, wait a bit before rotating again.
        /// </summary>
        private float rotateTimer;
        private bool pausedRotation;

        public void Update(GameTime gameTime)
        {
            // move in circle around 0,0,0.
            // https://gamedev.stackexchange.com/a/9610
            var x = MathF.Cos(MathHelper.ToRadians(angle));
            var z = MathF.Sin(MathHelper.ToRadians(angle));
            cameraPos = new Vector3(x * distance, 20, z * distance);

            // make the new view.
            view = Matrix.CreateLookAt(new Vector3(cameraPos.X, cameraPos.Y, cameraPos.Z), Vector3.Zero, Vector3.UnitY);

            if (rotate && !pausedRotation)
            {
                angle += ROTATE_SPEED;
            }

            if (rotate)
                MouseRotate(gameTime);

            if (angle >= 360)
            {
                angle = 0;
            }
        }

        /// <summary>
        /// Rotate with the mouse.
        /// </summary>
        /// <param name="gameTime"></param>
        private void MouseRotate(GameTime gameTime)
        {
            prevMouse = currentMouse;
            currentMouse = Mouse.GetState();

            if (currentMouse.LeftButton == ButtonState.Pressed
                && prevMouse.LeftButton == ButtonState.Pressed)
            {
                var delta = currentMouse.Position - prevMouse.Position;
                angle += delta.X * 0.1f;

                // pause rotation
                pausedRotation = true;
            }

            if (pausedRotation)
            {
                rotateTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (rotateTimer >= 2)
                {
                    pausedRotation = false;
                    rotateTimer = 0;
                }
            }
        }

        /// <summary>
        /// Start the camera rotation.
        /// </summary>
        public void StartRotation()
        {
            rotate = true;
        }

        /// <summary>
        /// Stop the rotation.
        /// </summary>
        public void StopRotation()
        {
            rotate = false;
        }

        /// <summary>
        /// Change the projection.
        /// </summary>
        /// <param name="width">The new width of the window.</param>
        /// <param name="height">The new height of the window.</param>
        public void ChangeSize(float width, float height)
        {
            // change the aspect ratio.
            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), width / height, 0.1f, 1000f);
        }

        /// <summary>
        /// Change the world translation.
        /// </summary>
        /// <param name="modelWidth"></param>
        public void UpdateWorld(float modelWidth)
        {
            world = Matrix.CreateRotationX(MathHelper.ToRadians(-90)) *
                // shift half way so model is in center. add three to nudge it a little
                // towards the center a little bit more.
                Matrix.CreateTranslation(new Vector3((-modelWidth / 2) + 3, -5, -2));
        }

    }
}
