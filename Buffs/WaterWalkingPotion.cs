using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class WaterWalkingPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.WaterWalkingPotion)
            {
                item.buffType = BuffID.WaterWalking;
                item.buffTime = 36000;
            }
        }
    }
}