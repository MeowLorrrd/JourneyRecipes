using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class AmmoReservationPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.AmmoReservationPotion)
            {
                item.buffType = BuffID.AmmoReservation;
                item.buffTime = 28800;
            }
        }
    }
}