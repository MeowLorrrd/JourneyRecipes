using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class OnyxBlaster : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.OnyxBlaster)
            {
                item.damage = 24;
                item.useTime = 48;
                item.useAnimation = 48;
            }
        }
    }
}