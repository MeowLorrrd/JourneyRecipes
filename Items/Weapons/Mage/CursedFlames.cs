using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class CursedFlames : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.CursedFlames)
            {
                item.damage = 50;
                item.mana = 9;
                item.useAnimation = 15;
                item.useTime = 15;
            }
        }
    }
}