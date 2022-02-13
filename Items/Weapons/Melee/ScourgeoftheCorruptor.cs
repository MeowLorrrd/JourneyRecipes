using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class ScourgeoftheCorruptor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.ScourgeoftheCorruptor)
            {
                item.damage = 70;
            }
        }
    }
    //Decrease max Tiny Eater spawns from 5 to 4, and increase avg number of Tiny Eaters spawned per shot from 2.3 to 2.67
    public class ScourgeoftheCorruptorProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && projectile.type == ProjectileID.TinyEater)
            {
                projectile.damage = 53;
            }
        }
    }
}