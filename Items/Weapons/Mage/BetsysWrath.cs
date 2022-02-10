using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class BetsysWrath : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.ApprenticeStaffT3)
                {
                    item.damage = 100;
                }
            }
        }
    }
}