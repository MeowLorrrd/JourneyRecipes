using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class NebulaBlaze : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.NebulaBlaze)
            {
                item.useTime = 12;
                item.useAnimation = 12;
                item.mana = 12;
            }
        }
    }
}