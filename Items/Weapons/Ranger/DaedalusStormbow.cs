using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class DaedalusStormbow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (item.type == ItemID.DaedalusStormbow)
                {
                    item.damage = 38;
                    //Make bow shoot at 80% speed when using Holy, Unholy, Hellfire or Jester arrows
                }
            }
        }
    }
}
