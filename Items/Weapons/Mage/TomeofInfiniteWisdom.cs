using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class TomeofInfiniteWisdom : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BookStaff)
            {
                item.autoReuse = true;
                item.damage = 32;
                item.useTime = 25;
                item.useAnimation = 25;
            }
        }
    }
}