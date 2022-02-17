using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class NightOwlPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.NightOwlPotion)
            {
                item.buffType = BuffID.NightOwl;
                item.buffTime = 36000;
            }
        }
    }
}