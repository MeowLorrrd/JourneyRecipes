using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class NettleBurst : GlobalItem
    {
        /*public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.NettleBurst)
            {
                item.mana = 12;
                item.damage = 35;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.NettleBurst)
            {
                string NettleburstTT = "Ignores 10 points of enemy Defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Summons a thorn spear")
                    {
                        line.text = NettleburstTT;
                    }
                }
            }
        }*/
    }
    public class NettleBurs : GlobalProjectile
    {
        /*public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (projectile.type == ProjectileID.NettleBurstEnd || projectile.type == ProjectileID.NettleBurstLeft || projectile.type == ProjectileID.NettleBurstRight)
                {
                    if (Main.expertMode == false && target.defense >= 10)
                    {
                        projectile.damage = 40;
                    }
                    if (Main.expertMode == false && target.defense == 9)
                    {
                        projectile.damage = 40;
                    }
                    if (Main.expertMode == false && target.defense == 8)
                    {
                        projectile.damage = 39;
                    }
                    if (Main.expertMode == false && target.defense == 7)
                    {
                        projectile.damage = 39;
                    }
                    if (Main.expertMode == false && target.defense == 6)
                    {
                        projectile.damage = 38;
                    }
                    if (Main.expertMode == false && target.defense == 5)
                    {
                        projectile.damage = 38;
                    }
                    if (Main.expertMode == false && target.defense == 4)
                    {
                        projectile.damage = 37;
                    }
                    if (Main.expertMode == false && target.defense == 3)
                    {
                        projectile.damage = 37;
                    }
                    if (Main.expertMode == false && target.defense == 2)
                    {
                        projectile.damage = 36;
                    }
                    if (Main.expertMode == false && target.defense == 1)
                    {
                        projectile.damage = 36;
                    }
                    if (Main.expertMode == false && target.defense == 0)
                    {
                        projectile.damage = 35;
                    }
                    if (Main.expertMode == true && target.defense >= 10)
                    {
                        projectile.damage = 43;
                    }
                    if (Main.expertMode == true && target.defense == 9)
                    {
                        projectile.damage = 42;
                    }
                    if (Main.expertMode == true && target.defense == 8)
                    {
                        projectile.damage = 41;
                    }
                    if (Main.expertMode == true && target.defense == 7)
                    {
                        projectile.damage = 41;
                    }
                    if (Main.expertMode == true && target.defense == 6)
                    {
                        projectile.damage = 40;
                    }
                    if (Main.expertMode == true && target.defense == 5)
                    {
                        projectile.damage = 39;
                    }
                    if (Main.expertMode == true && target.defense == 4)
                    {
                        projectile.damage = 38;
                    }
                    if (Main.expertMode == true && target.defense == 3)
                    {
                        projectile.damage = 37;
                    }
                    if (Main.expertMode == true && target.defense == 2)
                    {
                        projectile.damage = 37;
                    }
                    if (Main.expertMode == true && target.defense == 1)
                    {
                        projectile.damage = 36;
                    }
                    if (Main.expertMode == true && target.defense == 0)
                    {
                        projectile.damage = 35;
                    }
                }
            }
        }*/
    }
}