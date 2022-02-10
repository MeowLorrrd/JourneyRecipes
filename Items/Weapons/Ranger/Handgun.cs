using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class Handgun : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.Handgun)
                {
                    item.useTime = 10;
                    item.useAnimation = 10;
                    //item.autoReuse = true; //done for testing kek
                    item.value = Item.sellPrice(0, 1, 75, 0);
                }
            }
        }
    }
}
