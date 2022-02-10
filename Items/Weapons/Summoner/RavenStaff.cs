using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Summoner
{
    public class RavenStaff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.RavenStaff)
            {
                item.damage = 55;
            }
        }
    }
    public class Raven : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && projectile.type == ProjectileID.Raven)
            {
                //Double Raven speed
            }
        }
    }
}
