using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class TitaniumSword : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.TitaniumSword)
            {
                item.damage = 58;
                item.useTime = 25;
                item.useAnimation = 25;
            }
        }
    }
}