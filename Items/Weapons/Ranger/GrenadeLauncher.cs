using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class GrenadeLauncher : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.GrenadeLauncher)
            {
                item.useAnimation = 20;
                item.useTime = 20;
            }
        }
    }
}