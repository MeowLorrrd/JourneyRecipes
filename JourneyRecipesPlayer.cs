using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes
{
    public class JourneyRecipesPlayer : ModPlayer
    {
        public bool PlayerInvis;
        public bool PlayerFeral;
        public bool PlayerAutouse;
        public bool PlayerTitanGlove;
        public bool CactusThorns;
        public bool Ammo10;
        public bool Ammo20;
        public bool Sharpened;
        public bool StarCloak;
        public bool BeeBeeBee;
        public override void ResetEffects()
        {
            PlayerInvis = false;
            PlayerFeral = false;
            PlayerTitanGlove = false;
            PlayerAutouse = false;
            CactusThorns = false;
            Ammo10 = false;
            Ammo20 = false;
            Sharpened = false;
            StarCloak = false;
            BeeBeeBee = false;
        }
        public override bool PreItemCheck()
        {
            if (Config.Instance.allowAccessoryStat && PlayerFeral && player.HeldItem.melee)
            {
                PlayerAutouse = player.HeldItem.autoReuse;
                player.HeldItem.autoReuse = true;
            }//code above from Fargo's Souls
            if (Config.Instance.AllowBuffStat && Sharpened && player.HeldItem.melee)
            {
                player.armorPenetration += 8;//+4 vanilla armor pen
            }
            if (Config.Instance.allowWeaponStat && (player.HeldItem.type == ItemID.NettleBurst || player.HeldItem.type == ItemID.WaspGun || player.HeldItem.type == ItemID.CrystalVileShard))
            {
                player.armorPenetration += 10;
            }
            if (Config.Instance.allowWeaponStat && player.HeldItem.type == 3029)
            {
            }
            return base.PreItemCheck();
        }
        public override bool ConsumeAmmo(Item weapon, Item ammo)
        {
            if (ModContent.GetInstance<Config>().allowArmorStat)
            {
                if (Ammo10)
                {
                    return !Main.rand.NextBool(10);
                }
                else if (Ammo20)
                {
                    return !Main.rand.NextBool(5);
                }
            }
            return base.ConsumeAmmo(weapon, ammo);
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
                    }
                }
            }
            base.Hurt(pvp, quiet, damage, hitDirection, crit);
        }
    }
}
