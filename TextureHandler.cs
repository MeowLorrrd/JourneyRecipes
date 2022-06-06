using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace JourneyRecipes
{
    public class TextureHandler : IDisposable
    {
        public ItemTextures Items;
        public class ItemTextures : IDisposable
        {
            public Texture2D TurtleShell = ModContent.GetTexture("Resprite/Item_1328");
            public void Dispose()
            {
                TurtleShell.Dispose();
            }

        }
        public void Initialize()
        {
            Items = new ItemTextures();
        }
        public void Dispose()
        {
            Items.Dispose();
        }
    }
}