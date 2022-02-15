using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class BuilderPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.BuilderPotion)
            {
                item.buffType = BuffID.Builder;
                item.buffTime = 162000;
            }
        }
    }
}