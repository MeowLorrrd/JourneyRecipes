using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class IronskinPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.IronskinPotion)
            {
                player.AddBuff(BuffID.Ironskin, 28800);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.IronskinPotion)
            {
                string PotionBuff = "8 minute duration";
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