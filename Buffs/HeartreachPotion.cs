using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class HeartreachPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.HeartreachPotion)
            {
                item.buffType = BuffID.Heartreach;
                item.buffTime = 28800;
            }
        }
    }
}