using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class RagePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.RagePotion)
            {
                item.buffType = BuffID.Rage;
                item.buffTime = 14400;
            }
        }
    }
}