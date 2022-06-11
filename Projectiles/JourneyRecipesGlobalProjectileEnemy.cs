using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectileEnemy : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (ModContent.GetInstance<Config>().AllowNPCStat)
            {
                if (projectile.type == 508)
                {
                    projectile.damage = 36;
                }
            }
        }
    }
}