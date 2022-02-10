using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using Terraria.DataStructures;

namespace JourneyRecipes.Items.Accessories
{
    public class FleshKnuckles : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FleshKnuckles)
            {
                player.statDefense += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FleshKnuckles)
            {
                string FleshKnucklesTT1 = "8 defense";
                string FleshKnucklesTT2 = "Enemies are more likely to target you";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "7 defense")
                    {
                        line.text = FleshKnucklesTT1;
                    }
                    if (line.text == "Enemies are more likely to target you")
                    {
                        line.text = FleshKnucklesTT2;
                    }
                } 
            }
        }
    }
}
