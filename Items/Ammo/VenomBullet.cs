using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class VenomBullet : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.VenomBullet)
            {
                item.damage = 15;
            }
        }
    }
}