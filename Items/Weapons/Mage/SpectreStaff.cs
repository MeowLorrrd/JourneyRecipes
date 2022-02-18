using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class SpectreStaff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SpectreStaff)
            {
                item.damage = 65;
                item.mana = 15;
            }
        }
    }
    public class SpectreStaffProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && projectile.type == ProjectileID.LostSoulFriendly)
            {
                projectile.maxPenetrate = 3;
            }
        }
    }
}