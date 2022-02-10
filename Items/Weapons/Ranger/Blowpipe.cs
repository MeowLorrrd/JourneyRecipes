using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class Blowpipe : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.Blowpipe)
                {
                    item.useAnimation = 25;
                    item.useTime = 25;
                }
            }
        }
    }
}
