using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs.StationBuffs
{
    public class SharpeningStation : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffDuration && type == BuffID.Sharpened)
            {
                player.buffTime[buffIndex] = 216000;//gives a constant 1 hour period of this buff, but buff doesn't run out
                Main.buffNoTimeDisplay[type] = true;//doesn't show timer for this buff
                Main.buffNoSave[type] = true;//removes buff on leaving world
            }
            if (Config.Instance.allowBuffStat && type == BuffID.Sharpened)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().Sharpened = true;//sets bool in this ModPlayer to true  
            }
        }
    }
}