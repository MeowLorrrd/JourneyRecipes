using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectileSpear : GlobalProjectile
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().allowAccessoryStat;
        }
        public override void AI(Projectile projectile)
        {
            //code from omniswing source code
            //fixes spear ai
            {
                if (projectile.aiStyle == 19 || projectile.aiStyle == 699)
                {
                    projectile.timeLeft = Main.player[projectile.owner].itemAnimation;
                    projectile.netUpdate = true;
                }
            }
        }
    }
}