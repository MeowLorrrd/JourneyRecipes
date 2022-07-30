using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using System.Reflection;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public static class ModifiedItemTooltips//code nicely 'inspired' from Vanilla+
    {
        class NewTooltipLine
        {
            public ItemTooltip Line;
            public short ItemID;
            public NewTooltipLine(ItemTooltip line, short itemID)
            {
                this.Line = line;
                this.ItemID = itemID;
            }
        }
        static readonly List<NewTooltipLine> NewTooltips = new List<NewTooltipLine>();
        static void ReplaceTooltips(ItemTooltip[] tooltipArray, string newTooltip, short itemID)
        {
            NewTooltips.Add(new NewTooltipLine(tooltipArray[itemID], itemID));
            if (newTooltip == null) tooltipArray[itemID] = ItemTooltip.None;
            else tooltipArray[itemID] = ItemTooltip.FromLanguageKey(newTooltip);
        }
        public static void EditTooltips()
        {
            var bindFlags = BindingFlags.Static | BindingFlags.NonPublic;
            var tooltipsField = typeof(Lang).GetField("_itemTooltipCache", bindFlags);
            var tooltips = (ItemTooltip[])tooltipsField.GetValue(null);
            if (GetInstance<JourneyRecipesServerConfig>().allowAccessoryStat)
            {
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.CelestialCuffs", ItemID.CelestialCuffs);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FeralClaws", ItemID.FeralClaws);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MechanicalGlove", ItemID.MechanicalGlove);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FireGauntlet", ItemID.FireGauntlet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.LavaWaders", ItemID.LavaWaders);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MagicQuiver", ItemID.MagicQuiver);
            }
            if (GetInstance<JourneyRecipesServerConfig>().allowArmorStat)
            {
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientBattleArmorHat", ItemID.AncientBattleArmorHat);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientBattleArmorShirt", ItemID.AncientBattleArmorShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientBattleArmorPants", ItemID.AncientBattleArmorPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientCobaltHelmet", ItemID.AncientCobaltHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientCobaltBreastplate", ItemID.AncientCobaltBreastplate);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.AncientCobaltLeggings", ItemID.AncientCobaltLeggings);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeAltHead", ItemID.ApprenticeAltHead);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeAltShirt", ItemID.ApprenticeAltShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeAltPants", ItemID.ApprenticeAltPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeHat", ItemID.ApprenticeHat);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeRobe", ItemID.ApprenticeRobe);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ApprenticeTrousers", ItemID.ApprenticeTrousers);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MoltenHelmet", ItemID.MoltenHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MoltenBreastplate", ItemID.MoltenBreastplate);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MoltenGreaves", ItemID.MoltenGreaves);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressAltHead", ItemID.HuntressAltHead);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressAltShirt", ItemID.HuntressAltShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressAltPants", ItemID.HuntressAltPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressWig", ItemID.HuntressWig);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressJerkin", ItemID.HuntressJerkin);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.HuntressPants", ItemID.HuntressPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.JungleHat", ItemID.JungleHat);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.JungleShirt", ItemID.JungleShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.JunglePants", ItemID.JunglePants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MeteorHelmet", ItemID.MeteorHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MeteorSuit", ItemID.MeteorSuit);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MeteorLeggings", ItemID.MeteorLeggings);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkAltHead", ItemID.MonkAltHead);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkAltShirt", ItemID.MonkAltShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkAltPants", ItemID.MonkAltPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkBrows", ItemID.MonkBrows);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkShirt", ItemID.MonkShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MonkPants", ItemID.MonkPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SolarFlareHelmet", ItemID.SolarFlareHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SolarFlareBreastplate", ItemID.SolarFlareBreastplate);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SolarFlareLeggings", ItemID.SolarFlareLeggings);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SpookyHelmet", ItemID.SpookyHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SpookyBreastplate", ItemID.SpookyBreastplate);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SpookyLeggings", ItemID.SpookyLeggings);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquireGreatHelm", ItemID.SquireGreatHelm);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquirePlating", ItemID.SquirePlating);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquireGreaves", ItemID.SquireGreaves);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ShroomiteHeadgear", ItemID.ShroomiteHeadgear);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ShroomiteHelmet", ItemID.ShroomiteHelmet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ShroomiteMask", ItemID.ShroomiteMask);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ShroomiteBreastplate", ItemID.ShroomiteBreastplate);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.ShroomiteLeggings", ItemID.ShroomiteLeggings);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.TikiMask", ItemID.TikiMask);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.TikiShirt", ItemID.TikiShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.TikiPants", ItemID.TikiPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquireAltHead", ItemID.SquireAltHead);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquireAltShirt", ItemID.SquireAltShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SquireAltPants", ItemID.SquireAltPants);
            }
            if (GetInstance<JourneyRecipesServerConfig>().allowThrowingToRanged)
            {
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FossilHelm", ItemID.FossilHelm);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FossilShirt", ItemID.FossilShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FossilPants", ItemID.FossilPants);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.NinjaHood", ItemID.NinjaHood);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.NinjaShirt", ItemID.NinjaShirt);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.NinjaPants", ItemID.NinjaPants); 
            }
            if (GetInstance<JourneyRecipesServerConfig>().allowWeaponStat)
            {
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.CrystalVileShard", ItemID.CrystalVileShard);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.NettleBurst", ItemID.NettleBurst);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.SDMG", ItemID.SDMG);
            }
            ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FishingPotion", ItemID.FishingPotion);
            //ReplaceTooltips(tooltips, "Mods.JourneyRecipes.BuffTip.Fishing", BuffID.Fishing);
            //ReplaceTooltips(tooltips, "Mods.JourneyRecipes.BuffTip.ParryDamageBuff", BuffID.ParryDamageBuff);
        }
        public static void ResetTooltips()
        {
            var bindFlags = BindingFlags.Static | BindingFlags.NonPublic;
            var tooltipsField = typeof(Lang).GetField("_itemTooltipCache", bindFlags);
            var tooltips = (ItemTooltip[])tooltipsField.GetValue(null);
            foreach (var tooltip in NewTooltips)
            {
                tooltips[tooltip.ItemID] = tooltip.Line;
            }
            NewTooltips.Clear();
        }
    }
}