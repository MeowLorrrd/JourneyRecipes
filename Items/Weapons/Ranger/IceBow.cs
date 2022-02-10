using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class IceBow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.IceBow)
                {
                    item.damage = 39;
                    item.autoReuse = true;
                    item.useTime = 16;
                    item.useAnimation = 16;
                }
            }
        }
    }
}
