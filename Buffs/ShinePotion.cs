using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ShinePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ShinePotion)
            {
                item.buffType = BuffID.Shine;
                item.buffTime = 21600;
            }
        }
    }
}