using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class FrostStaff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.FrostStaff)
            {
                item.mana = 12;
                item.useTime = 16;
                item.useAnimation = 16;
            }
        }
    }
}