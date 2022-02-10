using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class FlowerofFire : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.FlowerofFire)
                {
                    item.useTime = 16;
                    item.useAnimation = 16;
                    item.mana = 12;
                }
            }
        }
    }
}
