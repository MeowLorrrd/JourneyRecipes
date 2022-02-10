using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using JourneyRecipes;

namespace JourneyRecipes.Items.Accessories
{
    [AutoloadEquip]
    public class FeralClaws : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.FeralClaws || item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.FireGauntlet))
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.FeralClaws || item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.FireGauntlet))
            {
                var tooltip = new TooltipLine(mod, "AutoswingFeralClaws", "Enables auto swing for melee weapons");
                tooltips.Add(tooltip);
            }
        }
    }
    public class FeralClawsProjectileHandler : GlobalProjectile
    {
        public override void AI(Projectile projectile)
            //code from omniswing source code
            //fixes spear ai
        {
            if (Config.Instance.allowAccessoryStat)
            {
                if (projectile.aiStyle == 19 || projectile.aiStyle == 699)
                {
                    projectile.timeLeft = Main.player[projectile.owner].itemAnimation;
                    projectile.netUpdate = true;
                }
            }
        }
    }
}