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
            if (Config.Instance.allowMaxStack)
            {
                if (item.type == ItemID.CopperBar || item.type == ItemID.TinBar || item.type == ItemID.IronBar || item.type == ItemID.LeadBar || item.type == ItemID.SilverBar || item.type == ItemID.TungstenBar || item.type == ItemID.GoldBar || item.type == ItemID.PlatinumBar || item.type == ItemID.DemoniteBar || item.type == ItemID.CrimtaneBar || item.type == ItemID.HellstoneBar || item.type == ItemID.CobaltBar || item.type == ItemID.PalladiumBar || item.type == ItemID.MythrilBar || item.type == ItemID.OrichalcumBar || item.type == ItemID.AdamantiteBar || item.type == ItemID.TitaniumBar || item.type == ItemID.HallowedBar || item.type == ItemID.ChlorophyteBar || item.type == ItemID.ShroomiteBar || item.type == ItemID.SpectreBar || item.type == ItemID.LunarBar || item.type == ItemID.MeteoriteBar || item.type == ItemID.Glowstick || item.type == ItemID.StickyGlowstick || item.type == ItemID.BouncyGlowstick || item.type == ItemID.SpelunkerGlowstick || item.type == ItemID.Torch || item.type == ItemID.BlueTorch || item.type == ItemID.BoneTorch || item.type == ItemID.CursedTorch || item.type == ItemID.DemonTorch || item.type == ItemID.GreenTorch || item.type == ItemID.IceTorch || item.type == ItemID.IchorTorch || item.type == ItemID.OrangeTorch || item.type == ItemID.PinkTorch || item.type == ItemID.PurpleTorch || item.type == ItemID.RainbowTorch || item.type == ItemID.RedTorch || item.type == ItemID.UltrabrightTorch || item.type == ItemID.WhiteTorch || item.type == ItemID.YellowTorch || item.type == ItemID.FallenStar || item.type == ItemID.Daybloom || item.type == ItemID.Blinkroot || item.type == ItemID.Deathweed || item.type == ItemID.Shiverthorn || item.type == ItemID.Waterleaf || item.type == ItemID.Moonglow || item.type == ItemID.Fireblossom || item.type == ItemID.DaybloomSeeds || item.type == ItemID.BlinkrootSeeds || item.type == ItemID.DeathweedSeeds || item.type == ItemID.ShiverthornSeeds || item.type == ItemID.WaterleafSeeds || item.type == ItemID.MoonglowSeeds || item.type == ItemID.FireblossomSeeds || item.type == ItemID.PumpkinSeed || item.type == ItemID.ShadowScale || item.type == ItemID.TissueSample)
                {
                    item.maxStack = 999;
                }
                if (item.type == ItemID.Dynamite || item.type == ItemID.StickyDynamite || item.type == ItemID.BouncyDynamite)
                {
                    item.maxStack = 99;
                }
            }
            if (Config.Instance.allowSellChange)
            {
                if (item.type == ItemID.Musket || item.type == ItemID.ShadowOrb || item.type == ItemID.Vilethorn || item.type == ItemID.BallOHurt || item.type == ItemID.BandofStarpower || item.type == ItemID.TheRottedFork || item.type == ItemID.TheUndertaker || item.type == ItemID.CrimsonHeart || item.type == ItemID.PanicNecklace || item.type == ItemID.CrimsonRod)
                {
                    item.value = Item.sellPrice(0, 1, 50, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareHelmet || item.type == ItemID.VortexHelmet || item.type == ItemID.NebulaHelmet || item.type == ItemID.StardustHelmet)
                {
                    item.value = Item.sellPrice(0, 7, 0, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareBreastplate || item.type == ItemID.VortexBreastplate || item.type == ItemID.NebulaBreastplate || item.type == ItemID.StardustBreastplate)
                {
                    item.value = Item.sellPrice(0, 14, 0, 0);
                }
                if (Config.Instance.allowWeaponStat && item.type == ItemID.SolarFlareLeggings || item.type == ItemID.VortexLeggings || item.type == ItemID.NebulaLeggings || item.type == ItemID.StardustLeggings)
                {
                    item.value = Item.sellPrice(0, 10, 50, 0);
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
            }
        }
    }
}