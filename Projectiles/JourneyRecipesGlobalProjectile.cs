using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectile : GlobalProjectile
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<Config>().allowWeaponStat;
        }
        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == 92)
            {
                if (projectile.magic)
                {
                    if (!Main.expertMode)
                    {
                        projectile.damage = 75;
                    }
                    else
                    {
                        projectile.damage = 150;
                    }
                }
                else
                {
                    projectile.damage = 7;
                    projectile.penetrate = 1;
                }
            }
            else if (projectile.type == 242)
            {
                projectile.penetrate = 3;
                projectile.extraUpdates = 7;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 15;
            }
            else if (projectile.type == 260)
            {
                projectile.penetrate = 1;
            }
            else if (projectile.type == 266)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
            }
            else if (projectile.type == 297)
            {
                projectile.penetrate = 3;
            }
            else if (projectile.type == 390 || projectile.type == 391 || projectile.type == 392)
            {
                projectile.minionSlots = 1f;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 15;
            }
            else if (projectile.type == 387)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 16;
            }
            else if (projectile.type == 388)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
            }
            else if (projectile.type == 389)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
                projectile.extraUpdates = 2;
            }
            else if (projectile.type == 433)
            {
                //TODO: MODIFY DAMAGE
            }
            else if (projectile.type == 533)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 8;
            }
            else if (projectile.type == 697)
            {
                projectile.scale = 1.35f;
                projectile.damage = 150;
                projectile.ownerHitCheck = true;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 12;
            }
            else if (projectile.type == 708)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 6;
                projectile.ownerHitCheck = true;
                //TODO
            }
            else if (projectile.type == 709)
            {
                projectile.extraUpdates = 1;
                projectile.noEnchantments = true;
                projectile.scale = 0.6f;
                //TODO
            }
        }
        public override bool CanDamage(Projectile projectile)
        {
            for (int i = 0; i < 200; i++)
            {
                if (projectile.CanHit(Main.npc[i]))
                {
                    bool flag = false;
                    Rectangle myRect = new Rectangle((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height);
                    flag = projectile.Colliding(myRect, Main.npc[i].getRect());
                    if (flag)
                    {
                        if (projectile.type == 294)
                        {
                            projectile.damage = (int)((double)projectile.damage * 1.04);
                        }
                        else if (projectile.type == 114)
                        {
                            projectile.damage = (int)((double)projectile.damage * 0.9);
                        }
                        else if (projectile.type == 323)
                        {
                            projectile.damage = (int)((double)projectile.damage * 0.9);
                        }
                        else if (projectile.type == 5)
                        {
                            projectile.damage = (int)((double)projectile.damage * 0.9);
                        }

                        if (Main.LocalPlayer.name == "tester" && Main.LocalPlayer.HasItem(3466))
                        {
                            Main.NewText($"Projectile damage: [c/ff00ff:{projectile.damage}]");
                        }
                    }
                }
            }
            return base.CanDamage(projectile);
        }
    }
}