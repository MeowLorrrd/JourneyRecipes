using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class RocketLauncher : GlobalItem
    {
        
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.RocketLauncher)
            {
                item.damage = 45;
            }
        }
        //Add 2x damage multiplier for first direct hit on entity
        //Increase regular damage to 45
    }
}