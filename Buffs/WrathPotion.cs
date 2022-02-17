using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class WrathPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.WrathPotion)
            {
                item.buffType = BuffID.Wrath;
                item.buffTime = 14400;
            }
        }
    }
}