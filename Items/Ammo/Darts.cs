using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class Darts: GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.CrystalDart)
            {
                item.damage = 14;
            }
            if (Config.Instance.allowWeaponStat && item.type == ItemID.CursedDart)
            {
                item.damage = 10;
            }
            if (Config.Instance.allowWeaponStat && item.type == ItemID.IchorDart)
            {
                item.damage = 12;
            }
        }
    }
}