using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class Flamethrower : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (item.type == ItemID.Flamethrower)
                {
                    item.damage = 35;
                }
            }
        }
    }
    
    public class FlamethrowerProjectile : GlobalProjectile
    {
        /*public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (projectile.type == ProjectileID.Flames)
                {
                    projectile.damage = 35;
                }
            }
        }*/
        /*public override bool InstancePerEntity => true;
        public int[] pierceCouncter = new int[2];
        public float piercePenaltyProj = 0.85f;
        public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                /*if (projectile.type == ProjectileID.Flames && projectile.penetrate > 0)
                {
                    if (projectile.penetrate <= Main.player[projectile.owner].GetModPlayer<FlamethrowerPlayer>().piercePenaltyPlayer)
                    {
                        projectile.damage = (int)(35 * Math.Pow(piercePenaltyProj, pierceCouncter[target.whoAmI]));
                    }
                    if (pierceCouncter[target.whoAmI] < 1)
                    {
                        pierceCouncter[target.whoAmI]++;
                    }
                }
                if (projectile.type == 85)
                {
                    if (projectile.penetrate == 0)
                    {
                        damage = 35;
                    }
                    if (projectile.penetrate == 1)
                    {
                        projectile.damage = 1000;
                    }
                    if (projectile.penetrate == 2)
                    {
                        projectile.damage = 300;
                    }
                }
            }
        }*/
    }
} 