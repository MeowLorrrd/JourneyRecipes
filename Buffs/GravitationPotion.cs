using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class GravitationPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.GravitationPotion)
            {
                //item.buffType = BuffID.Gravitation;
                //item.buffTime = 10800;
            }
        }
    }
}