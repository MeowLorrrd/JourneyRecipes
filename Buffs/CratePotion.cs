using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class CratePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.CratePotion)
            {
                item.buffType = BuffID.Crate;
                item.buffTime = 10800;
            }
        }
    }
}