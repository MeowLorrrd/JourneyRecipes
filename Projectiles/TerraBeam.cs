using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Projectiles
{
    public class TerraBeam : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.terraBladeStuff)
            {
                if (projectile.type == ProjectileID.TerraBeam)
                {
                    projectile.damage = 173;
                }
            }
        }
    }
}