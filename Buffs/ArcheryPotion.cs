using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ArcheryPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ArcheryPotion)
            {
                item.buffType = BuffID.Archery;
                item.buffTime = 28800;
            }
        }
    }
}