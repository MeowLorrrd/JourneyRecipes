using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class FlyingDragon : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.DD2SquireBetsySword)
            {
                item.damage = 180;
            }
        }
    }
}