using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Summoner
{
    public class OpticStaff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.OpticStaff)
            {
                
            }
        }
    }
    public class OpticStaffProjectile : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && (projectile.type == ProjectileID.MiniRetinaLaser || projectile.type == ProjectileID.Spazmamini || projectile.type == ProjectileID.Retanimini))
            {
                //projectile.usesLocalNPCImmunity = false;
            }
        }
        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
        }
    }
}