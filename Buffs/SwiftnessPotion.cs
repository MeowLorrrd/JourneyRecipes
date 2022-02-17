using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class SwiftnessPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.SwiftnessPotion)
            {
                item.buffType = BuffID.Swiftness;
                item.buffTime = 28800;
            }
        }
    }
}