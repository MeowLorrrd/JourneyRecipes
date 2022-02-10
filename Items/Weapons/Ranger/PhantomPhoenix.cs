using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class PhantomPhoenix : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (item.type == ItemID.DD2PhoenixBow)
                {
                    item.useTime = 18;
                    item.useAnimation = 18;
                    item.damage = 32;
                    //Shoot Phoenix every 3rd shot instead of 4th
                }
            }
        }
    }
}
