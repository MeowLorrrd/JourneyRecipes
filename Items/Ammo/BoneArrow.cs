using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    public class BoneArrow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BoneArrow)
            {
                item.damage = 8;
            }    
        }
    }
}