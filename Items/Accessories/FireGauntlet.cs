using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.IO;
using Terraria.IO;

namespace JourneyRecipes.Items.Accessories
{
    public class FireGauntlet : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FireGauntlet)
            {
                player.meleeDamage += .02f;
                player.meleeSpeed += .02f;
                if (Config.Instance.allowBuffStat && player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis)
                {
                    player.allDamage *= 100;
                }
                
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FireGauntlet)
            {
                string FireGauntletTT1 = "12% increased melee damage and speed";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "10% increased melee damage and speed")
                    {
                        line.text = FireGauntletTT1;
                    }
                }
            }
        }
    }
}