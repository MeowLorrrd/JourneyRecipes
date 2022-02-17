using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class WarmthPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.WarmthPotion)
            {
                item.buffType = BuffID.Warmth;
                item.buffTime = 54000;
            }
        }
    }
}