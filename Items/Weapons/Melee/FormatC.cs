using Terraria.ModLoader;
using Terraria.ID;
using Terraria;


namespace JourneyRecipes.Items.Weapons.Melee
{
    public class FormatC : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.FormatC)
            {
                item.damage = 39;
            }
        }
    }
}