using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemStack : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowMaxStack)
            {
                if ((item.type >= 1 && item.type < ItemID.Count) && item.maxStack > 10 && (item.maxStack != 100) && !(item.type >= ItemID.CopperCoin && item.type <= ItemID.GoldCoin))
                {
                    item.maxStack = 9999;
                }
            }
            if (item.type == 27)
            {
                item.autoReuse = true;
            }
        }
    }
}