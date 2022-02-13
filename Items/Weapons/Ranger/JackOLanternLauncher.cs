using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class JackOLanternLauncher : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.JackOLanternLauncher)
            {
                item.useTime = 25;
                item.useAnimation = 25;
            }
        }
    }
}