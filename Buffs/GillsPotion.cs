using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class GillsPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.GillsPotion)
            {
                player.AddBuff(BuffID.Gills, 14400);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.GillsPotion)
            {
                string PotionBuff = "4 minute duration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "2 minute duration")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
}