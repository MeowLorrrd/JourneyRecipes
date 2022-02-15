using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ManaRegenerationPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ManaRegenerationPotion)
            {
                item.buffType = BuffID.ManaRegeneration;
                item.buffTime = 28800;
            }
        }
    }
}