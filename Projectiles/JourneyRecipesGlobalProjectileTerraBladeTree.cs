using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectileTerraBladeTree : GlobalProjectile
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().TerraBladeStuff;
        }
        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == 132)
            {
                projectile.damage = (int)(115 * 1.5);
            }
            else if (projectile.type == 156)
            {
                projectile.penetrate = 2;
            }
            else if (projectile.type == 157)
            {
                projectile.damage = (int)(105 * 1.5);
            }
        }
    }
}