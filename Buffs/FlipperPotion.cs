using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class FlipperPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.FlipperPotion)
            {
                item.buffType = BuffID.Flipper;
                item.buffTime = 36000;
            }
        }
    }
}