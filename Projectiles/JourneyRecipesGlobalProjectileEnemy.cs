using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectileEnemy : GlobalProjectile
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().AllowNPCStat;
        }
        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == 508)
            {
                projectile.damage = 36;
            }
        }
        public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
        {
            if (projectile.type == 128)
            {
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(44, 360);
                }
            }
            if (projectile.type == 299)
            {
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(23, 120);
                }
            }
        }
    }
}