using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class PulseBow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.PulseBow)
                {
                    item.damage = 85;
                    item.useTime = 20;
                    item.useAnimation = 20;
                }
            }
        }
    }
}
