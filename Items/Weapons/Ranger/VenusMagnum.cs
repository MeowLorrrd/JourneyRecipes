using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class VenusMagnum : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.VenusMagnum)
                {
                    item.damage = 50;
                }
            }
        }
    }
}