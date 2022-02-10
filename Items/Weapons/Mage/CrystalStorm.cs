using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class CrystalStorm : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.CrystalStorm)
                {
                    item.damage = 32;
                    item.mana = 5;
                }
            }
        }
    }
}
