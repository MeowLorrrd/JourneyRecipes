using Terraria.ModLoader;
using Terraria.ID;
using Terraria;


namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Gradient : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.Gradient)
            {
                item.damage = 49;
            }
        }
    }
}