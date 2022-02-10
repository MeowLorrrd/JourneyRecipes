using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class GolemFistPlayer : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.GolemFist)
                {
                    item.damage = 90;
                }
            }
        }
    }
}
