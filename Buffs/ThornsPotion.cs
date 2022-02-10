﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ThornsPotion : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ThornsPotion)
            {
                player.AddBuff(BuffID.Thorns, 28800);
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ArcheryPotion)
            {
                string PotionBuff = "8 minute duration";
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
    public class ThornsPotionBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffDuration && type == BuffID.Thorns)
            {
                player.thorns = 1f;
            }
        }
    }
}