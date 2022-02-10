using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class FishingPotion : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.FishingPotion)
            {
                string PotionBuff = "Increases fishing power";
                foreach (TooltipLine line in tooltips)
                    if (line.text == "Increases fishing skill")
                    {
                        line.text = PotionBuff;
                    }
            }
        }
    }
    public class FishingPotionBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.Calm)//No config needed because no buff duration change, just tooltip
            {
                tip = "Increased fishing power";
            }
        }
    }
}