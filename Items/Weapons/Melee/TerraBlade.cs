using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class TerraBlade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.terraBladeStuff && item.type == ItemID.TerraBlade)
            {
                item.damage = 115;
                item.useTime = 14;
                item.useAnimation = 14;
            }
        }
    }
    public class TerraBeam : GlobalProjectile
    {
        public override void AI(Projectile projectile)
        {
            if (Config.Instance.terraBladeStuff && projectile.type == ProjectileID.TerraBeam)
            {
                projectile.damage = 173;
            }
        }
    }
}