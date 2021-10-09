using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Transition
{
    //Fades The Image In
    class Fade_In
    {
        private Texture2D image;
        private Vector2 imagePosition;
        private float alpha;

        public Fade_In(Texture2D newImage, Vector2 newImagePosition)
        {
            alpha = 0.0f;

            image = newImage;
            imagePosition = newImagePosition;
        }

        public void Update(GameTime gameTime)
        {
            if (alpha < 1.0f)
                alpha += 0.005f;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, imagePosition, Color.White * alpha);
            spriteBatch.End();
        }
    }
}
