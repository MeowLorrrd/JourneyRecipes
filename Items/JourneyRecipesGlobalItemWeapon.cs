using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemWeapon : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<Config>().allowWeaponStat;
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == 27)
            {
                item.autoReuse = true;
            }
            else if (item.type == 46)
            {
                item.damage = 18;
                item.scale = 1.4f;
            }
            else if (item.type == 112)
            {
                item.mana = 12;
                item.useTime = 16;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 121)
            {
                item.useTime = 30;
                item.useAnimation = item.useTime;
                item.damage = 40;
            }
            else if (item.type == 127)
            {
                item.mana = 6;
                item.damage = 17;

            }
            else if (item.type == 154)
            {
                item.useAnimation = item.useTime;//bug relating to this mod
            }
            else if (item.type == 155)
            {
                item.damage = 26;
                item.knockBack = 3f;
            }
            else if (item.type == 164)
            {
                item.useTime = 10;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 186)
            {
                item.damage = 10;
                item.knockBack = 4f;
                item.useTime = 27;
                item.useAnimation = 27;
                item.useStyle = 1;
                item.melee = true;
            }
            else if (item.type == 198 || item.type == 199 || item.type == 200 || item.type == 201 || item.type == 202 || item.type == 203)
            {
                item.damage = 25;
            }
            else if (item.type == 273)
            {
                item.autoReuse = true;
                item.useTime = 21;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 277)
            {
                item.damage = 14;
                item.knockBack = 6f;
            }
            else if (item.type == 281)
            {
                item.useTime = 25;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 426)
            {
                item.useTime = 29;
                item.useAnimation = 30;
                item.damage = 43;
            }
            else if (item.type == 434)
            {
                item.damage = 17;
            }
            else if (item.type == 435)
            {
                item.useTime = 24;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 436)
            {
                item.useTime = 22;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 481)
            {
                item.useTime = 19;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 482)
            {
                item.damage = 56;
                item.useTime = 26;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 484)
            {
                item.damage = 49;
            }
            else if (item.type == 518)
            {
                item.damage = 32;
                item.mana = 5;
            }
            else if (item.type == 519)
            {
                item.damage = 50;
                item.mana = 9;
                item.useTime = 15;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 578)
            {
                item.damage = 53;
                item.useTime = 16;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 671)
            {
                item.damage = 85;
            }
            else if (item.type == 682)
            {
                item.damage = 50;
            }
            else if (item.type == 683)
            {
                item.damage = 88;
            }
            else if (item.type == 723)
            {
                item.scale = 1.3f;
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 725)
            {
                item.damage = 39;
                item.autoReuse = true;
                item.useTime = 16;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 726)
            {
                item.mana = 12;
                item.useTime = 16;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 758)
            {
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 759)//Rocket Launcher, add 2x damage bonus to 1st direct hit on single target
            {
                item.damage = 45;
            }
            else if (item.type == 788)
            {
                item.mana = 12;
                item.damage = 35;
            }
            else if (item.type == 946)
            {
                item.useStyle = 3;
                item.damage = 10;
                item.melee = true;
                item.useTime = 22;
                item.useAnimation = 22;
                item.knockBack = 5f;
                item.width = 44;
                item.height = 44;
                item.rare = 1;
            }
            else if (item.type == 1130)
            {
                item.damage = 12;
            }
            else if (item.type == 1179)
            {
                item.damage = 9;
            }
            else if (item.type == 1185)
            {
                item.damage = 45;
            }
            else if (item.type == 1187)
            {
                item.useTime = 23;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1187)
            {

            }
            else if (item.type == 1192)
            {
                item.damage = 50;
                item.useTime = 25;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1194)
            {
                item.useTime = 21;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1199)
            {
                item.damage = 58;
                item.useTime = 25;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1201)
            {
                item.useTime = 18;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1226)
            {
                item.damage = 95;
            }
            else if (item.type == 1227)
            {
                item.damage = 57;
            }
            else if (item.type == 1255)
            {
                item.damage = 50;
            }
            else if (item.type == 1264)
            {
                item.damage = 60;
                item.mana = 11;
                item.useTime = 12;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1295)
            {
                item.damage = 80;
                item.useTime = 10;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1297)
            {
                item.damage = 90;
            }
            else if (item.type == 1302)
            {
                item.damage = 11;
            }
            else if (item.type == 1325)
            {
                item.damage = 12;
            }
            else if (item.type == 1341)
            {
                item.damage = 19;
            }
            else if (item.type == 1342)
            {
                item.damage = 15;
            }
            else if (item.type == 1444)
            {
                item.damage = 60;
                item.useTime = 15;
                item.useTime = item.useAnimation;
            }
            else if (item.type == 1446)
            {
                item.damage = 65;
                item.mana = 15;
            }
            else if (item.type == 1553)
            {
                item.damage = 85;
            }
            else if (item.type == 1784)
            {
                item.useTime = 25;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 1785)
            {
                item.damage = 60;
            }
            else if (item.type == 1802)//Raven Staff, double projectile speed in GlobalProjectile
            {
                item.damage = 55;
            }
            else if (item.type == 1835)
            {
                item.useTime = 12;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 2223)
            {
                item.damage = 85;
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 2364)
            {
                item.damage = 12;
            }
            else if (item.type == 2424)
            {
                item.damage = 70;
                item.useTime = 20;
                item.useAnimation = item.useTime;
                item.knockBack = 8f;
            }
            else if (item.type == 2608)
            {
                item.damage = 25;
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 2622)
            {
                item.damage = 90;
                item.useTime = 40;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3003)
            {
                item.damage = 8;
            }
            else if (item.type == 3009)
            {
                item.damage = 14;
            }
            else if (item.type == 3010)
            {
                item.damage = 10;
            }
            else if (item.type == 3011)
            {
                item.damage = 12;
            }
            else if (item.type == 3012)
            {
                item.damage = 59;
            }
            else if (item.type == 3019)
            {
                item.damage = 22;
                item.knockBack = 5.5f;
                item.useTime = 13;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3029)//Daedalus Stormbow, shoot 20% slower while using Holy, Unholy, Hellfire, Jester arrows
            {
                item.damage = 38;
            }
            else if (item.type == 3051)
            {
                item.damage = 25;
            }
            else if (item.type == 3069)
            {
                item.damage = 14;
                item.crit = 10;
                item.useTime = 26;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3210)
            {
                item.useTime = 10;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3281)
            {
                item.damage = 18;
            }
            else if (item.type == 3284)
            {
                item.damage = 54;
            }
            else if (item.type == 3291)
            {
                item.damage = 95;
                item.crit = 10;
            }
            else if (item.type == 3315)
            {
                item.damage = 39;
            }
            else if (item.type == 3316)
            {
                item.damage = 49;
            }
            else if (item.type == 3378)
            {
                item.damage = 20;
            }
            else if (item.type == 3542)
            {
                item.mana = 12;
                item.useTime = 12;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3764 || item.type == 3765 || item.type == 3766 || item.type == 3767 || item.type == 3768 || item.type == 3769)
            {
                item.damage = 42;
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3779)
            {
                item.mana = 14;
                item.useTime = 22;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3787)
            {
                item.mana = 17;
            }
            else if (item.type == 3788)
            {
                item.damage = 24;
                item.useTime = 48;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3823)
            {
                item.damage = 85;
                item.scale = 1.13f;
                item.useTime = 20;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3827)
            {
                //item.damage = 180;
            }
            else if (item.type == 3835)
            {
                item.damage = 50;
                //item.scale = 1.35f;
            }
            else if (item.type == 3852)
            {
                item.damage = 32;
                item.useTime = 25;
                item.useAnimation = item.useTime;
                item.autoReuse = true;
            }
            else if (item.type == 3854)
            {
                item.damage = 32;
                item.useTime = 18;
                item.useAnimation = item.useTime;
            }
            else if (item.type == 3858)
            {
                item.damage = 140;
            }
            else if (item.type == 3870)
            {
                item.damage = 100;
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (item.type == 1264)
            {
                target.AddBuff(44, 8 * 60);
            }
            else if (item.type == 3069)
            {
                if (Main.rand.NextBool(1))
                {
                    target.AddBuff(24, Main.rand.Next(30, 180));
                }
            }

        }
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            int[] prefix = new int[] { //prefix ids
                81, 59, 4, 37, 60,
                20, 55, 46, 2, 44,
                38, 5, 54, 3, 1,
                61, 53, 6, 42, 51,
                12, 57, 36, 45, 15,
                14, 49, 9, 47, 40,
                10, 7, 56, 48, 13,
                41, 11, 50, 8, 39 };
            if (item.type == 186 || item.type == 946)
            {
                return rand.Next(prefix);
            }
            return base.ChoosePrefix(item, rand);
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (item.type == 1553)
            {
                return Main.rand.NextBool(3);
            }
            return base.ConsumeAmmo(item, player);
        }
        public override void UseStyle(Item item, Player player)
        {
            if (item.type == 946)
            {
                if (player.direction == 1)
                {
                    player.itemRotation = 1.575f;
                    player.itemLocation -= new Vector2(5, 25);
                }
                if (player.direction != 1)
                {
                    player.itemRotation = -1.575f;
                    player.itemLocation -= new Vector2(-5, 25);
                }
            }
        }
    }
}