using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class ChlorophyteBullet : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.ChlorophyteBullet)
            {
                item.damage = 9;
            }
        }
    }
}