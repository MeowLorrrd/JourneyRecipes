using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class SummoningPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.SummoningPotion)
            {
                item.buffType = BuffID.Summoning;
                item.buffTime = 28800;
            }
        }
    }
}