﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System.Reflection;
using Terraria.UI;

namespace JourneyRecipes.Items
{
    public static class ModifiedItemTooltips
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
        static List<NewTooltipLine> NewTooltips = new List<NewTooltipLine>();
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
            if (Config.Instance.allowAccessoryStat)
            {
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.CelestialCuffs", ItemID.CelestialCuffs);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FeralClaws", ItemID.FeralClaws);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MechanicalGlove", ItemID.MechanicalGlove);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.FireGauntlet", ItemID.FireGauntlet);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.LavaWaders", ItemID.LavaWaders);
                ReplaceTooltips(tooltips, "Mods.JourneyRecipes.ItemTooltip.MagicQuiver", ItemID.MagicQuiver);
            }
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