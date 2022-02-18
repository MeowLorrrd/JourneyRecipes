using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class HighVelocityBullet : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.HighVelocityBullet)
            {
                item.damage = 11;
            }
        }
    }
    public class HighVelocityBulletProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && projectile.type == ProjectileID.BulletHighVelocity)
            {
                projectile.maxPenetrate = 3;
            }
        }
    }
}