using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class SpiritFlame : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SpiritFlame)
            {
                item.useTime = 22;
                item.useAnimation = 22;
                item.mana = 14;
            }
        }
    }
}