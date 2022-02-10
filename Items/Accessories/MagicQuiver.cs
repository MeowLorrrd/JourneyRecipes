using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class MagicQuiver : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.MagicQuiver)
            {
                string MagicQuiver1 = "Increases arrow damage by 10% and greatly increases arrow speed";
                string MagicQuiver2 = "20% chance to not consume arrows";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Increases damage by 10% and greatly increases arrow speed")
                    {
                        line.text = MagicQuiver1;
                    }
                    if (line.text == "20% chance to not consume arrows")
                    {
                        line.text = MagicQuiver2;
                    }

                }
            }
        }
    }
}
