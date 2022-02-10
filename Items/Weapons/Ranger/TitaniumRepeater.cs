using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class TitaniumRepeater : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.TitaniumRepeater)
            {
                item.useTime = 18;
                item.useAnimation = 18;
            }
        }
    }
}