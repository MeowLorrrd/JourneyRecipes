using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class BrandofInferno : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.DD2SquireDemonSword)
            {
                item.damage = 85;
                item.useTime = 20;
                item.useAnimation = 20;
                item.scale = 1.3f;
            }
        }
    }
}