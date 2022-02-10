using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class LavaWaders : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.LavaWaders)
            {
                player.lavaRose = true;
            }
        }
    }
}