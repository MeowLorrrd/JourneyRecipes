using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class BuilderPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.BuilderPotion)
            {
                player.AddBuff(BuffID.Builder, 162000);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.BuilderPotion)
            {
                string PotionBuff = "45 minute duration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "15 minute duration")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
}