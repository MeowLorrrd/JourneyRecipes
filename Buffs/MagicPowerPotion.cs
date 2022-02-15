using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class MagicPowerPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MagicPowerPotion)
            {
                item.buffType = BuffID.MagicPower;
                item.buffTime = 14400;
            }
        }
    }
}