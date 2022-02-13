using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class CrystalVileShard : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.CrystalVileShard)
            {
                item.damage = 25;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (item.type == ItemID.CrystalVileShard)
                {
                    var line = new TooltipLine(mod, "10 def tooltip", "Ignores 10 points of enemy Defense");
                    tooltips.Add(line);
                }
            }
        }
    }
    public class CrystalVileShardProjectile : GlobalProjectile
    {
        public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (projectile.type == ProjectileID.CrystalVileShardHead || projectile.type == ProjectileID.CrystalVileShardShaft)
                {
                    if (Main.expertMode == false && target.defense >= 10)
                    {
                        projectile.damage = 30;
                    }
                    if (Main.expertMode == false && target.defense == 9)
                    {
                        projectile.damage = 30;
                    }
                    if (Main.expertMode == false && target.defense == 8)
                    {
                        projectile.damage = 29;
                    }
                    if (Main.expertMode == false && target.defense == 7)
                    {
                        projectile.damage = 29;
                    }
                    if (Main.expertMode == false && target.defense == 6)
                    {
                        projectile.damage = 28;
                    }
                    if (Main.expertMode == false && target.defense == 5)
                    {
                        projectile.damage = 28;
                    }
                    if (Main.expertMode == false && target.defense == 4)
                    {
                        projectile.damage = 27;
                    }
                    if (Main.expertMode == false && target.defense == 3)
                    {
                        projectile.damage = 27;
                    }
                    if (Main.expertMode == false && target.defense == 2)
                    {
                        projectile.damage = 26;
                    }
                    if (Main.expertMode == false && target.defense == 1)
                    {
                        projectile.damage = 26;
                    }
                    if (Main.expertMode == false && target.defense == 0)
                    {
                        projectile.damage = 25;
                    }
                    if (Main.expertMode == true && target.defense >= 10)
                    {
                        projectile.damage = 33;
                    }
                    if (Main.expertMode == true && target.defense == 9)
                    {
                        projectile.damage = 32;
                    }
                    if (Main.expertMode == true && target.defense == 8)
                    {
                        projectile.damage = 31;
                    }
                    if (Main.expertMode == true && target.defense == 7)
                    {
                        projectile.damage = 30;
                    }
                    if (Main.expertMode == true && target.defense == 6)
                    {
                        projectile.damage = 30;
                    }
                    if (Main.expertMode == true && target.defense == 5)
                    {
                        projectile.damage = 29;
                    }
                    if (Main.expertMode == true && target.defense == 4)
                    {
                        projectile.damage = 28;
                    }
                    if (Main.expertMode == true && target.defense == 3)
                    {
                        projectile.damage = 27;
                    }
                    if (Main.expertMode == true && target.defense == 2)
                    {
                        projectile.damage = 27;
                    }
                    if (Main.expertMode == true && target.defense == 1)
                    {
                        projectile.damage = 26;
                    }
                    if (Main.expertMode == true && target.defense == 0)
                    {
                        projectile.damage = 25;
                    }
                }
            }
        }
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (projectile.type == ProjectileID.CrystalVileShardHead || projectile.type == ProjectileID.CrystalVileShardShaft)
                {
                    //Make projectile last longer
                }
            }
        }
    }
}
