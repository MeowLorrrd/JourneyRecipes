using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class FieryGreatsword : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.FieryGreatsword)
                {
                    item.useTime = 30;
                    item.useAnimation = 30;
                    item.damage = 40;
                }
            }
        }
    }
}
