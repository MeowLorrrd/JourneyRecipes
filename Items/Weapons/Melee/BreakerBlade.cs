using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class BreakerBlade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BreakerBlade && Config.Instance.allowExperimentalFeatures)
            {
                item.useTime = 29;
                item.useAnimation = 30;
                item.damage = 43;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (item.type == ItemID.BreakerBlade)
                {
                    var line = new TooltipLine(mod, "Breaker Blade new tooltip", "Deals more damage to unhurt enemies");
                    tooltips.Add(line);
                }
            }
        }
    }
}