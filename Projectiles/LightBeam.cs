using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Projectiles
{
    public class LightBeam : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.terraBladeStuff)
            {
                if (projectile.type == ProjectileID.LightBeam)
                {
                    projectile.penetrate = 2;
                }
            }
        }
    }
}