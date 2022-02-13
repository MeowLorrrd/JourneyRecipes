using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class CharmofMyths : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.CharmofMyths || item.type == ItemID.BandofRegeneration))
                item.lifeRegen = 2;
        }
    }
}