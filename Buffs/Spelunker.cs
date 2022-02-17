using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class SpelunkerPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.SpelunkerPotion)
            {
                item.buffType = BuffID.Spelunker;
                item.buffTime = 18000;
            }
        }
    }
}