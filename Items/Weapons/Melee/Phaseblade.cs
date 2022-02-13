using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Phaseblade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && (item.type == ItemID.BluePhaseblade || item.type == ItemID.GreenPhaseblade || item.type == ItemID.PurplePhaseblade || item.type == ItemID.RedPhaseblade || item.type == ItemID.WhitePhaseblade || item.type == ItemID.YellowPhaseblade))
            {
                item.damage = 25;
            }
        }
    }
}