using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Projectiles
{
    public class HolyArrow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.HolyArrow)
            {
                item.damage = 13;
            }
        }
    }
    public class HolyArrowProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && projectile.type == ProjectileID.HallowStar)
            {
                projectile.penetrate = 1;
                projectile.damage /= 2;
            }
        }
    }
}
