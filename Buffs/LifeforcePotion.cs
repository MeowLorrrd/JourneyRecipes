using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class LifeforcePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.LifeforcePotion)
            {
                item.buffType = BuffID.Lifeforce;
                item.buffTime = 28800;
            }
        }
    }
}