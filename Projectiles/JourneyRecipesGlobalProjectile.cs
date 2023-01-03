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
            if (projectile.type == 22)
            {
                projectile.penetrate = 5;
            }
            else if (projectile.type == 23)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 12;
            }
            else if (projectile.type == 24)
            {
                projectile.penetrate = 7;
            }
            else if (projectile.type == 36)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 15;
            }
            else if (projectile.type == 93)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 20;
            }
            else if (projectile.type == 189)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 238)
            {
                projectile.timeLeft = 18000;
            }
            else if (projectile.type == 239)
            {
                projectile.penetrate = 5;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 242)
            {
                projectile.penetrate = 3;
                projectile.extraUpdates = 7;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 15;
            }
            else if (projectile.type == 244)
            {
                projectile.timeLeft = 18000;
            }
            else if (projectile.type == 245)
            {
                projectile.penetrate = 2;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 250)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 251)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 254)
            {
                projectile.timeLeft = 900;
                projectile.tileCollide = true;
            }
            else if (projectile.type == 260)
            {
                projectile.penetrate = 1;
            }
            else if (projectile.type == 263)
            {
                projectile.penetrate = 4;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 8;
                projectile.timeLeft = 180;
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
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
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
            else if (projectile.type == 409)
            {
                projectile.timeLeft = 300;
            }
            else if (projectile.type == 410)
            {
                projectile.timeLeft = 100;
            }
            else if (projectile.type == 433)
            {
                //TODO: MODelse ifY DAMAGE
            }
            else if (projectile.type == 502)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 10;
            }
            else if (projectile.type == 503)
            {
                projectile.extraUpdates = 1;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 30;
                projectile.damage = 170;
            }
            else if (projectile.type == 511 || projectile.type == 512 || projectile.type == 513)
            {
                projectile.penetrate = -1;
            }
            else if (projectile.type == 524)
            {
                projectile.penetrate = 5;
                projectile.extraUpdates = 5;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 532)
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
            else if (projectile.type == 533)
            {
                projectile.netImportant = true;
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 8;
            }
            else if (projectile.type == 569)
            {
                projectile.timeLeft = 240;
            }
            else if (projectile.type == 603)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 604)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 10;
            }
            else if (projectile.type == 697)
            {
                projectile.scale = 1.35f;
                projectile.damage = 150;
                projectile.ownerHitCheck = true;
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = 12;
            }
            /* else if (projectile.type == 699)
            {
                projectile.usesIDStaticNPCImmunity = true;
                projectile.idStaticNPCHitCooldown = 20;
                projectile.ownerHitCheck = true;
            }
             else if (projectile.type == 700)
            {
                projectile.usesLocalNPCImmunity = true;
                projectile.localNPCHitCooldown = -1;
            }*///TODO: rewrite proj AI
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
        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.type == 19)
            {
                if (Main.rand.NextBool(2))
                {
                    target.AddBuff(24, 180);
                }
            }
            else if (projectile.type == 113)
            {
                if (Main.rand.NextBool(2))
                {
                    target.AddBuff(44, 180);
                }
            }
            else if (projectile.type == 253)
            {
                target.AddBuff(44, Main.rand.Next(5, 14) * 60);
            }
            else if (projectile.type == 954)
            {
                if (Main.rand.NextBool(2))
                {
                    target.AddBuff(24, Main.rand.Next(1, 5) * 60);
                }
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
            switch (projectile.type)
            {
                case 47:
                    if (Main.player[projectile.owner].wet && Main.rand.NextBool(2))
                    {
                        int num10 = Dust.NewDust(Main.player[projectile.owner].position, Main.player[projectile.owner].width, Main.player[projectile.owner].height, 15, 0f, 0f, 100, default, 0.8f);
                        Main.dust[num10].velocity *= 0.1f;
                    }
                    break;
            }
        }
        public override bool PreAI(Projectile projectile)
        {
            if (projectile.aiStyle == 57 || projectile.type == 344)
            {
                NorthPoleSpearProj(projectile);
                return false;
            }
            /*if (projectile.aiStyle == 9)
            {
                MagicMissilesProj(projectile);
                return false;
            }*///needs work im lazy
            if (projectile.aiStyle == 92)
            {
                if (projectile.type >= 511 && projectile.type <= 513)
                {
                    ToxicFlaskProj(projectile);
                    return false;
                }
            }
            if (projectile.aiStyle == 46)
            {
                RainbowGun(projectile);
                return false;
            }
            if (projectile.aiStyle == 50)
            {
                if (projectile.type != 296)
                {
                    return true;
                }
                if (projectile.localAI[0] == 0f)
                {
                    Main.PlaySound(SoundID.Item74, projectile.position);
                    projectile.localAI[0] += 1f;
                }
                projectile.ai[0] += 1f;
                if (projectile.type == 296)
                {
                    projectile.ai[0] += 3f;
                }
                float num387 = 25f;
                if (projectile.ai[0] > 540f)
                {
                    num387 -= (projectile.ai[0] - 180f) / 2f;
                }
                if (num387 <= 0f)
                {
                    num387 = 0f;
                    projectile.Kill();
                }
                if (projectile.type == 296)
                {
                    num387 *= 0.7f;
                }
                for (int num388 = 0; (float)num388 < num387; num388++)
                {
                    float num389 = Main.rand.Next(-10, 11);
                    float num390 = Main.rand.Next(-10, 11);
                    float num391 = Main.rand.Next(3, 9);
                    float num392 = (float)Math.Sqrt(num389 * num389 + num390 * num390);
                    num392 = num391 / num392;
                    num389 *= num392;
                    num390 *= num392;
                    int num393 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 174, 0f, 0f, 100, default, 1.5f);
                    Main.dust[num393].noGravity = true;
                    Main.dust[num393].position.X = projectile.Center.X;
                    Main.dust[num393].position.Y = projectile.Center.Y;
                    Main.dust[num393].position.X += Main.rand.Next(-10, 11);
                    Main.dust[num393].position.Y += Main.rand.Next(-10, 11);
                    Main.dust[num393].velocity.X = num389;
                    Main.dust[num393].velocity.Y = num390;
                }
                return false;
            }
            if (projectile.aiStyle == 12 && projectile.type == 22)
            {
                float num129 = 0.01f;
                float num130 = 0.15f;
                projectile.scale -= num129;
                if (projectile.scale <= 0f)
                {
                    projectile.Kill();
                }
                if (projectile.ai[0] > 3f)
                {
                    projectile.velocity.Y += num130;
                    for (int num131 = 0; num131 < 1; num131++)
                    {
                        for (int num132 = 0; num132 < 3; num132++)
                        {
                            float num133 = projectile.velocity.X / 3f * (float)num132;
                            float num134 = projectile.velocity.Y / 3f * (float)num132;
                            int num135 = 6;
                            int num136 = Dust.NewDust(new Vector2(projectile.position.X + (float)num135, projectile.position.Y + (float)num135), projectile.width - num135 * 2, projectile.height - num135 * 2, 172, 0f, 0f, 100, default, 1.2f);
                            Main.dust[num136].noGravity = true;
                            Dust dust2 = Main.dust[num136];
                            dust2.velocity *= 0.3f;
                            dust2 = Main.dust[num136];
                            dust2.velocity += projectile.velocity * 0.5f;
                            Main.dust[num136].position.X -= num133;
                            Main.dust[num136].position.Y -= num134;
                        }
                        if (Main.rand.NextBool(8))
                        {
                            int num137 = 6;
                            int num138 = Dust.NewDust(new Vector2(projectile.position.X + (float)num137, projectile.position.Y + (float)num137), projectile.width - num137 * 2, projectile.height - num137 * 2, 172, 0f, 0f, 100, default, 0.75f);
                            Dust dust2 = Main.dust[num138];
                            dust2.velocity *= 0.5f;
                            dust2 = Main.dust[num138];
                            dust2.velocity += projectile.velocity * 0.5f;
                        }
                    }
                }
                else
                {
                    projectile.ai[0] += 1f;
                }
                return false;
            }
            return base.PreAI(projectile);
        }
        private void NorthPoleSpearProj(Projectile proj)
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

        /* private void MagicMissilesProj(Projectile proj)
         {
             if (proj.type == 491)
             {
                 //MagicMissilesProjOld(proj);
                 return;
             }
             int num = 32;
             Player player = Main.player[proj.owner];
             int num2 = Main.maxTilesY * 16;
             int num3 = 0;
             if (proj.ai[0] >= 0f)
             {
                 num3 = (int)(proj.ai[1] / (float)num2);
             }
             bool flag = proj.ai[0] == -1f || proj.ai[0] == -2f;
             if (proj.type == 34)
             {
                 if (proj.frameCounter++ >= 4)
                 {
                     proj.frameCounter = 0;
                     if (++proj.frame >= Main.projFrames[proj.type])
                     {
                         proj.frame = 0;
                     }
                 }
                 if (proj.penetrate == 1 && proj.ai[0] >= 0f && num3 == 0)
                 {
                     proj.ai[1] += num2;
                     num3 = 1;
                     proj.netUpdate = true;
                 }
                 if (proj.penetrate == 1 && proj.ai[0] == -1f)
                 {
                     proj.ai[0] = -2f;
                     proj.netUpdate = true;
                 }
                 if (num3 > 0 || proj.ai[0] == -2f)
                 {
                     proj.localAI[0] += 1f;
                 }
             }
             if (proj.owner == Main.myPlayer)
             {
                 if (proj.ai[0] >= 0f)
                 {
                     if (player.channel && player.HeldItem.shoot == proj.type)
                     {
                         Vector2 pointPoisition = Main.MouseWorld;
                         //player.LimitPointToPlayerReachableArea(ref pointPoisition);
                         if (proj.ai[0] != pointPoisition.X || proj.ai[1] != pointPoisition.Y)
                         {
                             proj.netUpdate = true;
                             proj.ai[0] = pointPoisition.X;
                             proj.ai[1] = pointPoisition.Y + (float)(num2 * num3);
                         }
                     }
                     else
                     {
                         proj.netUpdate = true;
                         proj.ai[0] = -1f;
                         proj.ai[1] = -1f;
                         int num4 = FindTargetWithLineOfSight();
                         if (num4 != -1)
                         {
                             proj.ai[1] = num4;
                         }
                         else if (proj.velocity.Length() < 2f)
                         {
                             proj.velocity = proj.DirectionFrom(player.Center) * num;
                         }
                         else
                         {
                             proj.velocity = proj.velocity.SafeNormalize(Vector2.Zero) * num;
                         }
                     }
                 }
                 if (flag && proj.ai[1] == -1f)
                 {
                     int num5 = FindTargetWithLineOfSight();
                     if (num5 != -1)
                     {
                         proj.ai[1] = num5;
                         proj.netUpdate = true;
                     }
                 }
             }
             Vector2? vector = null;
             float amount = 1f;
             if (proj.ai[0] > 0f && proj.ai[1] > 0f)
             {
                 vector = new Vector2(proj.ai[0], proj.ai[1] % (float)num2);
             }
             if (flag && proj.ai[1] >= 0f)
             {
                 int num6 = (int)proj.ai[1];
                 if (Main.npc.IndexInRange(num6))
                 {
                     NPC nPC = Main.npc[num6];
                     if (nPC.CanBeChasedBy(this))
                     {
                         vector = nPC.Center;
                         float t = proj.Distance(vector.Value);
                         float num7 = JRUtils.GetLerpValue(0f, 100f, t, clamped: true) * JRUtils.GetLerpValue(600f, 400f, t, clamped: true);
                         amount = MathHelper.Lerp(0f, 0.2f, JRUtils.GetLerpValue(200f, 20f, 1f - num7, clamped: true));
                     }
                     else
                     {
                         proj.ai[1] = -1f;
                         proj.netUpdate = true;
                     }
                 }
             }
             bool flag2 = false;
             if (flag)
             {
                 flag2 = true;
             }
             if (vector.HasValue)
             {
                 Vector2 value = vector.Value;
                 if (proj.Distance(value) >= 64f)
                 {
                     flag2 = true;
                     Vector2 v = value - proj.Center;
                     Vector2 vector2 = v.SafeNormalize(Vector2.Zero);
                     float num8 = Math.Min(num, v.Length());
                     Vector2 value2 = vector2 * num8;
                     if (proj.velocity.Length() < 4f)
                     {
                         proj.velocity += proj.velocity.SafeNormalize(Vector2.Zero).RotatedBy(0.78539818525314331).SafeNormalize(Vector2.Zero) * 4f;
                     }
                     if (proj.velocity.HasNaNs())
                     {
                         proj.Kill();
                     }
                     proj.velocity = Vector2.Lerp(proj.velocity, value2, amount);
                 }
                 else
                 {
                     proj.velocity *= 0.3f;
                     proj.velocity += (value - proj.Center) * 0.3f;
                     flag2 = proj.velocity.Length() >= 2f;
                 }
                 if (proj.timeLeft < 60)
                 {
                     proj.timeLeft = 60;
                 }
             }
             if (flag && proj.ai[1] < 0f)
             {
                 if (proj.velocity.Length() != (float)num)
                 {
                     proj.velocity = JRUtils.MoveTowards(proj.position, proj.velocity.SafeNormalize(Vector2.UnitY) * num, 4f);
                 }
                 if (proj.timeLeft > 300)
                 {
                     proj.timeLeft = 300;
                 }
             }
             if (flag2 && proj.velocity != Vector2.Zero)
             {
                 proj.rotation = proj.rotation.AngleTowards(proj.velocity.ToRotation(), (float)Math.PI / 4f);
             }
             else
             {
                 proj.rotation = proj.rotation.AngleLerp(0f, 0.2f);
             }
             bool flag3 = proj.velocity.Length() > 0.1f && Vector2.Dot(proj.oldVelocity.SafeNormalize(Vector2.Zero), proj.velocity.SafeNormalize(Vector2.Zero)) < 0.2f;
             if (proj.type == 16)
             {
                 if (proj.soundDelay == 0 && Math.Abs(proj.velocity.X) + Math.Abs(proj.velocity.Y) > 2f)
                 {
                     proj.soundDelay = 10;
                     Main.PlaySound(SoundID.Item9, proj.position);
                 }
                 if (Main.rand.NextBool(9))
                 {
                     int num9 = Dust.NewDust(proj.position, proj.width, proj.height, 15, 0f, 0f, 100, default, 2f);
                     Main.dust[num9].velocity *= 0.3f;
                     Main.dust[num9].position.X = proj.position.X + (float)(proj.width / 2) + 4f + (float)Main.rand.Next(-4, 5);
                     Main.dust[num9].position.Y = proj.position.Y + (float)(proj.height / 2) + (float)Main.rand.Next(-4, 5);
                     Main.dust[num9].noGravity = true;
                     Main.dust[num9].velocity += Main.rand.NextVector2Circular(2f, 2f);
                 }
                 if (flag3)
                 {
                     int num10 = Main.rand.Next(2, 5);
                     for (int i = 0; i < num10; i++)
                     {
                         Dust dust = Dust.NewDustDirect(proj.position, proj.width, proj.height, 15, 0f, 0f, 100, default, 1.5f);
                         dust.velocity *= 0.3f;
                         dust.position = proj.Center;
                         dust.noGravity = true;
                         dust.velocity += Main.rand.NextVector2Circular(0.5f, 0.5f);
                         dust.fadeIn = 2.2f;
                     }
                 }
             }
             if (proj.type != 34)
             {
                 return;
             }
             float lerpValue = JRUtils.GetLerpValue(0f, 10f, proj.localAI[0], clamped: true);
             Color newColor = Color.Lerp(Color.Transparent, Color.Crimson, lerpValue);
             if (Main.rand.NextBool(6))
             {
                 Dust dust2 = Dust.NewDustDirect(proj.Center, 0, 0, 6, proj.velocity.X * 0.2f, proj.velocity.Y * 0.2f, 100, newColor, 3.5f);
                 dust2.noGravity = true;
                 dust2.velocity *= 1.4f;
                 dust2.velocity += Main.rand.NextVector2Circular(1f, 1f);
                 dust2.velocity += proj.velocity * 0.15f;
             }
             if (Main.rand.NextBool(12))
             {
                 Dust dust3 = Dust.NewDustDirect(proj.Center, 0, 0, 6, proj.velocity.X * 0.2f, proj.velocity.Y * 0.2f, 100, newColor, 1.5f);
                 dust3.velocity += Main.rand.NextVector2Circular(1f, 1f);
                 dust3.velocity += proj.velocity * 0.15f;
             }
             if (flag3)
             {
                 int num11 = Main.rand.Next(2, 5 + (int)(lerpValue * 4f));
                 for (int j = 0; j < num11; j++)
                 {
                     Dust dust4 = Dust.NewDustDirect(proj.position, proj.width, proj.height, 6, 0f, 0f, 100, newColor, 1.5f);
                     dust4.velocity *= 0.3f;
                     dust4.position = proj.Center;
                     dust4.noGravity = true;
                     dust4.velocity += Main.rand.NextVector2Circular(0.5f, 0.5f);
                     dust4.fadeIn = 2.2f;
                     dust4.position += (dust4.position - proj.Center) * lerpValue * 10f;
                 }
             }
         }*/

        private void ToxicFlaskProj(Projectile proj)
        {
            if (proj.aiStyle == 92)
            {
                bool flag39 = proj.type >= 511 && proj.type <= 513;
                proj.tileCollide = false;
                proj.penetrate = -1;

                if (Main.netMode != 1 && proj.localAI[0] == 0f)
                {
                    if (proj.direction == 0)
                    {
                        proj.direction = 1;
                    }
                }
                proj.ai[0] += 1f;
                if (proj.ai[1] >= 1f)
                {
                    proj.ai[0] += 2f;
                }
                float num811 = 260f;
                if (proj.ai[0] > num811)
                {
                    proj.Kill();
                    proj.ai[0] = num811;
                    return;
                }
                float fromValue = proj.ai[0] / num811;
                if (flag39)
                {
                    proj.Opacity = JRUtils.Remap(fromValue, 0f, 0.3f, 0f, 1f) * JRUtils.Remap(fromValue, 0.3f, 1f, 1f, 0f) * 0.7f;
                }
                proj.localAI[0] += proj.direction;
                proj.rotation = (float)proj.whoAmI * 0.4002029f + proj.localAI[0] * ((float)Math.PI * 2f) / 480f;
                if (flag39)
                {
                    proj.velocity *= 0.96f;
                    Rectangle rectangle5 = new Rectangle((int)proj.position.X, (int)proj.position.Y, proj.width, proj.height);
                    for (int num812 = 0; num812 < 1000; num812++)
                    {
                        if (num812 == proj.whoAmI)
                        {
                            continue;
                        }
                        Projectile projectile3 = Main.projectile[num812];
                        if (!projectile3.active || projectile3.type < 511 || projectile3.type > 513)
                        {
                            continue;
                        }
                        Rectangle value11 = new Rectangle((int)projectile3.position.X, (int)projectile3.position.Y, projectile3.width, projectile3.height);
                        if (!rectangle5.Intersects(value11))
                        {
                            continue;
                        }
                        Vector2 vector100 = projectile3.Center - proj.Center;
                        if (vector100 == Vector2.Zero)
                        {
                            if (num812 < proj.whoAmI)
                            {
                                vector100.X = -1f;
                                vector100.Y = 1f;
                            }
                            else
                            {
                                vector100.X = 1f;
                                vector100.Y = -1f;
                            }
                        }
                        Vector2 vector101 = vector100.SafeNormalize(Vector2.UnitX) * 0.005f;
                        proj.velocity = Vector2.Lerp(proj.velocity, proj.velocity - vector101, 0.6f);
                        projectile3.velocity = Vector2.Lerp(projectile3.velocity, projectile3.velocity + vector101, 0.6f);
                    }
                }
                Vector2 vector102 = proj.velocity.SafeNormalize(Vector2.Zero);
                Vector2 pos = proj.Center + vector102 * 16f;
                if (flag39 && JRUtils.IsWorldPointSolid(pos))
                {
                    proj.velocity = Vector2.Lerp(proj.velocity, proj.velocity - vector102 * 1f, 0.5f);
                }
            }
        }
        private void RainbowGun(Projectile proj)
        {
            int num363 = 2400;
            if (proj.type == 250)
            {
                Point point2 = proj.Center.ToTileCoordinates();
                if (!WorldGen.InWorld(point2.X, point2.Y, 2) || Main.tile[point2.X, point2.Y] == null)
                {
                    proj.Kill();
                    return;
                }
                if (proj.owner == Main.myPlayer)
                {
                    proj.localAI[0] += 1f;
                    if (proj.localAI[0] > 4f)
                    {
                        proj.localAI[0] = 3f;
                        Projectile.NewProjectile(proj.Center.X, proj.Center.Y, proj.velocity.X * 0.001f, proj.velocity.Y * 0.001f, 251, proj.damage, proj.knockBack, proj.owner);
                    }
                    if (proj.timeLeft > num363)
                    {
                        proj.timeLeft = num363;
                    }
                }
                float num364 = 1f;
                if (proj.velocity.Y < 0f)
                {
                    num364 -= proj.velocity.Y / 3f;
                }
                proj.ai[0] += num364;
                if (proj.ai[0] > 30f)
                {
                    proj.velocity.Y += 0.5f;
                    if (proj.velocity.Y > 0f)
                    {
                        proj.velocity.X *= 0.95f;
                    }
                    else
                    {
                        proj.velocity.X *= 1.05f;
                    }
                }
                float x3 = proj.velocity.X;
                float y3 = proj.velocity.Y;
                float num365 = (float)Math.Sqrt(x3 * x3 + y3 * y3);
                num365 = 15.95f * proj.scale / num365;
                x3 *= num365;
                y3 *= num365;
                proj.velocity.X = x3;
                proj.velocity.Y = y3;
                proj.rotation = (float)Math.Atan2(proj.velocity.Y, proj.velocity.X) - 1.57f;
                return;
            }
            if (proj.localAI[0] == 0f)
            {
                if (proj.velocity.X > 0f)
                {
                    proj.spriteDirection = -1;
                    proj.rotation = (float)Math.Atan2(proj.velocity.Y, proj.velocity.X) - 1.57f;
                }
                else
                {
                    proj.spriteDirection = 1;
                    proj.rotation = (float)Math.Atan2(proj.velocity.Y, proj.velocity.X) - 1.57f;
                }
                proj.localAI[0] = 1f;
                proj.timeLeft = num363;
            }
            proj.velocity.X *= 0.98f;
            proj.velocity.Y *= 0.98f;
            if (proj.rotation == 0f)
            {
                proj.alpha = 255;
            }
            else if (proj.timeLeft < 10)
            {
                proj.alpha = 255 - (int)(255f * (float)proj.timeLeft / 10f);
            }
            else if (proj.timeLeft > num363 - 10)
            {
                int num366 = num363 - proj.timeLeft;
                proj.alpha = 255 - (int)(255f * (float)num366 / 10f);
            }
            else
            {
                proj.alpha = 0;
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
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
            if (projectile.type == ProjectileID.MagnetSphereBall)
            {
                if (projectile.tileCollide)
                {
                    if (projectile.velocity.X != oldVelocity.X)
                    {
                        projectile.velocity.X = oldVelocity.X * -1f;
                    }
                    if (projectile.velocity.Y != oldVelocity.Y)
                    {
                        projectile.velocity.Y = oldVelocity.Y * -1f;
                    }
                }
                return false;
            }
            return base.OnTileCollide(projectile, oldVelocity);
        }
        public override bool PreKill(Projectile projectile, int timeLeft)
        {
            if (projectile.type == 91 || projectile.type == 92)
            {
                HolyArrowKill(projectile);
                return false;
            }
            else if (projectile.type == 295)
            {
                if (projectile.owner == Main.myPlayer)
                {
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, 296, (int)((double)projectile.damage * 0.75), projectile.knockBack, projectile.owner);
                }
            }
            else if (projectile.type == 306)
            {
                EatersBiteKill(projectile);
                return false;
            }
            else if (projectile.type == 510)
            {
                ToxicFlaskKill(projectile);
                return false;
            }
            else if (projectile.type == 569)
            {
                SpiritFlameKill(projectile);
                return false;
            }
            return base.PreKill(projectile, timeLeft);
        }
        private void HolyArrowKill(Projectile projectile)
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
        private void EatersBiteKill(Projectile projectile)
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
        private void ToxicFlaskKill(Projectile projectile)
        {
            Main.PlaySound(SoundID.Item107, projectile.position);
            Gore.NewGore(projectile.Center, -projectile.oldVelocity * 0.2f, 704);
            Gore.NewGore(projectile.Center, -projectile.oldVelocity * 0.2f, 705);
            if (projectile.owner == Main.myPlayer)
            {
                int num404 = Main.rand.Next(20, 31);
                for (int num405 = 0; num405 < num404; num405++)
                {
                    Vector2 vector45 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
                    vector45.Normalize();
                    vector45 *= (float)Main.rand.Next(10, 201) * 0.01f;
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vector45.X, vector45.Y, 511 + Main.rand.Next(3), projectile.damage, 1f, projectile.owner);
                }
            }
        }
        private void SpiritFlameKill(Projectile projectile)
        {
            if (projectile.ai[0] >= 0f)
            {
                int num201 = 80;
                projectile.position = projectile.Center;
                projectile.width = (projectile.height = num201);
                projectile.Center = projectile.position;
                projectile.Damage();
                Main.PlaySound(SoundID.Item14, projectile.position);
                int num202 = 15;
                int num203 = num202 + 15;
                for (int num204 = 0; num204 < num203; num204++)
                {
                    int num205 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 27, 0f, 0f, 0, default, 2f + Main.rand.NextFloat() * 0.5f);
                    Main.dust[num205].noGravity = true;
                    if (num204 < num202)
                    {
                        float num206 = (float)(num204 + 1) / (float)num202 * ((float)Math.PI * 2f);
                        Main.dust[num205].fadeIn = 1.5f + Main.rand.NextFloat() * 0.5f;
                        Main.dust[num205].position = projectile.Center;
                        Main.dust[num205].velocity = Vector2.UnitY.RotatedBy(num206) * (5f + Main.rand.NextFloat() * 1.5f);
                    }
                    else
                    {
                        Main.dust[num205].position = projectile.Center + Vector2.UnitY.RotatedByRandom(3.1415927410125732) * Main.rand.NextFloat() * projectile.width / 3f;
                        Main.dust[num205].fadeIn = 0.5f + Main.rand.NextFloat() * 0.5f;
                        Dust dust2 = Main.dust[num205];
                        dust2.velocity *= 2f;
                    }
                }
                for (int num207 = 0; num207 < 10; num207++)
                {
                    int num208 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 0, default, 1.5f);
                    Main.dust[num208].position = projectile.Center + Vector2.UnitX.RotatedByRandom(3.1415927410125732).RotatedBy(projectile.velocity.ToRotation()) * projectile.width / 3f;
                    Main.dust[num208].fadeIn = 0.5f + Main.rand.NextFloat() * 0.5f;
                    Main.dust[num208].noGravity = true;
                    Dust dust2 = Main.dust[num208];
                    dust2.velocity *= 1.5f;
                }
            }
        }
    }
}
