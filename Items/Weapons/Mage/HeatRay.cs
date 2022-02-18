using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class HeatRay : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.HeatRay)
            {
                item.damage = 80;
                item.useAnimation = 10;
                item.useTime = 10;
            }
        }
    }
    public class HeatRayProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && projectile.type == ProjectileID.HeatRay)
            {
                projectile.maxPenetrate = 1;
            }
        }
    }
}
