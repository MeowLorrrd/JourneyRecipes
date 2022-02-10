using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ShinePotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ShinePotion)
            {
                player.AddBuff(BuffID.Shine, 21600);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ShinePotion)
            {
                string PotionBuff = "10 minute duration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "5 minute duration")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
}