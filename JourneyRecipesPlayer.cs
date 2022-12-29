using JourneyRecipes.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Mono.Cecil.Cil;
using System;
using System.Runtime.Remoting.Channels;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes
{
    public class JourneyRecipesPlayer : ModPlayer
    {
        public bool autoReuseGlove;
        public bool PlayerAutouse;
        public bool CactusThorns;
        public bool Ammo10;
        public bool StarCloak;
        public bool BeeBeeBee;
        public Item BoneGloveItem;
        public int boneGloveTimer;
        public bool anglerSetSpawnReduction;
        public bool ItemAnimationJustStarted => player.itemAnimation == player.itemAnimationMax - 1;
        public override void ResetEffects()
        {
            autoReuseGlove = false;
            PlayerAutouse = false;
            CactusThorns = false;
            Ammo10 = false;
            StarCloak = false;
            BeeBeeBee = false;
            BoneGloveItem = null;
            anglerSetSpawnReduction = false;
        }
        public Vector2 ApplyRangeComposition(float rangeCompensation, Vector2 startPos, Vector2 targetPos)
        {
            Vector2 v = targetPos - startPos;
            Vector2 vector = v.SafeNormalize(Vector2.Zero);
            vector.Y -= 1f;
            float num = v.Length();
            num = (float)Math.Pow(num / 700f, 2.0) * 700f;
            targetPos.Y += vector.Y * num * rangeCompensation * 1f;
            targetPos.X += (0f - vector.X) * num * rangeCompensation * 1f;
            return targetPos;
        }
        public void Update_NPCCollision()
        {
            Rectangle rectangle = new Rectangle((int)player.position.X, (int)player.position.Y, player.width, player.height);
            for (int i = 0; i < 200; i++)
            {
                if (!Main.npc[i].active || Main.npc[i].friendly || Main.npc[i].damage <= 0)
                {
                    continue;
                }
                int specialHitSetter = -1;
                switch (Main.npc[i].type)
                {
                    case 396:
                    case 397:
                    case 398:
                    case 400:
                    case 401:
                        specialHitSetter = 1;
                        break;
                    case 636:
                        specialHitSetter = 1;
                        break;
                }
                if ((specialHitSetter == -1 && player.immune) || (player.dash == 2 && i == player.eocHit && player.eocDash > 0) || player.npcTypeNoAggro[Main.npc[i].type])
                {
                    continue;
                }
                float damageMultiplier = 1f;
                //Main.npc[i].position += Main.npc[i].netOffset;
                Rectangle npcRect = new Rectangle((int)Main.npc[i].position.X, (int)Main.npc[i].position.Y, Main.npc[i].width, Main.npc[i].height);
                NPC.GetMeleeCollisionData(rectangle, i, ref specialHitSetter, ref damageMultiplier, ref npcRect);
                if (rectangle.Intersects(npcRect))
                {
                    if (player.npcTypeNoAggro[Main.npc[i].type])
                    {
                        continue;
                    }
                    float knockback = 10f;
                    
                    int num3 = -1;
                    if (Main.npc[i].position.X + (float)(Main.npc[i].width / 2) < player.position.X + (float)(player.width / 2))
                    {
                        num3 = 1;
                    }
                    bool flag3 = !player.immune;
                    if (specialHitSetter >= 0)
                    {
                        flag3 = player.hurtCooldowns[specialHitSetter] == 0;
                    }
                    if (player.whoAmI == Main.myPlayer && CactusThorns && flag3 && !Main.npc[i].dontTakeDamage)
                    {
                        int damage = 15;
                        if (Main.expertMode)
                        {
                            damage = 30;
                        }
                        ApplyDamageToNPC(Main.npc[i], damage, knockback, -num3, crit: false);
                    }
                }
            }
        }
        public void ApplyDamageToNPC(NPC npc, int damage, float knockback, int direction, bool crit)
        {
            int num = Item.NPCtoBanner(npc.BannerID());
            if (num > 0 && player.NPCBannerBuff[num])
            {
                damage = ((!Main.expertMode) ? ((int)((float)damage * ItemID.Sets.BannerStrength[Item.BannerToItem(num)].NormalDamageDealt)) : ((int)((float)damage * ItemID.Sets.BannerStrength[Item.BannerToItem(num)].ExpertDamageDealt)));
            }
            OnHit(npc.Center.X, npc.Center.Y, npc);

            if (player.armorPenetration > 0)
            {
                damage += npc.checkArmorPenetration(player.armorPenetration);
            }
            int dmg = (int)npc.StrikeNPC(damage, knockback, direction, crit);
            if (player.accDreamCatcher)
            {
                player.addDPS(dmg);
            }
            if (Main.netMode != 0)
            {
                NetMessage.SendData(28, -1, -1, null, npc.whoAmI, damage, knockback, direction, crit.ToInt());
            }
            int num2 = Item.NPCtoBanner(npc.BannerID());
            if (num2 >= 0)
            {
                player.lastCreatureHit = num2;
            }
        }
        public void OnHit(float x, float y, Entity victim)
        {
            if (Main.myPlayer != player.whoAmI)
            {
                return;
            }
            _ = player.inventory[player.selectedItem].type;
            for (int j = 0; j < 1000; j++)
            {
                if (Main.projectile[j].owner == player.whoAmI && Main.projectile[j].type == 226)
                {
                    player.petalTimer = 50;
                    Vector2 vector3 = new Vector2(Main.projectile[j].position.X + (float)player.width * 0.5f, Main.projectile[j].position.Y + (float)player.height * 0.5f);
                    float num6 = x - vector3.X;
                    float num7 = y - vector3.Y;
                    float num8 = (float)Math.Sqrt(num6 * num6 + num7 * num7);
                    num8 = 12f / num8;
                    num6 *= num8;
                    num7 *= num8;
                    Projectile.NewProjectile(Main.projectile[j].Center.X - 4f, Main.projectile[j].Center.Y, num6, num7, 227, 100, 10, player.whoAmI);
                    break;
                }
            }
            PlayerHooks.OnHitAnything(player, x, y, victim);
        }
        public override void PostItemCheck()
        {
            if (BoneGloveItem != null && !BoneGloveItem.IsAir && boneGloveTimer == 0 && player.itemAnimation > 0 && player.inventory[player.selectedItem].damage > 0)
            {
                boneGloveTimer = 60;
                Vector2 center = player.Center;
                Vector2 vector = player.DirectionTo(ApplyRangeComposition(0.2f, center, Main.MouseWorld)) * 10f;
                Projectile.NewProjectile(center.X, center.Y, vector.X, vector.Y, 532, 25, 5f, player.whoAmI);
            }
        }
        public override void PostUpdateMiscEffects()
        {
            Update_NPCCollision();
            player.rulerLine = true;
            if (boneGloveTimer > 0)
            {
                boneGloveTimer--;
            }
        }
        public override bool PreItemCheck()
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowAccessoryStat && autoReuseGlove && player.inventory[player.selectedItem].melee)
            {
                PlayerAutouse = player.inventory[player.selectedItem].autoReuse;
                player.inventory[player.selectedItem].autoReuse = true;
            }//code above from Fargo's Souls
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowWeaponStat && (player.inventory[player.selectedItem].type == ItemID.NettleBurst || player.inventory[player.selectedItem].type == ItemID.WaspGun || player.inventory[player.selectedItem].type == ItemID.CrystalVileShard))
            {
                player.armorPenetration += 10;
            }
            return base.PreItemCheck();
        }
        public override bool ConsumeAmmo(Item item, Item ammo)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowArmorStat)
            {
                if (Ammo10 && item.ranged)
                {
                    return !Main.rand.NextBool(10);
                }
            }
            return base.ConsumeAmmo(item, ammo);
        }
        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)//1.4 source code in Player.Hurt()
        {
            int cooldownCounter = -1;
            bool flag = !player.immune;
            switch (cooldownCounter)
            {
                case 0:
                case 1:
                case 3:
                case 4:
                    flag = player.hurtCooldowns[cooldownCounter] <= 0;
                    break;
            }
            if (flag)
            {
                int num = (int)damage;
                double num2 = Main.CalculatePlayerDamage(num, player.statDefense);
                if (num2 >= 1.0)
                {
                    if (player.whoAmI == Main.myPlayer)
                    {
                        //if (starCloakItem != null && !starCloakItem.IsAir && (cooldownCounter == -1 || cooldownCounter == 1))
                        if (ModContent.GetInstance<JourneyRecipesServerConfig>().allowAccessoryStat)
                        {
                            if (StarCloak)
                            {
                                for (int num3 = 0; num3 < 3; num3++)
                                {
                                    float x = player.position.X + (float)Main.rand.Next(-400, 400);
                                    float y = player.position.Y - (float)Main.rand.Next(500, 800);
                                    Vector2 vector = new Vector2(x, y);
                                    float num4 = player.position.X + (float)(player.width / 2) - vector.X;
                                    float num5 = player.position.Y + (float)(player.height / 2) - vector.Y;
                                    num4 += (float)Main.rand.Next(-100, 101);
                                    float num6 = (float)Math.Sqrt(num4 * num4 + num5 * num5);
                                    num6 = 23f / num6;
                                    num4 *= num6;
                                    num5 *= num6;
                                    int type = 92;
                                    int num7 = 75;
                                    if (Main.expertMode)
                                    {
                                        num7 *= 2;
                                    }
                                    int num8 = Projectile.NewProjectile(vector, new Vector2(num4, num5), type, num7, 5f, player.whoAmI);
                                    Main.projectile[num8].ai[1] = player.position.Y;
                                }
                            }
                            if (BeeBeeBee)
                            {
                                player.AddBuff(48, 300);
                            }
                            if (player.panic)
                            {
                                player.AddBuff(63, 480);
                            }
                        }
                    }
                }
            }
            base.Hurt(pvp, quiet, damage, hitDirection, crit);
        }
        public override void PostUpdateBuffs()
        {
            base.PostUpdateBuffs();
            for (int j = 0; j < 22; j++)
            {
                if (player.buffType[j] <= 0 || player.buffTime[j] <= 0)
                {
                    continue;
                }
                if (player.buffType[j] == 159 && player.inventory[player.selectedItem].melee)
                {
                    player.armorPenetration = 12;
                }
            }
        }
        
    }
}
