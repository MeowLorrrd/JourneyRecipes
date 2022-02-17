using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class InfernoPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.InfernoPotion)
            {
                item.buffType = BuffID.Inferno;
                item.buffTime = 14400;
            }
        }
    }
}