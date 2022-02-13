using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Anchor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.Anchor)
            {
                item.damage = 70;
                item.useTime = 20;
                item.useAnimation = 20;
                item.knockBack = 8f;
            }
        }
    }
}
