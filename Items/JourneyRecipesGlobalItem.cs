using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            bool ms = Config.Instance.allowMaxStack;
            bool sc = Config.Instance.allowSellChange;
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
                        item.value = Item.sellPrice(gold: 6);//+2hook
                        break;
                    case 1829:
                    case 1916:
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
                    case 164:
                        item.value = Item.sellPrice(gold: 1, silver: 75);//handg
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
                }
            if (item.type == ItemID.Acorn) item.autoReuse = true;
            #region remove after testing stack
            /*if (Config.Instance.allowMaxStack)
            {
                if (item.type == ItemID.CopperBar || item.type == ItemID.TinBar || item.type == ItemID.IronBar || item.type == ItemID.LeadBar || item.type == ItemID.SilverBar || item.type == ItemID.TungstenBar || item.type == ItemID.GoldBar || item.type == ItemID.PlatinumBar || item.type == ItemID.DemoniteBar || item.type == ItemID.CrimtaneBar || item.type == ItemID.HellstoneBar || item.type == ItemID.CobaltBar || item.type == ItemID.PalladiumBar || item.type == ItemID.MythrilBar || item.type == ItemID.OrichalcumBar || item.type == ItemID.AdamantiteBar || item.type == ItemID.TitaniumBar || item.type == ItemID.HallowedBar || item.type == ItemID.ChlorophyteBar || item.type == ItemID.ShroomiteBar || item.type == ItemID.SpectreBar || item.type == ItemID.LunarBar || item.type == ItemID.MeteoriteBar || item.type == ItemID.Glowstick || item.type == ItemID.StickyGlowstick || item.type == ItemID.BouncyGlowstick || item.type == ItemID.SpelunkerGlowstick || item.type == ItemID.Torch || item.type == ItemID.BlueTorch || item.type == ItemID.BoneTorch || item.type == ItemID.CursedTorch || item.type == ItemID.DemonTorch || item.type == ItemID.GreenTorch || item.type == ItemID.IceTorch || item.type == ItemID.IchorTorch || item.type == ItemID.OrangeTorch || item.type == ItemID.PinkTorch || item.type == ItemID.PurpleTorch || item.type == ItemID.RainbowTorch || item.type == ItemID.RedTorch || item.type == ItemID.UltrabrightTorch || item.type == ItemID.WhiteTorch || item.type == ItemID.YellowTorch || item.type == ItemID.FallenStar || item.type == ItemID.Daybloom || item.type == ItemID.Blinkroot || item.type == ItemID.Deathweed || item.type == ItemID.Shiverthorn || item.type == ItemID.Waterleaf || item.type == ItemID.Moonglow || item.type == ItemID.Fireblossom || item.type == ItemID.DaybloomSeeds || item.type == ItemID.BlinkrootSeeds || item.type == ItemID.DeathweedSeeds || item.type == ItemID.ShiverthornSeeds || item.type == ItemID.WaterleafSeeds || item.type == ItemID.MoonglowSeeds || item.type == ItemID.FireblossomSeeds || item.type == ItemID.PumpkinSeed || item.type == ItemID.ShadowScale || item.type == ItemID.TissueSample)
                {
                    //item.maxStack = 999;
                }
                if (item.type == ItemID.Dynamite || item.type == ItemID.StickyDynamite || item.type == ItemID.BouncyDynamite)
                {
                    //item.maxStack = 99;
                }
            }*/
            #endregion
            #region remove after testing sell
            /*if (Config.Instance.allowSellChange)
            {
                if (item.type == ItemID.Musket || item.type == ItemID.ShadowOrb || item.type == ItemID.Vilethorn || item.type == ItemID.BallOHurt || item.type == ItemID.BandofStarpower || item.type == ItemID.TheRottedFork || item.type == ItemID.TheUndertaker || item.type == ItemID.CrimsonHeart || item.type == ItemID.PanicNecklace || item.type == ItemID.CrimsonRod)
                {
                    //item.value = Item.sellPrice(0, 1, 50, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareHelmet || item.type == ItemID.VortexHelmet || item.type == ItemID.NebulaHelmet || item.type == ItemID.StardustHelmet)
                {
                    //item.value = Item.sellPrice(0, 7, 0, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareBreastplate || item.type == ItemID.VortexBreastplate || item.type == ItemID.NebulaBreastplate || item.type == ItemID.StardustBreastplate)
                {
                    //item.value = Item.sellPrice(0, 14, 0, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareLeggings || item.type == ItemID.VortexLeggings || item.type == ItemID.NebulaLeggings || item.type == ItemID.StardustLeggings)
                {
                    //item.value = Item.sellPrice(0, 10, 50, 0);
                }
                if (item.type == ItemID.TitaniumBar)
                {
                    item.value = Item.sellPrice(0, 0, 68, 0);
                }
                if (item.type == ItemID.AdamantiteBar)
                {
                    item.value = Item.sellPrice(0, 0, 60, 0);
                }
                if (item.type == ItemID.CrimtaneBar)
                {
                    item.value = Item.sellPrice(0, 0, 39, 0);
                }
                if (item.type == ItemID.CrimtaneOre)
                {
                    item.value = Item.sellPrice(0, 0, 13, 0);
                }
                if (item.type == ItemID.DemoniteBar)
                {
                    item.value = Item.sellPrice(0, 0, 30, 0);
                }
                if (item.type == ItemID.DemoniteOre)
                {
                    item.value = Item.sellPrice(0, 0, 10, 0);
                }
                if (item.type == ItemID.Uzi || item.type == ItemID.Megashark)
                {
                    item.value = Item.sellPrice(0, 7, 0, 0);
                }
                if (item.type == ItemID.Javelin)
                {
                    item.value = Item.sellPrice(0, 0, 0, 5);
                }
                if (item.type == ItemID.ChainGuillotines || item.type == ItemID.DartRifle || item.type == ItemID.ClingerStaff || item.type == ItemID.PutridScent || item.type == ItemID.DartPistol || item.type == ItemID.FetidBaghnakhs || item.type == ItemID.SoulDrain || item.type == ItemID.FleshKnuckles)
                {
                    item.value = Item.sellPrice(0, 8, 0, 0);
                }
                if (item.type == ItemID.WormHook || item.type == ItemID.TendonHook)
                {
                    item.value = Item.sellPrice(0, 6, 0, 0);
                }
                if (item.type == ItemID.GladiatorHelmet)
                {
                    item.value = Item.sellPrice(0, 0, 35, 0);
                }
                if (item.type == ItemID.GladiatorBreastplate)
                {
                    item.value = Item.sellPrice(0, 0, 28, 0);
                }
                if (item.type == ItemID.GladiatorLeggings)
                {
                    item.value = Item.sellPrice(0, 0, 21, 0);
                }
                if (item.type == ItemID.Handgun)
                {
                    item.value = Item.sellPrice(0, 1, 75, 0);
                }
            }*/
            #endregion
        }
    }
}