using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class RegenerationPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.RegenerationPotion)
            {
                item.buffType = BuffID.Regeneration;
                item.buffTime = 28800;
            }
        }
    }
}