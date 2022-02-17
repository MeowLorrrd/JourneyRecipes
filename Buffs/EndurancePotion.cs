using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class EndurancePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.EndurancePotion)
            {
                item.buffType = BuffID.Endurance;
                item.buffTime = 14400;
            }
        }
    }
}