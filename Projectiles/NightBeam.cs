using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Projectiles
{
    public class NightBeam : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.terraBladeStuff)
            {
                if (projectile.type == ProjectileID.NightBeam)
                {
                    projectile.damage = 158;
                }
            }
        }
    }
}
