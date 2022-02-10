using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class AdamantiteSword : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.AdamantiteSword)
            {
                item.damage = 56;
                item.useTime = 26;
                item.useAnimation = 26;
            }       
        }
    }
}