using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class TitanPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.TitanPotion)
            {
                item.buffType = BuffID.Titan;
                item.buffTime = 28800;
            }
        }
    }
}