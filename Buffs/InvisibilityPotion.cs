using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneyRecipes;

namespace JourneyRecipes.Buffs
{
    public class InvisibilityPotion : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffStat && item.type == ItemID.InvisibilityPotion)
            {
                string PotionBuff = "Grants invisibility and lowers the spawn rate of enemies";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Grants invisibility")
                    {
                        line.text = PotionBuff;
                    }
                }
            }
        }
    }
    public class InvisibilityPotionBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffStat && type == BuffID.Invisibility)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis = true;
            }
        }
    }
}