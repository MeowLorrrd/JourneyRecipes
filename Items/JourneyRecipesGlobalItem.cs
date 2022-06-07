using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            bool ms = Config.Instance.allowMaxStack;
            bool sc = Config.Instance.allowSellChange;
            bool ws = Config.Instance.allowWeaponStat;
            bool tr = Config.Instance.allowThrowingToRanged;
            bool ts = Config.Instance.allowToolStat;
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
        }
        public static void UpdateWeaponStat(Item item)
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
        public static void UpdateDamageClass(Item item)
        {
            if (item.thrown)
            {
                item.melee = false;
                item.thrown = false;
                item.ranged = true;
            }
        }
        public static void UpdateToolStat(Item item)
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
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if (ws)
            {
                if (item.type == ItemID.FlowerofFrost) target.AddBuff(BuffID.Frostburn, 8);
                if (item.type == ItemID.WandofSparking && Main.rand.NextBool(1)) target.AddBuff(BuffID.OnFire, Main.rand.Next(3));
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
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            bool ws = Config.Instance.allowWeaponStat;
            if (ws)
            {
                if (item.type == ItemID.SDMG)
                {
                    #region strings
                    string GermanOld = "50% Chance, keine Munition zu verbrauchen";
                    string GermanNew = "66% Chance, keine Munition zu verbrauchen";
                    string EnglishOld = "50% chance to not consume ammo";
                    string EnglishNew = "66% chance to not consume ammo";
                    string SpanishOld = "Probabilidad del 50% de no gastar munición";
                    string SpanishNew = "Probabilidad del 66% de no gastar munición";
                    string FrenchOld = "50 % de chances de ne pas utiliser de munitions";
                    string FrenchNew = "66 % de chances de ne pas utiliser de munitions";
                    string ItalianOld = "50% di probabilità di non consumare munizioni";
                    string ItalianNew = "66% di probabilità di non consumare munizioni";
                    string PolishOld = "50% szans niezużycia amunicji";
                    string PolishNew = "66% szans niezużycia amunicji";
                    string PortugeseOld = "50% de chance de não consumir munição";
                    string PortugeseNew = "66% de chance de não consumir munição";
                    string RussianOld = "Шанс 50 % не потратить боеприпасы";
                    string RussianNew = "Шанс 66 % не потратить боеприпасы";
                    string ChineseOld = "50%的几率不消耗弹药";
                    string ChineseNew = "66%的几率不消耗弹药";
                    #endregion
                    #region new tooltips
                    foreach (TooltipLine line in tooltips)
                    {
                        if (line.text == GermanOld)
                        {
                            line.text = GermanNew;
                        }
                        if (line.text == EnglishOld)
                        {
                            line.text = EnglishNew;
                        }
                        if (line.text == SpanishOld)
                        {
                            line.text = SpanishNew;
                        }
                        if (line.text == FrenchOld)
                        {
                            line.text = FrenchNew;
                        }
                        if (line.text == ItalianOld)
                        {
                            line.text = ItalianNew;
                        }
                        if (line.text == PolishOld)
                        {
                            line.text = PolishNew;
                        }
                        if (line.text == PortugeseOld)
                        {
                            line.text = PortugeseNew;
                        }
                        if (line.text == RussianOld)
                        {
                            line.text = RussianNew;
                        }
                        if (line.text == ChineseOld)
                        {
                            line.text = ChineseNew;
                        }
                    }
                    #endregion//cringe formatting
                }
                if (item.type == ItemID.NettleBurst)
                {
                    #region strings
                    string GermanOld = "Beschwört einen Dornenspeer";
                    string GermanNew = "Ignoriert 10 Punkte der gegnerischen Verteidigung";
                    string EnglishOld = "Summons a thorn spear";
                    string EnglishNew = "Ignores 10 points of enemy Defense";
                    string SpanishOld = "Invoca una lanza de espinas";
                    string SpanishNew = "Ignora 10 puntos de la defensa del enemigo";
                    string FrenchOld = "Invoque une lance épineuse";
                    string FrenchNew = "Ignore 10 points de la défense ennemie";
                    string ItalianOld = "Evoca una lancia di spine";
                    string ItalianNew = "Ignora 10 punti della difesa nemica";
                    string PolishOld = "Przyzywa cierniową włócznię";
                    string PolishNew = "Ignoruje 10 punktów obrony przeciwnika";
                    string PortugeseOld = "Invoca uma lança de espinho";
                    string PortugeseNew = "Ignora 10 pontos de Defesa do inimigo";
                    string RussianOld = "Крапивный взрыв";
                    string RussianNew = "Игнорирует 10 очков защиты врага";
                    string ChineseOld = "召唤刺矛";
                    string ChineseNew = "忽略10点敌人防御";
                    #endregion
                    #region new tooltips
                    foreach (TooltipLine line in tooltips)
                    {
                        if (line.text == GermanOld) line.text = GermanNew;
                        if (line.text == EnglishOld) line.text = EnglishNew;
                        if (line.text == SpanishOld) line.text = SpanishNew;
                        if (line.text == FrenchOld) line.text = FrenchNew;
                        if (line.text == ItalianOld) line.text = ItalianNew;
                        if (line.text == PolishOld) line.text = PolishNew;
                        if (line.text == PortugeseOld) line.text = PortugeseNew;
                        if (line.text == RussianOld) line.text = RussianNew;
                        if (line.text == ChineseOld) line.text = ChineseNew;
                    }
                    #endregion//chad formatting
                }
            }
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
    }
}