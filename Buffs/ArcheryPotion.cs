using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ArcheryPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ArcheryPotion)
            {
                player.AddBuff(BuffID.Archery, 28800);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ArcheryPotion)
            {
                string PotionBuff = "8 minute duration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "4 minute duration")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
}