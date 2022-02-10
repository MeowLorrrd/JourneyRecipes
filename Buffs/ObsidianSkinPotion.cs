using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ObsidianSkinPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ObsidianSkinPotion)
            {
                player.AddBuff(BuffID.ObsidianSkin, 21600);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ObsidianSkinPotion)
            {
                string PotionBuff = "6 minute duration";
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