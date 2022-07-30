using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectile : GlobalProjectile
    {
        public override bool Autoload(ref string name) => GetInstance<Config>().allowWeaponStat;

        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == 242)
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
            if (projectile.owner == Main.myPlayer)//1.4 source code in Projectile.Damage()
            {
                if (projectile.damage > 0)
                {
                    int[] array = projectile.localNPCImmunity;
                    for (int i = 0; i < 200; i++)
                    {
                        bool flag = (!projectile.usesLocalNPCImmunity && !projectile.usesIDStaticNPCImmunity) || (projectile.usesLocalNPCImmunity && array[i] == 0);
                        if (!(Main.npc[i].active && !Main.npc[i].dontTakeDamage && flag) || (Main.npc[i].aiStyle == 112 && Main.npc[i].ai[2] > 1f))
                        {
                            continue;
                        }
                        bool flag2 = !Main.npc[i].friendly;
                        flag2 |= projectile.type == 318;
                        flag2 |= Main.npc[i].type == 22 && projectile.owner < 255 && Main.player[projectile.owner].killGuide;
                        flag2 |= Main.npc[i].type == 54 && projectile.owner < 255 && Main.player[projectile.owner].killClothier;
                        if (projectile.owner < 255 && !Main.player[projectile.owner].CanHit(Main.npc[i]))
                        {
                            flag2 = false;
                        }
                        bool flag3 = Main.npc[i].friendly && !Main.npc[i].dontTakeDamageFromHostiles;
                        if (((projectile.friendly && flag2) || (projectile.hostile && flag3)) && (projectile.owner < 0 || Main.npc[i].immune[projectile.owner] == 0 || projectile.maxPenetrate == 1))
                        {
                            bool flag4 = false;
                            if (!flag4 && (Main.npc[i].noTileCollide || !projectile.ownerHitCheck || projectile.CanHit(Main.npc[i])))
                            {
                                bool flag5 = false;
                                Rectangle myRect = new Rectangle((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height);
                                flag5 = projectile.Colliding(myRect, Main.npc[i].getRect());
                                if (Main.LocalPlayer.name == "tester" && Main.LocalPlayer.HasItem(3466))
                                {
                                    if (flag5)
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
                                        else if (projectile.type == 85)
                                        {
                                            projectile.damage = (int)((double)projectile.damage * 0.85);
                                        }
                                        else if (projectile.type == 76 || projectile.type == 77 || projectile.type == 78)
                                        {
                                            projectile.damage = (int)((double)projectile.damage * 0.95);
                                        }
                                    }
                                    //Main.NewText($"Projectile damage: [c/ff00ff:{projectile.damage}]");
                                }
                            }
                        }
                    }
                }
            }

            if (projectile.type == 92)
            {
                if (!projectile.ranged)
                {
                    projectile.damage = Main.expertMode ? 150 : 75;
                }
            }
            return base.CanDamage(projectile);
        }
        public override void Kill(Projectile projectile, int timeLeft)
        {

        }
        public override bool PreKill(Projectile projectile, int timeLeft)
        {
            if (projectile.type == 91)
            {
                HolyArrowKill(projectile);
                return false;
            }
            return base.PreKill(projectile, timeLeft);
        }
        public void HolyArrowKill(Projectile projectile)//1.4 source code in Projectile.Kill()
        {
            if (!Main.projPet[projectile.type])
            {
                if (projectile.type == 91 || projectile.type == 92)
                {
                    if ((projectile.type == 91 || (projectile.type == 92 && projectile.ai[0] > 0f)) && projectile.owner == Main.myPlayer)
                    {
                        float x = projectile.position.X + (float)Main.rand.Next(-400, 400);
                        float y = projectile.position.Y - (float)Main.rand.Next(600, 900);
                        Vector2 vector = new Vector2(x, y);
                        float num = projectile.position.X + (float)(projectile.width / 2) - vector.X;
                        float num1 = projectile.position.Y + (float)(projectile.height / 2) - vector.Y;
                        int num2 = 22;
                        float num3 = (float)Math.Sqrt(num * num + num1 * num1);
                        num3 = (float)num2 / num3;
                        num *= num3;
                        num1 *= num3;
                        int num4 = projectile.damage;
                        if (projectile.type == 91)
                        {
                            num4 /= 2;
                        }
                        int num5 = Projectile.NewProjectile(vector, new Vector2(num, num1), 92, num4, projectile.knockBack, projectile.owner);
                        if (projectile.type == 91)
                        {
                            Main.projectile[num5].ai[1] = projectile.position.Y;
                            Main.projectile[num5].ai[0] = 1f;
                            Main.projectile[num5].penetrate = 1;
                            //todo, make 2nd proj penetrate once bc for some reason only 1 proj pierces??
                        }
                        else
                        {
                            Main.projectile[num5].ai[1] = projectile.position.Y;
                            Main.projectile[num5].penetrate = 0;
                        }
                    }
                }
            }
        }
    }
}
