using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class ChainGuillotines : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.ChainGuillotines)
                {
                    item.damage = 59;
                }
            }
        }
    }
}
