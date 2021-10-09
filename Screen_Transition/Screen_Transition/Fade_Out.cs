using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Transition
{
    //Fades The Image Out
    class Fade_Out
    {
        private Texture2D image;
        private Vector2 imagePosition;
        private float alpha;

        public Fade_Out(Texture2D newImage, Vector2 newImagePosition)
        {
            alpha = 1.0f;

            image = newImage;
            imagePosition = newImagePosition;
        }

        public void Update(GameTime gameTime)
        {
            if (alpha > 0.0f)
                alpha -= 0.005f;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, imagePosition, Color.White * alpha);
            spriteBatch.End();
        }
    }
}
