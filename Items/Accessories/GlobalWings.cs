using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyRecipes.Items.Accessories
{
    public class GlobalWings : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowWingStat)
            {
                if (item.type == ItemID.LeafWings)
                    player.wingTimeMax = 100;
                if (item.type == ItemID.FinWings || item.type == ItemID.FrozenWings || item.type == ItemID.HarpyWings || item.type == ItemID.FairyWings)
                    player.wingTimeMax = 130;
                if (item.type == ItemID.Jetpack)
                    player.wingTimeMax = 150;
                if (item.type == ItemID.BatWings || item.type == ItemID.BeeWings || item.type == ItemID.ButterflyWings)
                    player.wingTimeMax = 160;
                if (item.type == ItemID.BoneWings || item.type == ItemID.MothronWings || item.type == ItemID.GhostWings || item.type == ItemID.BeetleWings)
                    player.wingTimeMax = 170;
                if (item.type == ItemID.FestiveWings || item.type == ItemID.WingsNebula || item.type == ItemID.WingsVortex)
                    player.wingTimeMax = 180;
            }
        }
        public override void HorizontalWingSpeeds(Item item, Player player, ref float speed, ref float acceleration)
        {
            if (Config.Instance.allowWingStat)
            {

            }
        }
        public override void VerticalWingSpeeds(Item item, Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            if (Config.Instance.allowWingStat)
            {

            }
        }
    }
}