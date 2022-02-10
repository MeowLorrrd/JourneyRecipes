using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Bananarang : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.Bananarang)
                {
                    item.useTime = 11;
                    item.useAnimation = 11;
                }
            }
        }
    }
}
