using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class CharmofMyths : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.CharmofMyths)
            {
                player.lifeRegen += 1;
            }
        }
    }
}