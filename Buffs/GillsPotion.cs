using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class GillsPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.GillsPotion)
            {
                item.buffType = BuffID.Gills;
                item.buffTime = 14400;
            }
        }
    }
}