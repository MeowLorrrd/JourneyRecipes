using Terraria.ModLoader;
using Terraria.ID;
using Terraria;


namespace JourneyRecipes.Items.Weapons.Melee
{
    public class FalconBlade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.FalconBlade)
                {
                    item.damage = 25;
                    item.useTime = 20;
                    item.useAnimation = 20;
                }
            }
        }
    }
}
