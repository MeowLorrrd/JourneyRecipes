using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class TrueNightsEdge : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.terraBladeStuff && item.type == ItemID.TrueNightsEdge)
            {
                item.autoReuse = true;
                item.damage = 105;
            }
        }
    }
    public class NightBeam : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.terraBladeStuff && projectile.type == ProjectileID.NightBeam)
            {
                projectile.damage = 158;
            }
        }
    }
}
