using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class LightsBane : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.LightsBane)
            {
                item.damage = 18;
                item.scale = 1.4f;
            }
        }
    }
}