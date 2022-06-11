using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItem : GlobalItem
    {

        public override void SetDefaults(Item item)
        {
            bool ws = Config.Instance.allowWeaponStat;
            bool ac = Config.Instance.allowAccessoryStat;
            if (GetInstance<Config>().allowSellChange)
            {
                switch (item.type)
                {
                    case 64:
                    case 96:
                    case 111:
                    case 115:
                    case 162:
                    case 800:
                    case 802:
                    case 1256:
                    case 1290:
                    case 3062:
                        item.value = Item.sellPrice(gold: 1, silver: 50);//shadow orb & crimson heart loot
                        break;
                    case 2757:
                    case 2760:
                    case 2763:
                    case 3381:
                        item.value = Item.sellPrice(gold: 7);//+3 lunar helmets
                        break;
                    case 2758:
                    case 2761:
                    case 2764:
                    case 3382:
                        item.value = Item.sellPrice(gold: 14);//lunar breastplates
                        break;
                    case 2759:
                    case 2762:
                    case 2765:
                    case 3383:
                        item.value = Item.sellPrice(gold: 10, silver: 50);//lunar leggings
                        break;
                    case 3020:
                    case 3021:
                    case 3022:
                    case 3023:
                        item.value = Item.sellPrice(gold: 6);//+3hook
                        break;
                    case 1829:
                    case 1916:
                    case 273:
                        item.value = Item.sellPrice(gold: 4);
                        break;
                    case 533:
                    case 1265:
                        item.value = Item.sellPrice(gold: 7);//uzi megashark
                        break;
                    case 3006:
                    case 3007:
                    case 3008:
                    case 3012:
                    case 3013:
                    case 3014:
                    case 3015:
                    case 3016:
                    case 3029:
                    case 3030:
                    case 3051:
                        item.value = Item.sellPrice(gold: 8);//biome mimic drops
                        break;
                    case 56:
                        item.value = Item.sellPrice(silver: 10);//demon ore
                        break;
                    case 57:
                        item.value = Item.sellPrice(silver: 30);//demon bar
                        break;
                    case 113:
                    case 155:
                    case 157:
                    case 163:
                    case 164:
                    case 329:
                    case 3313:
                        item.value = Item.sellPrice(gold: 1, silver: 75);//dungeon loot
                        break;
                    case 391:
                        item.value = Item.sellPrice(silver: 60);//adamantite bar
                        break;
                    case 880:
                        item.value = Item.sellPrice(silver: 39);//crimtane bar
                        break;
                    case 1198:
                        item.value = Item.sellPrice(silver: 68);//titanium bar
                        break;
                    case 1257:
                        item.value = Item.sellPrice(silver: 13);//crimtane ore
                        break;
                    case 3094:
                        item.value = Item.sellPrice(copper: 5);//javelin
                        break;
                    case 3187:
                        item.value = Item.sellPrice(silver: 35);//glaidator helmet
                        break;
                    case 3188:
                        item.value = Item.sellPrice(silver: 28);//gladiator breastplate
                        break;
                    case 3189:
                        item.value = Item.sellPrice(silver: 21);//gladiator leggings
                        break;
                    case 1121:
                    case 1123:
                    case 2888:
                        item.value = Item.sellPrice(gold: 2);//Queen Bee drops
                        break;
                    case 1349:
                        item.value = Item.sellPrice(copper: 2);//party bullet
                        break;
                }
            }
            if (item.type == 27) item.autoReuse = true;
            if (ws)
            {
                UpdateWeaponStat(item);
            }
            if (ac)
            {
                switch (item.type)//small so no method needed
                {
                    case 49:
                    case 860:
                        item.lifeRegen = 2;
                        break;
                    case 3016:
                        item.defense = 8;
                        break;
                }
            }
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            bool ac = Config.Instance.allowAccessoryStat;
            if (ac)
            {
                switch (item.type)
                {
                    case 211:
                    case 897:
                        player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
                        break;
                    case 908:
                        player.lavaRose = true;
                        break;
                    case 936:
                        player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
                        break;
                    case 1343:
                        player.meleeDamage += .02f;
                        player.meleeSpeed += .02f;
                        player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
                        break;
                    case 2221:
                        player.statManaMax2 += 20;
                        break;
                }
            }
        }
        private void UpdateWeaponStat(Item item)
        {
            switch (item.type)
            {
                case 46:
                    item.damage = 18;
                    item.scale = 1.4f;
                    break;
                case 112:
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                    item.mana = 12;
                    break;
                case 121:
                    item.useTime = 30;
                    item.useAnimation = item.useTime;
                    item.damage = 40;
                    break;
                case 127:
                    item.mana = 6;
                    item.damage = 17;
                    break;
                case 154:
                    item.useAnimation = item.useTime;//bug relating to this mod
                    break;
                case 155:
                    item.damage = 26;
                    item.knockBack = 3f;
                    break;
                case 164:
                    item.useTime = 10;
                    item.useAnimation = 10;
                    break;
                case 186:
                    item.damage = 10;
                    item.knockBack = 4f;
                    item.useTime = 27;
                    item.useAnimation = 27;
                    item.useStyle = 1;
                    item.melee = true;
                    break;
                case 198:
                case 199:
                case 200:
                case 201:
                case 202:
                case 203:
                    item.damage = 25;
                    break;
                case 273:
                    item.autoReuse = true;
                    item.useTime = 21;
                    item.useAnimation = item.useTime;
                    break;
                case 277:
                    item.damage = 14;
                    item.knockBack = 6f;
                    break;
                case 281:
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    break;
                case 426:
                    item.useTime = 29;
                    item.useAnimation = 30;
                    item.damage = 43;
                    break;
                case 434:
                    item.damage = 17;
                    break;
                case 435:
                    item.useTime = 24;
                    item.useAnimation = item.useTime;
                    break;
                case 436:
                    item.useTime = 22;
                    item.useAnimation = item.useTime;
                    break;
                case 481:
                    item.useTime = 19;
                    item.useAnimation = item.useTime;
                    break;
                case 482:
                    item.damage = 56;
                    item.useTime = 26;
                    item.useAnimation = item.useTime;
                    break;
                case 484:
                    item.damage = 49;
                    break;
                case 518:
                    item.damage = 32;
                    item.mana = 5;
                    break;
                case 519:
                    item.damage = 50;
                    item.mana = 9;
                    item.useTime = 15;
                    item.useAnimation = item.useTime;
                    break;
                case 578:
                    item.damage = 53;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                    break;
                case 671:
                    item.damage = 85;
                    break;
                case 682:
                    item.damage = 50;
                    break;
                case 683://Unholy Trident, apply 10% pierce damage penalty
                    item.damage = 88;
                    break;
                case 723:
                    item.scale = 1.3f;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 725:
                    item.damage = 39;
                    item.autoReuse = true;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                    break;
                case 726:
                    item.mana = 12;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                    break;
                case 758:
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 759://Rocket Launcher, add 2x damage bonus to 1st direct hit on single target
                    item.damage = 45;
                    break;
                case 788:
                    item.mana = 12;
                    item.damage = 35;
                    break;
                case 946:
                    item.useStyle = 3;
                    item.damage = 10;
                    item.melee = true;
                    item.useTime = 22;
                    item.useAnimation = 22;
                    item.knockBack = 5f;
                    item.width = 44;
                    item.height = 44;
                    item.rare = 1;
                    break;
                case 1130:
                    item.damage = 12;
                    break;
                case 1179:
                    item.damage = 9;
                    break;
                case 1185:
                    item.damage = 45;
                    break;
                case 1187:
                    item.useTime = 23;
                    item.useAnimation = item.useTime;
                    break;
                case 1192:
                    item.damage = 50;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    break;
                case 1194:
                    item.useTime = 21;
                    item.useAnimation = item.useTime;
                    break;
                case 1199:
                    item.damage = 58;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    break;
                case 1201:
                    item.useTime = 18;
                    item.useAnimation = item.useTime;
                    break;
                case 1226:
                    item.damage = 95;
                    break;
                case 1227:
                    item.damage = 57;
                    break;
                case 1255:
                    item.damage = 50;
                    break;
                case 1264:
                    item.damage = 60;
                    item.mana = 11;
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                    break;
                case 1295:
                    item.damage = 80;
                    item.useTime = 10;
                    item.useAnimation = item.useTime;
                    break;
                case 1297:
                    item.damage = 90;
                    break;
                case 1302:
                    item.damage = 11;
                    break;
                case 1325:
                    item.damage = 12;
                    break;
                case 1341:
                    item.damage = 19;
                    break;
                case 1342:
                    item.damage = 15;
                    break;
                case 1444://Shadowbeam Staff, reduce pierce penalty to 10%
                    item.damage = 60;
                    item.useTime = 15;
                    item.useTime = item.useAnimation;
                    break;
                case 1446:
                    item.damage = 65;
                    item.mana = 15;
                    break;
                case 1553:
                    item.damage = 85;
                    break;
                case 1784:
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    break;
                case 1785:
                    item.damage = 60;
                    break;
                case 1802://Raven Staff, double projectile speed in GlobalProjectile
                    item.damage = 55;
                    break;
                case 1835://Stake Launcher, increase pierce penalty to 10%
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                    break;
                case 2223:
                    item.damage = 85;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 2364:
                    item.damage = 12;
                    break;
                case 2424:
                    item.damage = 70;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    item.knockBack = 8f;
                    break;
                case 2608:
                    item.damage = 25;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 2622:
                    item.damage = 90;
                    item.useTime = 40;
                    item.useAnimation = item.useTime;
                    break;
                case 3003:
                    item.damage = 8;
                    break;
                case 3009:
                    item.damage = 14;
                    break;
                case 3010:
                    item.damage = 10;
                    break;
                case 3011:
                    item.damage = 12;
                    break;
                case 3012:
                    item.damage = 59;
                    break;
                case 3019:
                    item.damage = 22;
                    item.knockBack = 5.5f;
                    item.useTime = 13;
                    item.useAnimation = item.useTime;
                    break;
                case 3029://Daedalus Stormbow, shoot 20% slower while using Holy, Unholy, Hellfire, Jester arrows
                    item.damage = 38;
                    break;
                case 3051:
                    item.damage = 25;
                    break;
                case 3069:
                    item.damage = 14;
                    item.crit = 10;
                    item.useTime = 26;
                    item.useAnimation = item.useTime;
                    break;
                case 3210:
                    item.useTime = 10;
                    item.useAnimation = item.useTime;
                    break;
                case 3281:
                    item.damage = 18;
                    break;
                case 3284:
                    item.damage = 54;
                    break;
                case 3291:
                    item.damage = 95;
                    item.crit = 10;
                    break;
                case 3315:
                    item.damage = 39;
                    break;
                case 3316:
                    item.damage = 49;
                    break;
                case 3378:
                    item.damage = 20;
                    break;
                case 3542:
                    item.mana = 12;
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                    break;
                case 3764:
                case 3765:
                case 3766:
                case 3767:
                case 3768:
                case 3769:
                    item.damage = 42;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 3779:
                    item.mana = 14;
                    item.useTime = 22;
                    item.useAnimation = item.useTime;
                    break;
                case 3787:
                    item.mana = 17;
                    break;
                case 3788:
                    item.damage = 24;
                    item.useTime = 48;
                    item.useAnimation = item.useTime;
                    break;
                case 3823:
                    item.damage = 85;
                    item.scale = 1.13f;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    break;
                case 3827:
                    //item.damage = 180;
                    break;
                case 3835:
                    item.damage = 50;
                    //item.scale = 1.35f;
                    break;
                case 3852:
                    item.damage = 32;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    item.autoReuse = true;
                    break;
                case 3854:
                    item.damage = 32;
                    item.useTime = 18;
                    item.useAnimation = item.useTime;
                    break;
                case 3858:
                    item.damage = 140;
                    break;
                case 3870:
                    item.damage = 100;
                    break;
            }
        }

        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (GetInstance<Config>().allowWeaponStat)
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
        }
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            if (GetInstance<Config>().allowWeaponStat)
            {
                if (item.type == 186 || item.type == 946)
                {
                    return rand.Next(new int[] { 81, 59, 4, 37, 60, 20, 55, 46, 2, 44, 38, 5, 54, 3, 1, 61, 53, 6, 42, 51, 12, 57, 36, 45, 15, 14, 49, 9, 47, 40, 10, 7, 56, 48, 13, 41, 11, 50, 8, 39 });
                }
            }
            return base.ChoosePrefix(item, rand);
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (GetInstance<Config>().allowWeaponStat)
            {
                if (item.type == 1553)
                {
                    return Main.rand.NextBool(3);
                }
            }
            return base.ConsumeAmmo(item, player);
        }
        public override bool UseItem(Item item, Player player)
        {
            if (GetInstance<Config>().allowWeaponStat)
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
                    return true;
                }
            }
            return base.UseItem(item, player);
        }
    }
}