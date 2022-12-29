using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectile : GlobalProjectile
    {
        public override bool Autoload(ref string name) => GetInstance<JourneyRecipesServerConfig>().allowWeaponStat;

        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == 23)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 12;
            }
            if (projectile.type == 36)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 15;
            }
            if (projectile.type == 242)
            {
                projectile.penetrate = 3;
                projectile.extraUpdates = 7;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 15;
            }
            if (projectile.type == 260)
            {
                projectile.penetrate = 1;
            }
            if (projectile.type == 266)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
            }
            if (projectile.type == 297)
            {
                projectile.penetrate = 3;
            }
            if (projectile.type == 390 || projectile.type == 391 || projectile.type == 392)
            {
                projectile.minionSlots = 1f;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 15;
            }
            if (projectile.type == 387)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 16;
            }
            if (projectile.type == 388)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
            }
            if (projectile.type == 389)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 12;
                projectile.extraUpdates = 2;
            }
            if (projectile.type == 433)
            {
                //TODO: MODIFY DAMAGE
            }
            if (projectile.type == 502)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 10;
                projectile.damage = 250;
            }
            if (projectile.type == 503)
            {
                projectile.extraUpdates = 1;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 30;
                projectile.damage = 170;
            }
            if (projectile.type == 532)
            {
                projectile.width = 16;
                projectile.height = 16;
                projectile.aiStyle = 1;
                projectile.scale = 1f;
                projectile.friendly = true;
                projectile.penetrate = 3;
                projectile.extraUpdates = 1;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 10;
            }
            if (projectile.type == 533)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 8;
            }
            if (projectile.type == 603)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            if (projectile.type == 604)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            if (projectile.type == 697)
            {
                projectile.scale = 1.35f;
                projectile.damage = 150;
                projectile.ownerHitCheck = true;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 12;
            }
            /* if (projectile.type == 699)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 20;
                projectile.ownerHitCheck = true;
            }
             if (projectile.type == 700)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = -1;
            }*///TODO: rewrite proj AI
            if (projectile.type == 708)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 6;
                projectile.ownerHitCheck = true;
                //TODO
            }
            if (projectile.type == 709)
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
                                Rectangle myRect = new Rectangle((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height);
                                bool flag5 = projectile.Colliding(myRect, Main.npc[i].getRect());

                                if (flag5)
                                {

                                    if (projectile.type == 294)
                                    {
                                        projectile.damage = (int)((double)projectile.damage * 1.14);
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

            if (projectile.type == 92)
            {
                if (!projectile.ranged)
                {
                    //projectile.damage = Main.expertMode ? 150 : 75;
                }
            }
            return base.CanDamage(projectile);
        }
        public override void AI(Projectile projectile)
        {
            if (projectile.type == 532)
            {
                projectile.ai[0] += 1f;
            }
        }
        public override bool PreAI(Projectile projectile)
        {
            if (projectile.aiStyle == 57 || projectile.type == 344)
            {
                NorthPoleSpearProj(projectile);
                return false;
            }
            return base.PreAI(projectile);
        }
        public void NorthPoleSpearProj(Projectile proj)
        {
            if (proj.aiStyle == 57)
            {
                proj.ai[0] += 1f;
                if (proj.ai[0] > 30f)
                {
                    proj.ai[0] = 30f;
                    proj.velocity.Y += 0.25f;
                    if (proj.velocity.Y > 16f)
                    {
                        proj.velocity.Y = 16f;
                    }
                    proj.velocity.X *= 0.995f;
                }
                proj.rotation = (float)Math.Atan2(proj.velocity.Y, proj.velocity.X) + 1.57f;
                proj.alpha -= 50;
                if (proj.alpha < 0)
                {
                    proj.alpha = 0;
                }
                if (proj.owner == Main.myPlayer)
                {
                    if (proj.localAI[1] == 0f)
                    {
                        proj.localAI[1] = Main.rand.Next(7);
                    }
                    proj.localAI[0]++;
                    int num499 = 8;
                    if (proj.localAI[1] > 0f)
                    {
                        num499 += (int)proj.localAI[1];
                    }
                    if (proj.localAI[0] >= (float)num499)
                    {
                        proj.localAI[0] = 0f;
                        proj.localAI[1] = -1f;
                        Projectile.NewProjectile(proj.Center.X, proj.Center.Y, 0f, 0f, 344, (int)((float)proj.damage * 0.7f), proj.knockBack * 0.55f, proj.owner, 0f, Main.rand.Next(3));
                    }
                }
            }
            if (proj.type == 344)
            {
                if (WorldGen.SolidTile((int)proj.position.X / 16, (int)(proj.position.Y + proj.velocity.Y) / 16 + 1) || WorldGen.SolidTile((int)(proj.position.X + (float)proj.width) / 16, (int)(proj.position.Y + proj.velocity.Y) / 16 + 1))
                {
                    proj.Kill();
                    return;
                }
                proj.localAI[1] += 1f;
                if (proj.localAI[1] > 5f)
                {
                    proj.alpha -= 50;
                    if (proj.alpha < 0)
                    {
                        proj.alpha = 0;
                    }
                }
                proj.frame = (int)proj.ai[1];
                if (proj.localAI[1] > 20f)
                {
                    proj.localAI[1] = 20f;
                    proj.velocity.Y += 0.15f;
                }
            }
        }


        public override Color? GetAlpha(Projectile projectile, Color lightColor)
        {
            if (projectile.type == 343 || projectile.type == 344)
            {
                float num5 = 1f - (float)projectile.alpha / 255f;
                return new Color((int)(250f * num5), (int)(250f * num5), (int)(250f * num5), (int)(100f * num5));
            }
            return base.GetAlpha(projectile, lightColor);
        }
        public override bool PreKill(Projectile projectile, int timeLeft)
        {
            if (projectile.type == 91 || projectile.type == 92)
            {
                HolyArrowKill(projectile);
                return false;
            }
            else if (projectile.type == 306)
            {
                EatersBiteKill(projectile);
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
                    Main.PlaySound(SoundID.Item10, projectile.position);
                    for (int numDust = 0; numDust < 10; numDust++)
                    {
                        Dust.NewDust(projectile.position, projectile.width, projectile.height, 58, projectile.velocity.X * .1f, projectile.velocity.Y * .1f, 150, default, 1.2f);
                    }
                    for (int numGore = 0; numGore < 3; numGore++)
                    {
                        Gore.NewGore(projectile.position, new Vector2(projectile.velocity.X * .05f, projectile.velocity.Y * .05f), Main.rand.Next(16, 18));
                    }
                    if (projectile.type == 12 && projectile.damage < 500)
                    {
                        for (int num485 = 0; num485 < 10; num485++)
                        {
                            Dust.NewDust(projectile.position, projectile.width, projectile.height, 57, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 150, default, 1.2f);
                        }
                        for (int num486 = 0; num486 < 3; num486++)
                        {
                            Gore.NewGore(projectile.position, new Vector2(projectile.velocity.X * 0.05f, projectile.velocity.Y * 0.05f), Main.rand.Next(16, 18));
                        }
                    }
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
                            num4 /= 3;
                        }
                        int num5 = Projectile.NewProjectile(vector, new Vector2(num, num1), 92, num4, projectile.knockBack, projectile.owner);
                        if (projectile.type == 91)
                        {
                            Main.projectile[num5].ai[1] = projectile.position.Y;
                            Main.projectile[num5].ai[0] = 1f;
                            Main.projectile[num5].penetrate = 1;
                        }
                        else
                        {
                            Main.projectile[num5].ai[1] = projectile.position.Y;
                            Main.projectile[num5].penetrate = 1;
                        }
                    }
                }
            }
        }
        public void EatersBiteKill(Projectile projectile)
        {
            Main.PlaySound(3, new Vector2(projectile.position.X, projectile.position.Y));
            for (int num = 0; num < 20; num++)
            {
                int numDust1 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 184);
                Dust dust1 = Main.dust[numDust1];
                dust1.scale *= 1.1f;
                Main.dust[numDust1].noGravity = true;
            }
            for (int num1 = 0; num1 < 30; num1++)
            {
                int numDust2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 184);
                Dust dust2 = Main.dust[numDust2];
                dust2.velocity *= 2.5f;
                dust2 = Main.dust[numDust2];
                dust2.scale *= 0.8f;
                Main.dust[numDust2].noGravity = true;
            }
            if (projectile.owner == Main.myPlayer)
            {
                int num746 = Main.rand.Next(2, 5);
                if (Main.rand.Next(1, 101) == 100)
                {
                    num746 = 15;
                }
                for (int num747 = 0; num747 < num746; num747++)
                {
                    float num748 = (float)Main.rand.Next(-35, 36) * 0.02f;
                    float num749 = (float)Main.rand.Next(-35, 36) * 0.02f;
                    num748 *= 10f;
                    num749 *= 10f;
                    Projectile.NewProjectile(projectile.position, new Vector2(num748, num749), 307, (int)((double)projectile.damage * 0.75), (int)((double)projectile.knockBack * 0.35), Main.myPlayer);
                }
            }
        }
    }
}
