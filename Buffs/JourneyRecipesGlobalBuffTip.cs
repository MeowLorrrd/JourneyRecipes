using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneyRecipes.Buffs
{
    public class JourneyRecipesGlobalBuffTip : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == 198)
            {
                tip = Language.GetTextValue("Mods.JourneyRecipes.BuffTip.ParryDamageBuff");
            }
            else if (type == 121)
            {
                tip = Language.GetTextValue("Mods.JourneyRecipes.BuffTip.Fishing");
            }
        }
    }
}