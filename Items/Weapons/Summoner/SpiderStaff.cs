using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Summoner
{
    public class SpiderStaff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.SpiderStaff)
            {
                //ew spiders
            }
        }
    }
    public class SpiderStaffProjectile : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && (projectile.type == ProjectileID.VenomSpider || projectile.type == ProjectileID.JumperSpider || projectile.type == ProjectileID.DangerousSpider))
            {
                projectile.minionSlots = 1;
            }
        }
    }
}