using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Localization;

namespace JourneyRecipes.Items
{

    public class JourneyRecipesGlobalItem : GlobalItem
    {
        const string Cactus = "cactusSet";
        const string ChlorophyteMelee = "chlorophyteMaskSet";
        const string Fossil = "fossilSet";
        const string Gladiator = "gladiatorSet";
        const string Molten = "moltenSet";
        const string Necro = "necroSet";
        const string Ninja = "ninjaSet";
        const string Solar = "solarFlareSet";
        const string Turtle = "turtleSet";
        public override void SetDefaults(Item item)
        {
            bool ms = Config.Instance.allowMaxStack;
            bool sc = Config.Instance.allowSellChange;
            bool ws = Config.Instance.allowWeaponStat;
            bool tr = Config.Instance.allowThrowingToRanged;
            bool ts = Config.Instance.allowToolStat;
            bool ac = Config.Instance.allowAccessoryStat;
            bool ar = Config.Instance.allowArmorStat;
            if (ms)
                switch (item.type)
                {
                    case 8:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 27:
                    case 57:
                    case 59:
                    case 62:
                    case 75:
                    case 86:
                    case 117:
                    case 175:
                    case 194:
                    case 195:
                    case 282:
                    case 286:
                    case 307:
                    case 308:
                    case 309:
                    case 310:
                    case 311:
                    case 312:
                    case 313:
                    case 314:
                    case 315:
                    case 316:
                    case 317:
                    case 318:
                    case 369:
                    case 381:
                    case 382:
                    case 391:
                    case 427:
                    case 428:
                    case 429:
                    case 430:
                    case 431:
                    case 432:
                    case 433:
                    case 523:
                    case 703:
                    case 704:
                    case 705:
                    case 706:
                    case 974:
                    case 1006:
                    case 1184:
                    case 1191:
                    case 1198:
                    case 1225:
                    case 1245:
                    case 1257:
                    case 1329:
                    case 1333:
                    case 1557:
                    case 1828:
                    case 2171:
                    case 2274:
                    case 2357:
                    case 2358:
                    case 3002:
                    case 3004:
                    case 3045:
                    case 3112:
                    case 3114:
                    case 3261:
                    case 3467:
                        item.maxStack = 999;
                        break;
                    case 167:
                    case 2896:
                    case 3547:
                        item.maxStack = 99;
                        break;
                }
            if (sc)
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
                        item.value = Item.sellPrice(gold: 1, silver: 50);//orb/heart loot
                        break;
                    case 2757:
                    case 2760:
                    case 2763:
                    case 3381:
                        item.value = Item.sellPrice(gold: 7);//+3 lunar arm
                        break;
                    case 2758:
                    case 2761:
                    case 2764:
                    case 3382:
                        item.value = Item.sellPrice(gold: 14);
                        break;
                    case 2759:
                    case 2762:
                    case 2765:
                    case 3383:
                        item.value = Item.sellPrice(gold: 10, silver: 50);
                        break;
                    case 3020:
                    case 3021:
                    case 3022:
                    case 3023:
                        item.value = Item.sellPrice(gold: 6);//+3hook nights edge
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
                        item.value = Item.sellPrice(gold: 8);//mimic drops
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
                        item.value = Item.sellPrice(silver: 60);//adam bar
                        break;
                    case 880:
                        item.value = Item.sellPrice(silver: 39);//crim bar
                        break;
                    case 1198:
                        item.value = Item.sellPrice(silver: 68);//tit bar
                        break;
                    case 1257:
                        item.value = Item.sellPrice(silver: 13);//crim ore
                        break;
                    case 3094:
                        item.value = Item.sellPrice(copper: 5);//jav
                        break;
                    case 3187:
                        item.value = Item.sellPrice(silver: 35);//+3 glad arm
                        break;
                    case 3188:
                        item.value = Item.sellPrice(silver: 28);
                        break;
                    case 3189:
                        item.value = Item.sellPrice(silver: 21);
                        break;
                    case 1121:
                    case 1123:
                    case 2888:
                        item.value = Item.sellPrice(gold: 2);//qb drops
                        break;
                    case 1349:
                        item.value = Item.sellPrice(copper: 2);//party bull
                        break;
                }
            if (item.type == ItemID.Acorn) item.autoReuse = true;
            if (ws)
            {
                UpdateWeaponStat(item);
            }
            if (tr)
            {
                UpdateDamageClass(item);
            }
            if (ts)
            {
                UpdateToolStat(item);
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
            if (ar)
            {
                UpdateArmorSetDefaults(item);
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
        public override void UpdateEquip(Item item, Player player)
        {
            bool ar = Config.Instance.allowArmorStat;
            bool tr = Config.Instance.allowThrowingToRanged;
            if (ar)
            {
                UpdateArmorStats(item, player);
            }
            if (tr)
            {
                switch (item.type)
                {
                    case 256:
                        player.thrownVelocity -= .15f;
                        player.magicCrit += 3;
                        player.meleeCrit += 3;
                        player.rangedCrit += 3;
                        break;
                    case 257:
                        player.thrownDamage -= .15f;
                        player.magicCrit += 3;
                        player.meleeCrit += 3;
                        player.rangedCrit += 3;
                        break;
                    case 258:
                        player.thrownCrit -= 10;
                        player.magicCrit += 3;
                        player.meleeCrit += 3;
                        player.rangedCrit += 3;
                        break;
                    case 3374:
                        player.rangedCrit += 4;
                        player.thrownVelocity -= .2f;
                        break;
                    case 3375:
                        player.rangedDamage += .05f;
                        player.thrownDamage -= .2f;
                        break;
                    case 3376:
                        player.rangedCrit += 4;
                        player.thrownCrit -= 15;
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
                    item.useStyle = ItemUseStyleID.SwingThrow;
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
                    item.useStyle = ItemUseStyleID.Stabbing;
                    item.damage = 10;
                    item.melee = true;
                    item.useTime = 22;
                    item.useAnimation = 22;
                    item.knockBack = 5f;
                    item.width = 44;
                    item.height = 44;
                    item.rare = ItemRarityID.Blue;
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
        private void UpdateDamageClass(Item item)
        {
            if (item.thrown)
            {
                item.melee = false;
                item.thrown = false;
                item.ranged = true;
            }
            switch (item.type)
            {
                case 3374:
                    item.defense = 4;
                    break;
                case 3375:
                    item.defense = 5;
                    break;
                case 3376:
                    item.defense = 4;
                    break;
            }
        }
        private void UpdateToolStat(Item item)
        {
            switch (item.type)
            {
                case 2341:
                    item.pick = 59;
                    item.useTime = 13;
                    item.useAnimation = 22;
                    item.useTurn = true;
                    break;
                case 2798:
                    item.axe = 0;
                    item.useAnimation = 25;
                    item.useTime = 6;
                    item.shootSpeed = 36f;
                    item.tileBoost = 11;
                    break;
            }
        }
        private void UpdateArmorStats(Item item, Player player)
        {
            switch (item.type)
            {
                case 123:
                case 124:
                case 125:
                    player.magicDamage += .02f;
                    break;
                case 228:
                case 230:
                case 960:
                case 962:
                    player.magicCrit += 2;
                    break;
                case 229:
                case 961:
                    player.magicCrit -= 4;
                    player.magicDamage += .06f;
                    break;
                case 231:
                    player.meleeCrit += 7;
                    break;
                case 232:
                    player.meleeDamage += .07f;
                    break;
                case 233:
                    player.meleeSpeed += .07f;
                    break;
                case 1833:
                    player.maxMinions += 1;
                    break;
                case 1834:
                    player.moveSpeed += .2f;
                    break;
                case 2763:
                    player.meleeCrit += 9;
                    break;
                case 2764:
                    player.meleeDamage += .07f;
                    break;
                case 3777:
                    player.maxMinions += 1;
                    player.statManaMax2 -= 40;
                    player.minionDamage += .1f;
                    break;
                case 3778:
                    player.maxMinions -= 1;
                    player.statManaMax2 += 40;
                    player.magicDamage += .1f;
                    break;
                case 3797:
                    player.magicDamage += .1f;
                    break;
                case 3802:
                    player.meleeCrit -= 5;
                    break;
                case 3804:
                    player.GetModPlayer<JourneyRecipesPlayer>().Ammo10 = true;
                    break;
                case 3808:
                    player.meleeCrit += 5;
                    break;
                case 3871:
                    player.meleeDamage += .1f;
                    break;
                case 3873:
                    player.moveSpeed -= .1f;
                    break;
                case 3874:
                    player.magicDamage += .05f;
                    player.minionDamage += .05f;
                    break;
                case 3875:
                    player.magicDamage -= .05f;
                    player.minionDamage -= .05f;
                    player.manaCost -= .15f;
                    break;
                case 3876:
                    player.moveSpeed += .2f;
                    break;
                case 3878:
                    player.GetModPlayer<JourneyRecipesPlayer>().Ammo20 = true;
                    break;
                case 3879:
                    player.rangedCrit += 10;
                    break;
                case 3881:
                    player.meleeCrit += 5;
                    break;
                case 3882:
                    player.moveSpeed += 0.1f;
                    break;
            }
        }
        private void UpdateArmorSetDefaults(Item item)
        {
            switch (item.type)
            {
                case 151:
                case 959:
                    item.defense = 6;
                    break;
                case 152:
                    item.defense = 7;
                    break;
                case 153:
                    item.defense = 6;
                    break;
                case 895:
                    item.defense = 1;
                    break;
                case 1001:
                    item.defense = 20;
                    break;
                case 1832:
                    item.defense = 9;
                    break;
                case 1833:
                    item.defense = 11;
                    break;
                case 1934:
                    item.defense = 10;
                    break;
                case 2763:
                case 2764:
                case 2765:
                    item.lifeRegen = 2;
                    break;
                case 3187:
                case 3189:
                    item.defense = 5;
                    break;
                case 3188:
                    item.defense = 6;
                    break;
                case 3800:
                    item.defense = 13;
                    item.lifeRegen = 4;
                    break;
                case 3802:
                    item.defense = 18;
                    break;
                case 3871:
                    item.defense = 20;
                    break;
                case 3872:
                    item.defense = 24;
                    item.lifeRegen = 8;
                    break;
                case 3873:
                    item.defense = 24;
                    break;

            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if (ws)
            {
                if (item.type == ItemID.FlowerofFrost) target.AddBuff(BuffID.Frostburn, 8 * 60);//yes im too dumb to calculate this
                if (item.type == ItemID.WandofSparking && Main.rand.NextBool(1)) target.AddBuff(BuffID.OnFire, Main.rand.Next(30, 180));
            }
        }
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if ((item.type == ItemID.BreathingReed || item.type == ItemID.Umbrella) && ws)
            {
                return rand.Next(new int[] { PrefixID.Legendary, PrefixID.Godly, PrefixID.Savage, PrefixID.Superior, PrefixID.Demonic, PrefixID.Deadly, PrefixID.Unpleasant, PrefixID.Murderous, PrefixID.Massive, PrefixID.Agile, PrefixID.Forceful, PrefixID.Sharp, PrefixID.Strong, PrefixID.Dangerous, PrefixID.Large, PrefixID.Zealous, PrefixID.Hurtful, PrefixID.Pointy, PrefixID.Quick, PrefixID.Nasty, PrefixID.Bulky, PrefixID.Ruthless, PrefixID.Keen, PrefixID.Nimble, PrefixID.Light, PrefixID.Heavy, PrefixID.Lazy, PrefixID.Small, PrefixID.Slow, PrefixID.Damaged, PrefixID.Dull, PrefixID.Tiny, PrefixID.Weak, PrefixID.Sluggish, PrefixID.Shameful, PrefixID.Shoddy, PrefixID.Unhappy, PrefixID.Annoying, PrefixID.Terrible, PrefixID.Broken });
            }
            return base.ChoosePrefix(item, rand);
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if (ws && item.type == ItemID.SDMG)
            {
                return Main.rand.NextBool(3);
            }
            return base.ConsumeAmmo(item, player);
        }
        public override bool UseItem(Item item, Player player)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if (item.type == ItemID.Umbrella && ws)
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
            return base.UseItem(item, player);
        }
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings) return Cactus;
            if (head.type == ItemID.ChlorophyteMask && body.type == ItemID.ChlorophytePlateMail && legs.type == ItemID.ChlorophyteGreaves) return ChlorophyteMelee;
            if (head.type == ItemID.FossilHelm && body.type == ItemID.FossilShirt && legs.type == ItemID.FossilPants) return Fossil;
            if (head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings) return Gladiator;
            if (head.type == ItemID.MoltenHelmet && body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves) return Molten;
            if ((head.type == ItemID.NecroHelmet || head.type == ItemID.AncientNecroHelmet) && body.type == ItemID.NecroBreastplate && legs.type == ItemID.NecroGreaves) return Necro;
            if (head.type == ItemID.NinjaHood && body.type == ItemID.NinjaShirt && legs.type == ItemID.NinjaPants) return Ninja;
            if (head.type == ItemID.SolarFlareHelmet && body.type == ItemID.SolarFlareBreastplate && legs.type == ItemID.SolarFlareLeggings) return Solar;
            if (head.type == ItemID.TurtleHelmet && body.type == ItemID.TurtleScaleMail && legs.type == ItemID.TurtleLeggings) return Turtle;
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            bool ar = Config.Instance.allowArmorStat;
            bool tr = Config.Instance.allowThrowingToRanged;
            if (ar)
            {
                switch (set)
                {
                    case Cactus:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Cactus");
                        player.statDefense -= 1;
                        player.thorns = .5f;
                        break;
                    case ChlorophyteMelee:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.ChlorophyteMelee");
                        player.endurance += .05f;
                        break;
                    case Gladiator:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Gladiator");
                        player.noKnockback = true;
                        break;
                    case Necro:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Necro");
                        player.ammoCost80 = false;
                        player.ammoCost75 = false;
                        player.rangedCrit += 10;
                        break;
                    case Molten:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Molten");
                        player.meleeDamage -= .07f;
                        player.buffImmune[BuffID.OnFire] = true;
                        break;
                    case Solar:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Solar");
                        break;
                    case Turtle:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Turtle");
                        player.endurance += .15f;
                        player.turtleThorns = false;
                        player.turtleArmor = false;
                        player.thorns = 2f;
                        break;
                }
            }
            if (tr)
            {
                switch (set)
                {
                    case Fossil:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Fossil");
                        player.thrownCost33 = false;
                        player.thrownCost50 = false;
                        player.ammoCost80 = true;
                        break;
                    case Ninja:
                        player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Ninja");
                        player.thrownCost33 = false;
                        player.thrownCost50 = false;
                        player.moveSpeed += .2f;
                        break;
                }
            }
        }
    }
}