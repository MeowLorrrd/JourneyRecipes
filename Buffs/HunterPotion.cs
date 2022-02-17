using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class HunterPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.HunterPotion)
            {
                item.buffType = BuffID.Hunter;
                item.buffTime = 28800;
            }
        }
    }
}