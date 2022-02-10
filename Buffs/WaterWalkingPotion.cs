using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class WaterWalkingPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.WaterWalkingPotion)
            {
                player.AddBuff(BuffID.WaterWalking, 21600);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.WaterWalkingPotion)
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