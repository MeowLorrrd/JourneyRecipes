using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class SleepyOctopod : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.MonkStaffT1)
            {
                item.damage = 50;
            }
        }
    }
    public class SleepyOctopodProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && projectile.type == ProjectileID.MonkStaffT1Explosion)
            {
                projectile.scale = 1.35f;
                //offset
                //proj deals 3x item damage (prolly have to do IL edit so wont touch nu-uh
            }
        }
    }
}