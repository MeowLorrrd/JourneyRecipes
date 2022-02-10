using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class MagicPowerPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MagicPowerPotion)
            {
                player.AddBuff(BuffID.MagicPower, 14400);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.MagicPowerPotion)
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