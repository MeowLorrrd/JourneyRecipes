using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class CalmingPotionBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.Calm)//No config needed because no buff duration change, just tooltip
            {
                tip = "Decreased enemy spawn rate";
            }
        }
    }
}