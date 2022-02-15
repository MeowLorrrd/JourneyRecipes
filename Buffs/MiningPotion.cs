using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class MiningPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MiningPotion)
            {
                item.buffType = BuffID.Mining;
                item.buffTime = 36000;
            }
        }
    }
}