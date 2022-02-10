using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class StakeProj : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && projectile.type == ItemID.Stake)
            {
                //projectile.arrow = true;
            }
        }
    }
}