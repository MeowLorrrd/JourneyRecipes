using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemStack : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowMaxStack)
            {
                if (item.type > 0 && item.type < ItemID.Count && item.maxStack > 2 && item.maxStack != 100 && item.type != ItemID.Bananarang || item.type != ItemID.LightDisc)
                {
                    item.maxStack = 9999;
                }
            }
        }
    }
}