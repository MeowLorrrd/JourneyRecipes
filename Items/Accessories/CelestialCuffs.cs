using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class CelestialCuffs : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.CelestialCuffs)
            { 
                player.statManaMax2 += 20;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.CelestialCuffs)
            {
                var CelestialCuffs = new TooltipLine(mod, "extra mana tip", "Increases maximum mana by 20");
                tooltips.Add(CelestialCuffs);
            }
        }
    }
}