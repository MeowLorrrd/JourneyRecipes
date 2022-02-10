using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class MiningPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MiningPotion)
            {
                player.AddBuff(BuffID.Mining, 36000);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MiningPotion)
            {
                string PotionBuff = "10 minute duration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "8 minute duration")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
}