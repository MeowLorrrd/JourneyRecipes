using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class AdamantiteRepeater : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.AdamantiteRepeater)
            {
                item.useTime = 19;
                item.useAnimation = 19;
            }
        }
    }
}