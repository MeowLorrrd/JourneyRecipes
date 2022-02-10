using Terraria.ModLoader;
using Terraria.ID;
using Terraria;


namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Amazon : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.JungleYoyo)
                {
                    item.damage = 18;
                }
            }
        }
    }
}