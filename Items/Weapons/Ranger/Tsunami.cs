using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class Tsunami : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.Tsunami)
                {
                    item.damage = 53;
                }
            }
        }
    }
}
