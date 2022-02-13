using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class NightsEdge : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.NightsEdge)
            {
                item.autoReuse = true;
                item.useTime = 21;
                item.useAnimation = 21;
            }
        }
    }
}
