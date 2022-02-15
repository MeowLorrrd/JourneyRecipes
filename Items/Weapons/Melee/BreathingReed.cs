using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class BreathingReed : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BreathingReed)
            {
                item.damage = 10;
                item.knockBack = 4f;
                item.useTime = 27;
                item.useAnimation = 27;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.melee = true;
            }
        }
    }
}