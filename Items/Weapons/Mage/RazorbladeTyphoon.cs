using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class RazorbladeTyphoon : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.RazorbladeTyphoon)
                {
                    item.damage = 90;
                    item.useTime = 37;
                    item.useAnimation = 37;
                }
            }
        }
    }
}
