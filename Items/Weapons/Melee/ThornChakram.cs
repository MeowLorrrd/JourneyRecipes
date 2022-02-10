using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class ThornChakram : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && projectile.type == ProjectileID.ThornChakram)
            {

            }
        }
    }
}